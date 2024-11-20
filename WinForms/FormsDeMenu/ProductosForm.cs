using SharedModels.Dto.Producto;
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
    public partial class ProductosForm : Form
    {
        private readonly ApiClient _apiClient;
        public ProductosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProducto = new ProductoDto
                {
                    NombreProducto = txtNombreProducto.Text,
                    ProveedorID = (int)cbProveedorID.SelectedValue,
                    CategoriaID = (int)cbCategoriaID.SelectedValue,
                    Descripcion = txtDescripcion.Text,
                    UnidadDeMedida = txtUnidadDeMedida.Text,
                    CantidadEnStock = int.Parse(txtCantidadEnStock.Text),
                    PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
                };

                await _apiClient.Productos.CreateAsync(nuevoProducto);
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as ProductoDto;

                if (productoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                productoSeleccionado.NombreProducto = txtNombreProducto.Text;
                productoSeleccionado.ProveedorID = (int)cbProveedorID.SelectedValue;
                productoSeleccionado.CategoriaID = (int)cbCategoriaID.SelectedValue;
                productoSeleccionado.Descripcion = txtDescripcion.Text;
                productoSeleccionado.UnidadDeMedida = txtUnidadDeMedida.Text;
                productoSeleccionado.CantidadEnStock = int.Parse(txtCantidadEnStock.Text);
                productoSeleccionado.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text);

                await _apiClient.Productos.UpdateAsync(productoSeleccionado.ProductoID, productoSeleccionado);
                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as ProductoDto;

                if (productoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.Productos.DeleteAsync(productoSeleccionado.ProductoID);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshData();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProductosForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            await CargarProyectos();
        }
        private async Task CargarProyectos()
        {
            try
            {
                var producto = await _apiClient.Proveedores.GetAllAsync();
                cbProveedorID.DataSource = producto.ToList();
                cbProveedorID.DisplayMember = "NombreEmpresa";
                cbProveedorID.ValueMember = "ProveedorID";
                cbProveedorID.SelectedIndex = -1;
                var categoria = await _apiClient.Categorias.GetAllAsync();
                cbCategoriaID.DataSource = categoria.ToList();
                cbCategoriaID.DisplayMember = "NombreCategoria";
                cbCategoriaID.ValueMember = "CategoriaID";
                cbCategoriaID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RefreshData()
        {
            try
            {
                var productos = await _apiClient.Productos.GetAllAsync();
                dgvProductos.DataSource = productos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtUnidadDeMedida.Text = string.Empty;
            txtCantidadEnStock.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            cbCategoriaID.SelectedIndex = -1;
            cbProveedorID.SelectedIndex = -1;
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var productoSeleccionado = dgvProductos.Rows[e.RowIndex].DataBoundItem as ProductoDto;

                    if (productoSeleccionado != null)
                    {
                        txtNombreProducto.Text = productoSeleccionado.NombreProducto;
                        cbProveedorID.SelectedValue = productoSeleccionado.ProveedorID;
                        cbCategoriaID.SelectedValue = productoSeleccionado.CategoriaID;
                        txtDescripcion.Text = productoSeleccionado.Descripcion;
                        txtUnidadDeMedida.Text = productoSeleccionado.UnidadDeMedida;
                        txtCantidadEnStock.Text = productoSeleccionado.CantidadEnStock.ToString();
                        txtPrecioUnitario.Text = productoSeleccionado.PrecioUnitario.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidadDeMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
