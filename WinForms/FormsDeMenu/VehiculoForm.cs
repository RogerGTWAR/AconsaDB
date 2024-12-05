using SharedModels.Dto.Vehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    //Falta
    public partial class VehiculoForm : Form
    {
        private readonly ApiClient _apiClient;
        public VehiculoForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }

        private async void VehiculoForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            await CargarProveedoresYEstados();
        }
        private async Task CargarProveedoresYEstados()
        {
            try
            {
                var proveedores = await _apiClient.Proveedores.GetAllAsync();
                cbProveedorID.DataSource = proveedores.ToList();
                cbProveedorID.DisplayMember = "NombreEmpresa";
                cbProveedorID.ValueMember = "ProveedorID";
                cbProveedorID.SelectedIndex = -1;

                cbEstado.DataSource = new List<string> { "Disponible", "En Mantenimiento", "No Disponible" };
                cbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores o estados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RefreshData()
        {
            try
            {
                var vehiculos = await _apiClient.Vehiculos.GetAllAsync();
                dgvVehiculo.DataSource = vehiculos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehiculo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un vehículo para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var vehiculoSeleccionado = dgvVehiculo.SelectedRows[0].DataBoundItem as VehiculoDto;

                if (vehiculoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el vehículo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var vehiculosExistentes = await _apiClient.Vehiculos.GetAllAsync();

                var placaEnUso = vehiculosExistentes.Any(v => v.Placa == txtPlaca.Text && v.VehiculoID != vehiculoSeleccionado.VehiculoID);

                if (placaEnUso)
                {
                    MessageBox.Show("La placa ya está en uso por otro vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                vehiculoSeleccionado.ProveedorID = (int)cbProveedorID.SelectedValue;
                vehiculoSeleccionado.Marca = txtMarca.Text;
                vehiculoSeleccionado.Modelo = txtModelo.Text;
                vehiculoSeleccionado.Año = int.Parse(txtAño.Text);
                vehiculoSeleccionado.Placa = txtPlaca.Text;
                vehiculoSeleccionado.TipoDeVehiculo = txtTipoDeVehiculo.Text;
                vehiculoSeleccionado.TipoDeCombustible = txtTipoDeCombustible.Text;
                vehiculoSeleccionado.Estado = cbEstado.SelectedItem.ToString();
                vehiculoSeleccionado.FechaRegistro = dtpFechaRegistro.Value;

                await _apiClient.Vehiculos.UpdateAsync(vehiculoSeleccionado.VehiculoID, vehiculoSeleccionado);
                MessageBox.Show("Vehículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehiculo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var vehiculoSeleccionado = dgvVehiculo.SelectedRows[0].DataBoundItem as VehiculoDto;

                if (vehiculoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el vehículo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este vehículo?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.Vehiculos.DeleteAsync(vehiculoSeleccionado.VehiculoID);
                    MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshData();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtAño.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtTipoDeVehiculo.Text = string.Empty;
            txtTipoDeCombustible.Text = string.Empty;
            cbEstado.SelectedIndex = -1;
            cbProveedorID.SelectedIndex = -1;
        }
        private async void bntAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si ya existe un vehículo con la misma placa
                var vehiculosExistentes = await _apiClient.Vehiculos.GetAllAsync();
                if (vehiculosExistentes.Any(v => v.Placa == txtPlaca.Text))
                {
                    MessageBox.Show("Ya existe un vehículo con la misma placa. Por favor, ingrese una placa diferente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el nuevo vehículo
                var nuevoVehiculo = new VehiculoDto
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Año = int.Parse(txtAño.Text),
                    Placa = txtPlaca.Text,
                    TipoDeVehiculo = txtTipoDeVehiculo.Text,
                    TipoDeCombustible = txtTipoDeCombustible.Text,
                    Estado = cbEstado.SelectedItem.ToString(),
                    ProveedorID = (int)cbProveedorID.SelectedValue,
                    FechaRegistro = DateTime.Now
                };

                // Crear el vehículo en la base de datos
                await _apiClient.Vehiculos.CreateAsync(nuevoVehiculo);

                // Mostrar mensaje de éxito
                MessageBox.Show("Vehículo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar los datos y limpiar los campos
                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra
                MessageBox.Show($"Ocurrió un error al agregar el vehículo: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var vehiculoSeleccionado = dgvVehiculo.Rows[e.RowIndex].DataBoundItem as VehiculoDto;

                    if (vehiculoSeleccionado != null)
                    {
                        cbProveedorID.SelectedValue = vehiculoSeleccionado.ProveedorID;
                        txtMarca.Text = vehiculoSeleccionado.Marca;
                        txtModelo.Text = vehiculoSeleccionado.Modelo;
                        txtAño.Text = vehiculoSeleccionado.Año.ToString();
                        txtPlaca.Text = vehiculoSeleccionado.Placa;
                        txtTipoDeVehiculo.Text = vehiculoSeleccionado.TipoDeVehiculo;
                        txtTipoDeCombustible.Text = vehiculoSeleccionado.TipoDeCombustible;
                        cbEstado.SelectedItem = vehiculoSeleccionado.Estado;
                        dtpFechaRegistro.Value = vehiculoSeleccionado.FechaRegistro;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (e.RowIndex >= 0)
                {
                    var vehiculoSeleccionado = dgvVehiculo.Rows[e.RowIndex].DataBoundItem as VehiculoDto;

                    if (vehiculoSeleccionado != null)
                    {
                        cbProveedorID.SelectedValue = vehiculoSeleccionado.ProveedorID;
                        txtMarca.Text = vehiculoSeleccionado.Marca;
                        txtModelo.Text = vehiculoSeleccionado.Modelo;
                        txtAño.Text = vehiculoSeleccionado.Año.ToString();
                        txtPlaca.Text = vehiculoSeleccionado.Placa;
                        txtTipoDeVehiculo.Text = vehiculoSeleccionado.TipoDeVehiculo;
                        txtTipoDeCombustible.Text = vehiculoSeleccionado.TipoDeCombustible;
                        cbEstado.SelectedItem = vehiculoSeleccionado.Estado;
                        dtpFechaRegistro.Value = vehiculoSeleccionado.FechaRegistro;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
