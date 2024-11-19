using SharedModels.Dto.Categoria;
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
    public partial class CategoriasForm : Form
    {
        private readonly ApiClient _apiClient;

        public CategoriasForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void CategoriasForm_Load(object sender, EventArgs e)
        {
            await RefreshData();

        }
        private async Task RefreshData()
        {
            try
            {
                var cliente = await _apiClient.Categorias.GetAllAsync();
                dgvCategoria.DataSource = cliente.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaCategoria = new CategoriaDto
                {
                    NombreCategoria = txtCategoria.Text,
                    Descripcion = txtDescripcion.Text
                };

                await _apiClient.Categorias.CreateAsync(nuevaCategoria);
                MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una categoría para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filaSeleccionada = dgvCategoria.SelectedRows[0].DataBoundItem as CategoriaDto;

                if (filaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la categoría seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var categoriaActualizada = new CategoriaDto
                {
                    CategoriaID = filaSeleccionada.CategoriaID,
                    NombreCategoria = txtCategoria.Text,
                    Descripcion = txtDescripcion.Text
                };

                await _apiClient.Categorias.UpdateAsync(categoriaActualizada.CategoriaID, categoriaActualizada);
                MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filaSeleccionada = dgvCategoria.SelectedRows[0].DataBoundItem as CategoriaDto;

                if (filaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la categoría seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.Categorias.DeleteAsync(filaSeleccionada.CategoriaID);
                    MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshData();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var categoria = (CategoriaDto)dgvCategoria.Rows[e.RowIndex].DataBoundItem;

                    txtCategoria.Text = categoria.NombreCategoria;
                    txtDescripcion.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtCategoria.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
    }
}
