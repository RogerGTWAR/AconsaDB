using SharedModels.Dto.VehiculoDetalle;
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
    public partial class VehiculosDetallesForm : Form
    {
        private readonly ApiClient _apiClient;
        public VehiculosDetallesForm(HttpClient httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoDetalle = new VehiculoDetallesDto
            {
                EmpleadoID = (int)cbEmpleadoID.SelectedValue,
                VehiculoID = (int)cbVehiculoID.SelectedValue,
                FechaAsignacion = dtpFechaAsignacion.Value,
                FechaFinAsignacion = dtpFechaFinAsignacion.Value,
                Descripcion = txtDescripcion.Text
            };

            try
            {
                var success = await _apiClient.VehiculosDetalles.CreateAsync(nuevoDetalle);

                if (success != null)
                {
                    MessageBox.Show("¡Detalle de vehículo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await RefreshData();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el detalle del vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculoDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvVehiculoDetalles.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["vehiculoDetalleIDDataGridViewTextBoxColumn"].Value);

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el detalle con ID {detalleID}?",
                                                "Confirmación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var success = await _apiClient.VehiculosDetalles.DeleteAsync(detalleID);

                    if (success)
                    {
                        MessageBox.Show("Detalle de vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el detalle del vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculoDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de vehículo para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvVehiculoDetalles.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["vehiculoDetalleIDDataGridViewTextBoxColumn"].Value);

            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detalleModificado = new VehiculoDetallesDto
            {
                Vehiculo_DetalleID = detalleID,
                EmpleadoID = (int)cbEmpleadoID.SelectedValue,
                VehiculoID = (int)cbVehiculoID.SelectedValue,
                FechaAsignacion = dtpFechaAsignacion.Value,
                FechaFinAsignacion = dtpFechaFinAsignacion.Value,
                Descripcion = txtDescripcion.Text
            };

            try
            {
                var success = await _apiClient.VehiculosDetalles.UpdateAsync(detalleID, detalleModificado);

                if (success)
                {
                    MessageBox.Show("Detalle de vehículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshData();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el detalle del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el detalle del vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVehiculoDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var detalle = (VehiculoDetallesDto)dgvVehiculoDetalles.Rows[e.RowIndex].DataBoundItem;
                    cbEmpleadoID.SelectedValue = detalle.EmpleadoID;
                    cbVehiculoID.SelectedValue = detalle.VehiculoID;
                    dtpFechaAsignacion.Value = detalle.FechaAsignacion;
                    dtpFechaFinAsignacion.Value = detalle.FechaFinAsignacion;
                    txtDescripcion.Text = detalle.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar detalle del vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cbEmpleadoID.SelectedIndex = -1;
            cbVehiculoID.SelectedIndex = -1;
            dtpFechaAsignacion.Value = DateTime.Now;
            dtpFechaFinAsignacion.Value = DateTime.Now;
            txtDescripcion.Clear();
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

            if (cbVehiculoID.SelectedIndex == -1)
            {
                cbVehiculoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbVehiculoID.BackColor = Color.White;
            }

            return esValido;
        }

        private async void VehiculosDetallesForm_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
            await CargarVehiculos();
            await RefreshData();
        }
        private async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _apiClient.Empleados.GetAllAsync();
                cbEmpleadoID.DataSource = empleados.ToList();
                cbEmpleadoID.DisplayMember = "Nombres"; // Ajustar según el modelo.
                cbEmpleadoID.ValueMember = "EmpleadoID";
                cbEmpleadoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarVehiculos()
        {
            try
            {
                var vehiculos = await _apiClient.Vehiculos.GetAllAsync();
                cbVehiculoID.DataSource = vehiculos.ToList();
                cbVehiculoID.DisplayMember = "Modelo"; // Ajustar según el modelo.
                cbVehiculoID.ValueMember = "VehiculoID";
                cbVehiculoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var detalles = await _apiClient.VehiculosDetalles.GetAllAsync();
                dgvVehiculoDetalles.DataSource = detalles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
