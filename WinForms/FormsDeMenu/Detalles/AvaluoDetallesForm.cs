using SharedModels.Dto.AvaluoDetalle;
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
    public partial class AvaluoDetallesForm : Form
    {
        private readonly ApiClient _apiClient;
        public AvaluoDetallesForm(HttpClient httpClient)
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

            var nuevoDetalle = new AvaluoDetallesDto
            {
                AvaluoID = (int)cbAvaluoID.SelectedValue,
                ProductoID = (int)cbProductoID.SelectedValue,
                Descripcion = txtDescripcion.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
            };

            try
            {
                var success = await _apiClient.AvaluosDetalles.CreateAsync(nuevoDetalle);

                if (success != null)
                {
                    MessageBox.Show("¡Detalle de avalúo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await RefreshData();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle del avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el detalle del avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAvaluoDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de avalúo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvAvaluoDetalle.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["avaluoDetalleIDDataGridViewTextBoxColumn"].Value);

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el detalle con ID {detalleID}?",
                                                "Confirmación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var success = await _apiClient.AvaluosDetalles.DeleteAsync(detalleID);

                    if (success)
                    {
                        MessageBox.Show("Detalle de avalúo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el detalle del avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el detalle del avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAvaluoDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de avalúo para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvAvaluoDetalle.SelectedRows[0];
            int detalleID = Convert.ToInt32(filaSeleccionada.Cells["avaluoDetalleIDDataGridViewTextBoxColumn"].Value);

            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detalleModificado = new AvaluoDetallesDto
            {
                Avaluo_DetalleID = detalleID,
                AvaluoID = (int)cbAvaluoID.SelectedValue,
                ProductoID = (int)cbProductoID.SelectedValue,
                Descripcion = txtDescripcion.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
            };

            try
            {
                var success = await _apiClient.AvaluosDetalles.UpdateAsync(detalleID, detalleModificado);

                if (success)
                {
                    MessageBox.Show("Detalle de avalúo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshData();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el detalle del avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el detalle del avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvAvaluoDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var detalle = (AvaluoDetallesDto)dgvAvaluoDetalle.Rows[e.RowIndex].DataBoundItem;
                    cbAvaluoID.SelectedValue = detalle.AvaluoID;
                    cbProductoID.SelectedValue = detalle.ProductoID;
                    txtDescripcion.Text = detalle.Descripcion;
                    txtCantidad.Text = detalle.Cantidad.ToString();
                    txtPrecioUnitario.Text = detalle.PrecioUnitario.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar detalle del avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cbAvaluoID.SelectedIndex = -1;
            cbProductoID.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            if (cbAvaluoID.SelectedIndex == -1)
            {
                cbAvaluoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbAvaluoID.BackColor = Color.White;
            }

            if (cbProductoID.SelectedIndex == -1)
            {
                cbProductoID.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                cbProductoID.BackColor = Color.White;
            }

            if (!int.TryParse(txtCantidad.Text, out var cantidad) || cantidad <= 0)
            {
                txtCantidad.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtCantidad.BackColor = Color.White;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out var precio) || precio <= 0)
            {
                txtPrecioUnitario.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtPrecioUnitario.BackColor = Color.White;
            }

            return esValido;
        }

        private async void AvaluoDetalles_Load(object sender, EventArgs e)
        {
            await CargarAvaluos();
            await CargarProductos();
            await RefreshData();
        }
        private async Task CargarAvaluos()
        {
            try
            {
                var avaluos = await _apiClient.Avaluos.GetAllAsync();
                cbAvaluoID.DataSource = avaluos.ToList();
                cbAvaluoID.DisplayMember = "AvaluoID"; // Puedes ajustar según el modelo.
                cbAvaluoID.ValueMember = "AvaluoID";
                cbAvaluoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar avalúos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarProductos()
        {
            try
            {
                var productos = await _apiClient.Productos.GetAllAsync();
                cbProductoID.DataSource = productos.ToList();
                cbProductoID.DisplayMember = "Nombre"; // Ajustar según el modelo de producto.
                cbProductoID.ValueMember = "ProductoID";
                cbProductoID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var detalles = await _apiClient.AvaluosDetalles.GetAllAsync();
                dgvAvaluoDetalle.DataSource = detalles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
