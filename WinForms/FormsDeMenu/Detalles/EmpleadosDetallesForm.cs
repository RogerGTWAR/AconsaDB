using SharedModels.Dto.EmpleadoDetalle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.FormsDeMenu.Detalles
{
    public partial class EmpleadosDetallesForm : Form
    {
        private readonly ApiClient _apiClient;
        public EmpleadosDetallesForm(HttpClient httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de empleado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvEmpleadosDetalles.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["empleadoDetalleIDDataGridViewTextBoxColumn"].Value);

            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detalleModificado = new EmpleadoDetallesDto
            {
                Empleado_DetalleID = detalleID,
                EmpleadoID = (int)cbEmpleadoID.SelectedValue,
                ProyectoID = (int)cbProyectoID.SelectedValue,
                FechaDeProyecto = dtpFechaProyecto.Value
            };

            try
            {
                var success = await _apiClient.EmpleadosDetalles.UpdateAsync(detalleID, detalleModificado);

                if (success)
                {
                    MessageBox.Show("Detalle de empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshData();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el detalle del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el detalle del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvEmpleadosDetalles.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["empleadoDetalleIDDataGridViewTextBoxColumn"].Value);

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el detalle con ID {detalleID}?",
                                                "Confirmación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var success = await _apiClient.EmpleadosDetalles.DeleteAsync(detalleID);

                    if (success)
                    {
                        MessageBox.Show("Detalle de empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el detalle del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoDetalle = new EmpleadoDetallesDto
            {
                EmpleadoID = (int)cbEmpleadoID.SelectedValue,
                ProyectoID = (int)cbProyectoID.SelectedValue,
                FechaDeProyecto = dtpFechaProyecto.Value
            };

            try
            {
                var success = await _apiClient.EmpleadosDetalles.CreateAsync(nuevoDetalle);

                if (success != null)
                {
                    MessageBox.Show("¡Detalle de empleado agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await RefreshData();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el detalle del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cbEmpleadoID.SelectedIndex = -1;
            cbProyectoID.SelectedIndex = -1;
            dtpFechaProyecto.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            if (cbEmpleadoID.SelectedIndex == -1)
            {
                cbEmpleadoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbEmpleadoID.BackColor = Color.White;
            }

            if (cbProyectoID.SelectedIndex == -1)
            {
                cbProyectoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbProyectoID.BackColor = Color.White;
            }

            return esValido;
        }

        private void dgvEmpleadosDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var detalle = (EmpleadoDetallesDto)dgvEmpleadosDetalles.Rows[e.RowIndex].DataBoundItem;
                    cbEmpleadoID.SelectedValue = detalle.EmpleadoID;
                    cbProyectoID.SelectedValue = detalle.ProyectoID;
                    dtpFechaProyecto.Value = detalle.FechaDeProyecto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar detalle del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EmpleadosDetallesForm_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
            await CargarProyectos();
            await RefreshData();
        }
        private async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _apiClient.Empleados.GetAllAsync();
                cbEmpleadoID.DataSource = empleados.ToList();
                cbEmpleadoID.DisplayMember = "Nombres"; 
                cbEmpleadoID.ValueMember = "EmpleadoID";
                cbEmpleadoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarProyectos()
        {
            try
            {
                var proyectos = await _apiClient.Proyectos.GetAllAsync();
                cbProyectoID.DataSource = proyectos.ToList();
                cbProyectoID.DisplayMember = "NombreProyecto";
                cbProyectoID.ValueMember = "ProyectoID";
                cbProyectoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var detalles = await _apiClient.EmpleadosDetalles.GetAllAsync();
                dgvEmpleadosDetalles.DataSource = detalles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
