using SharedModels.Dto.MaquinariaDetalle;
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
    public partial class MaquinariaDetallesForm : Form
    {
        private readonly ApiClient _apiClient;
        public MaquinariaDetallesForm(HttpClient httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void dgvMaquinariaDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var detalle = (MaquinariaDetallesDto)dgvMaquinariaDetalle.Rows[e.RowIndex].DataBoundItem;
                    cbProyectoID.SelectedValue = detalle.ProyectoID;
                    cbMaquinariaID.SelectedValue = detalle.MaquinariaID;
                    txtHorasUtilizadas.Text = detalle.HorasUtilizadas.ToString();
                    dtpFechaInicioAsignacion.Value = detalle.FechaInicioAsignacion;
                    dtpFechaFinAsignacion.Value = detalle.FechaFinAsignacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar detalle de maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMaquinariaDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de maquinaria para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvMaquinariaDetalle.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["maquinariaDetalleIDDataGridViewTextBoxColumn"].Value);

            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detalleModificado = new MaquinariaDetallesDto
            {
                Maquinaria_DetalleID = detalleID,
                ProyectoID = (int)cbProyectoID.SelectedValue,
                MaquinariaID = (int)cbMaquinariaID.SelectedValue,
                HorasUtilizadas = int.Parse(txtHorasUtilizadas.Text),
                FechaInicioAsignacion = dtpFechaInicioAsignacion.Value,
                FechaFinAsignacion = dtpFechaFinAsignacion.Value
            };

            try
            {
                var success = await _apiClient.MaquinariasDetalles.UpdateAsync(detalleID, detalleModificado);

                if (success)
                {
                    MessageBox.Show("Detalle de maquinaria modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshData();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el detalle de maquinaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el detalle de maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaquinariaDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de maquinaria para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvMaquinariaDetalle.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["maquinariaDetalleIDDataGridViewTextBoxColumn"].Value);

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el detalle con ID {detalleID}?",
                                                "Confirmación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var success = await _apiClient.MaquinariasDetalles.DeleteAsync(detalleID);

                    if (success)
                    {
                        MessageBox.Show("Detalle de maquinaria eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle de maquinaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el detalle de maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var nuevoDetalle = new MaquinariaDetallesDto
            {
                ProyectoID = (int)cbProyectoID.SelectedValue,
                MaquinariaID = (int)cbMaquinariaID.SelectedValue,
                HorasUtilizadas = int.Parse(txtHorasUtilizadas.Text),
                FechaInicioAsignacion = dtpFechaInicioAsignacion.Value,
                FechaFinAsignacion = dtpFechaFinAsignacion.Value
            };

            try
            {
                var success = await _apiClient.MaquinariasDetalles.CreateAsync(nuevoDetalle);

                if (success != null)
                {
                    MessageBox.Show("¡Detalle de maquinaria agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await RefreshData();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle de maquinaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el detalle de maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cbProyectoID.SelectedIndex = -1;
            cbMaquinariaID.SelectedIndex = -1;
            txtHorasUtilizadas.Clear();
            dtpFechaInicioAsignacion.Value = DateTime.Now;
            dtpFechaFinAsignacion.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            if (cbProyectoID.SelectedIndex == -1)
            {
                cbProyectoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbProyectoID.BackColor = Color.White;
            }

            if (cbMaquinariaID.SelectedIndex == -1)
            {
                cbMaquinariaID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbMaquinariaID.BackColor = Color.White;
            }

            if (!int.TryParse(txtHorasUtilizadas.Text, out _))
            {
                txtHorasUtilizadas.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtHorasUtilizadas.BackColor = Color.White;
            }

            return esValido;
        }

        private async void MaquinariaDetallesForm_Load(object sender, EventArgs e)
        {
            await CargarProyectos();
            await CargarMaquinarias();
            await RefreshData();
        }
        private async Task CargarProyectos()
        {
            try
            {
                var proyectos = await _apiClient.Proyectos.GetAllAsync();
                cbProyectoID.DataSource = proyectos.ToList();
                cbProyectoID.DisplayMember = "NombreProyecto"; // Ajustar según el modelo.
                cbProyectoID.ValueMember = "ProyectoID";
                cbProyectoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarMaquinarias()
        {
            try
            {
                var maquinarias = await _apiClient.Maquinarias.GetAllAsync();
                cbMaquinariaID.DataSource = maquinarias.ToList();
                cbMaquinariaID.DisplayMember = "NombreMaquinaria"; // Ajustar según el modelo.
                cbMaquinariaID.ValueMember = "MaquinariaID";
                cbMaquinariaID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar maquinarias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var detalles = await _apiClient.MaquinariasDetalles.GetAllAsync();
                dgvMaquinariaDetalle.DataSource = detalles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de maquinarias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
