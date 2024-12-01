using SharedModels;
using SharedModels.Dto.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ProyectosForm : Form
    {
        private readonly ApiClient _apiClient;
        private int selectedProyectoId = -1;
        public ProyectosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }
        private void LoadEstadoComboBox()
        {
            cbEstado.Items.Add("En Espera");
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Completado");
            cbEstado.Items.Add("Cancelado");
            cbEstado.SelectedIndex = 0;
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedProyectoId != -1)
            {
                try
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var success = await _apiClient.Proyectos.DeleteAsync(selectedProyectoId); // Usar await aquí
                        if (success)
                        {
                            MessageBox.Show("¡Proyecto eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await RefreshData();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            cbClienteID.SelectedIndex = -1;
            cbEstado.SelectedIndex = 0;
            txtNombreProyecto.Clear();
            txtDescripcion.Clear();
            txtUbicacion.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtPresupuestoTotal.Clear();
            selectedProyectoId = -1;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedProyectoId != -1)
            {
                try
                {
                    var proyectoActualizado = new Proyecto
                    {
                        ProyectoID = selectedProyectoId,
                        ClienteID = cbClienteID.SelectedValue.ToString(),
                        NombreProyecto = txtNombreProyecto.Text,
                        Descripcion = txtDescripcion.Text,
                        Ubicacion = txtUbicacion.Text,
                        FechaInicio = dtpFechaInicio.Value,
                        FechaFin = dtpFechaFin.Value,
                        PresupuestoTotal = decimal.TryParse(txtPresupuestoTotal.Text, out decimal presupuestoTotal) ? presupuestoTotal : throw new Exception("Presupuesto inválido"),
                        Estado = cbEstado.SelectedItem.ToString()
                    };

                    var success = await _apiClient.Proyectos.UpdateAsync(selectedProyectoId, proyectoActualizado); // Usar await aquí

                    if (success)
                    {
                        MessageBox.Show("¡Proyecto actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProyecto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text) ||
                cbClienteID.SelectedIndex == -1)

                {
                    MessageBox.Show("Por favor, complete todos los campos y asegúrese de que el presupuesto sea un valor válido.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txtPresupuestoTotal.Text, out decimal presupuestoTotal) || presupuestoTotal <= 0)
                {
                    MessageBox.Show("El presupuesto debe ser un número válido y mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoProyecto = new Proyecto
                {
                    ClienteID = cbClienteID.SelectedValue.ToString(),
                    NombreProyecto = txtNombreProyecto.Text,
                    Descripcion = txtDescripcion.Text,
                    Ubicacion = txtUbicacion.Text,
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value,
                    PresupuestoTotal = presupuestoTotal,
                    Estado = cbEstado.SelectedItem.ToString()
                };

                var result = await _apiClient.Proyectos.CreateAsync(nuevoProyecto);

                MessageBox.Show("¡Proyecto agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshData();
                LimpiarCampos();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar proyecto: {ex.Message}\nTipo: {ex.GetType().Name}\nDetalles: {ex.StackTrace}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void ProyectosForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            await LoadClientes();
            LoadEstadoComboBox();
        }

        private async Task LoadClientes()
        {
            try
            {
                var clientes = await _apiClient.Clientes.GetAllAsync();
                cbClienteID.DataSource = clientes;
                cbClienteID.DisplayMember = "ClienteID";
                cbClienteID.ValueMember = "ClienteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var proyectos = await _apiClient.Proyectos.GetAllAsync();
                dgvProyectos.DataSource = proyectos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var proyecto = (ProyectoDto)dgvProyectos.Rows[e.RowIndex].DataBoundItem;
                    selectedProyectoId = proyecto.ProyectoID;
                    cbClienteID.SelectedValue = proyecto.ClienteID;
                    txtNombreProyecto.Text = proyecto.NombreProyecto;
                    txtDescripcion.Text = proyecto.Descripcion;
                    txtUbicacion.Text = proyecto.Ubicacion;
                    dtpFechaInicio.Value = proyecto.FechaInicio;
                    dtpFechaFin.Value = proyecto.FechaFin;
                    txtPresupuestoTotal.Text = proyecto.PresupuestoTotal.ToString();
                    cbEstado.SelectedItem = proyecto.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
