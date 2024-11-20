using SharedModels;
using SharedModels.Dto.Proveedor;
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
    public partial class ProveedoresForm : Form
    {
        private readonly ApiClient _apiClient; 
        private int selectedProveedorId = -1;

        public ProveedoresForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }
        private async void ProveedoresForm_Load(object sender, EventArgs e)
        {
            await RefreshData();

        }

        private async Task RefreshData()
        {
            try
            {
                var proveedors = await _apiClient.Proveedores.GetAllAsync();
                dgvProveedores.DataSource = proveedors.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {

            var nuevoProveedor = new Proveedor
            {
                NombreEmpresa = txtNombreEmpresa.Text,
                NombreContacto = txtNombreContacto.Text,
                CargoContacto = txtCargoContacto.Text,
                Direccion = txtDireccion.Text,
                Ciudad = txtCiudad.Text,
                Pais = txtPais.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            var success = await _apiClient.Proveedores.CreateAsync(nuevoProveedor);
            try
            {
                MessageBox.Show("¡Proveedor agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                await RefreshData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();
            txtNombreContacto.Clear();
            txtCargoContacto.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedProveedorId != -1)
            {
                try
                {
                    var proveedorActualizado = new Proveedor
                    {
                        ProveedorID = selectedProveedorId,
                        NombreEmpresa = txtNombreEmpresa.Text,
                        NombreContacto = txtNombreContacto.Text,
                        CargoContacto = txtCargoContacto.Text,
                        Direccion = txtDireccion.Text,
                        Ciudad = txtCiudad.Text,
                        Pais = txtPais.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text
                    };

                    var success = await _apiClient.Proveedores.UpdateAsync(selectedProveedorId, proveedorActualizado);

                    if (success)
                    {
                        MessageBox.Show("¡Proveedor actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        await RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedProveedorId != -1)
            {
                try
                {
                    var success = await _apiClient.Proveedores.DeleteAsync(selectedProveedorId);

                    if (success)
                    {
                        MessageBox.Show("¡Proveedor eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var proveedor = (ProveedorDto)dgvProveedores.Rows[e.RowIndex].DataBoundItem;
                selectedProveedorId = proveedor.ProveedorID;

                txtNombreEmpresa.Text = proveedor.NombreEmpresa;
                txtNombreContacto.Text = proveedor.NombreContacto;
                txtCargoContacto.Text = proveedor.CargoContacto;
                txtDireccion.Text = proveedor.Direccion;
                txtCiudad.Text = proveedor.Ciudad;
                txtPais.Text = proveedor.Pais;
                txtTelefono.Text = proveedor.Telefono;
                txtCorreo.Text = proveedor.Correo;
            }
        }
    }
}
