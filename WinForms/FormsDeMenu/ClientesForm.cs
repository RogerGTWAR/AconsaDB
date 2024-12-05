using SharedModels;
using SharedModels.Dto.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ClientesForm : Form
    {
        private readonly ApiClient _apiClient;

        public ClientesForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }

        private async void ClientesForm_Load(object sender, EventArgs e)
        {
            await RefreshData();

        }

        private async Task RefreshData()
        {
            try
            {
                var cliente = await _apiClient.Clientes.GetAllAsync();
                dgvClientes.DataSource = cliente.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposCliente())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clientesExistentes = await _apiClient.Clientes.GetAllAsync();
            if (clientesExistentes.Any(c => c.ClienteID == txtClienteID.Text))
                {
                    MessageBox.Show("El ClienteID ya existe. Por favor, utilice uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var nuevoCliente = new Cliente
                {
                ClienteID = txtClienteID.Text,
                NombreEmpresa = txtNombreEmpresa.Text,
                NombreContacto = txtNombreContacto.Text,
                CargoContacto = txtCargoContacto.Text,
                    Dirección = txtDireccion.Text,
                Ciudad = txtCiudad.Text,
                    País = txtPais.Text,
                Teléfono = txtTelefono.Text
                 };
            try
            {
                    var success = await _apiClient.Clientes.CreateAsync(nuevoCliente);

                if (success != null)
                {
                    MessageBox.Show("¡Cliente agregado exitosamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCamposCliente();
                    await RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposCliente()
        {
            bool esValido = true;
            if (string.IsNullOrWhiteSpace(txtClienteID.Text) || txtClienteID.Text.Length != 5)
            {
                txtClienteID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtClienteID.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
            {
                txtNombreEmpresa.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtNombreEmpresa.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtNombreContacto.Text))
            {
                txtNombreContacto.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtNombreContacto.BackColor = Color.White;
            }
            if (!string.IsNullOrWhiteSpace(txtCargoContacto.Text) && txtCargoContacto.Text.Length > 50)
            {
                txtCargoContacto.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtCargoContacto.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtDireccion.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                txtCiudad.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtCiudad.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                txtPais.BackColor = Color.LightCoral;
            }
            else
            {
                txtPais.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || !IsTelefonoValido(txtTelefono.Text))
            {
                txtTelefono.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtTelefono.BackColor = Color.White;
            }

            return esValido;
        }
        private bool IsTelefonoValido(string telefono)
        {
            string patron = @"^(\(\+505\)\s?)?(\d{4}[-\s]?\d{4})$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(telefono);
        }
        private void LimpiarCamposCliente()
        {
            txtClienteID.Clear();
            txtNombreEmpresa.Clear();
            txtNombreContacto.Clear();
            txtCargoContacto.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
        }
        //Revisar
        private async void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var clienteSeleccionado = dgvClientes.SelectedRows[0].DataBoundItem as ClienteDto;

                if (clienteSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clienteSeleccionado.ClienteID = txtClienteID.Text;
                clienteSeleccionado.NombreEmpresa = txtNombreEmpresa.Text;
                clienteSeleccionado.NombreContacto = txtNombreContacto.Text;
                clienteSeleccionado.CargoContacto = txtCargoContacto.Text;
                clienteSeleccionado.Dirección = txtDireccion.Text;
                clienteSeleccionado.Ciudad = txtCiudad.Text;
                clienteSeleccionado.País = txtPais.Text;
                clienteSeleccionado.Teléfono = txtTelefono.Text;

                await _apiClient.Clientes.UpdateClienteAsync(clienteSeleccionado.ClienteID, clienteSeleccionado);

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClienteID.Text))
                {
                    MessageBox.Show("Por favor, ingrese un ClienteID para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clienteID = txtClienteID.Text;

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    var success = await _apiClient.Clientes.DeleteClienteAsync(clienteID);

                    if (success)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposCliente();
                        await RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var cliente = (ClienteDto)dgvClientes.Rows[e.RowIndex].DataBoundItem;
                    txtClienteID.Text = cliente.ClienteID;
                    txtNombreEmpresa.Text = cliente.NombreEmpresa;
                    txtNombreContacto.Text = cliente.NombreContacto;
                    txtCargoContacto.Text = cliente.CargoContacto;
                    txtDireccion.Text = cliente.Dirección;
                    txtCiudad.Text = cliente.Ciudad;
                    txtPais.Text = cliente.País;
                    txtTelefono.Text = cliente.Teléfono;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
