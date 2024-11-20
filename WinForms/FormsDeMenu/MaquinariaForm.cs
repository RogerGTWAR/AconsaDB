using SharedModels.Dto.Maquinaria;
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
    public partial class MaquinariaForm : Form
    {
        private readonly ApiClient _apiClient;

        public MaquinariaForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void MaquinariaForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            await CargarProveedores();
            CargarEstados();

        }
        private async Task CargarProveedores()
        {
            try
            {
                var proveedores = await _apiClient.Proveedores.GetAllAsync();
                cbProveedorID.DataSource = proveedores.ToList();
                cbProveedorID.DisplayMember = "NombreEmpresa";
                cbProveedorID.ValueMember = "ProveedorID";
                cbProveedorID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarEstados()
        {
            try
            {
                var estados = new List<string>
                {
                  "Operando",
                  "En Mantenimiento",
                  "Dado de Baja",
                  "Contrato Terminado"
                 };

                cbEstado.DataSource = estados;
                cbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RefreshData()
        {
            try
            {
                var maquinarias = await _apiClient.Maquinarias.GetAllAsync();
                dgvMaquinaria.DataSource = maquinarias.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar maquinarias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaquinaria.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una maquinaria para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var maquinariaSeleccionada = dgvMaquinaria.SelectedRows[0].DataBoundItem as MaquinariaDto;

                if (maquinariaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la maquinaria seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maquinariaSeleccionada.NombreMaquinaria = txtNombreMaquinaria.Text;
                maquinariaSeleccionada.ProveedorID = (int)cbProveedorID.SelectedValue;
                maquinariaSeleccionada.Marca = txtMarca.Text;
                maquinariaSeleccionada.Modelo = txtModelo.Text;
                maquinariaSeleccionada.FechaInicioRenta = dtpFechaInicioRenta.Value.Date;
                maquinariaSeleccionada.FechaFinalizacionRenta = dtpFechaFinalizacionRenta.Value.Date;
                maquinariaSeleccionada.PrecioPorHora = decimal.Parse(txtPrecioPorHora.Text);
                maquinariaSeleccionada.Estado = cbEstado.SelectedItem.ToString();

                await _apiClient.Maquinarias.UpdateAsync(maquinariaSeleccionada.MaquinariaID, maquinariaSeleccionada);
                MessageBox.Show("Maquinaria modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaMaquinaria = new MaquinariaDto
                {
                    NombreMaquinaria = txtNombreMaquinaria.Text,
                    ProveedorID = (int)cbProveedorID.SelectedValue,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    FechaInicioRenta = dtpFechaInicioRenta.Value.Date,
                    FechaFinalizacionRenta = dtpFechaFinalizacionRenta.Value.Date,
                    PrecioPorHora = decimal.Parse(txtPrecioPorHora.Text),
                    Estado = cbEstado.SelectedItem.ToString()
                };

                await _apiClient.Maquinarias.CreateAsync(nuevaMaquinaria);
                MessageBox.Show("Maquinaria agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaquinaria.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una maquinaria para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var maquinariaSeleccionada = dgvMaquinaria.SelectedRows[0].DataBoundItem as MaquinariaDto;

                if (maquinariaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la maquinaria seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta maquinaria?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.Maquinarias.DeleteAsync(maquinariaSeleccionada.MaquinariaID);
                    MessageBox.Show("Maquinaria eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshData();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreMaquinaria.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtPrecioPorHora.Text = string.Empty;
            cbEstado.SelectedIndex = -1;
            cbProveedorID.SelectedIndex = -1;
            dtpFechaInicioRenta.Value = DateTime.Now;
            dtpFechaFinalizacionRenta.Value = DateTime.Now;
        }
        private void dgvMaquinaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var maquinariaSeleccionada = dgvMaquinaria.Rows[e.RowIndex].DataBoundItem as MaquinariaDto;

                    if (maquinariaSeleccionada != null)
                    {
                        txtNombreMaquinaria.Text = maquinariaSeleccionada.NombreMaquinaria;
                        txtMarca.Text = maquinariaSeleccionada.Marca;
                        txtModelo.Text = maquinariaSeleccionada.Modelo;
                        txtPrecioPorHora.Text = maquinariaSeleccionada.PrecioPorHora.ToString();
                        cbEstado.SelectedItem = maquinariaSeleccionada.Estado;
                        cbProveedorID.SelectedValue = maquinariaSeleccionada.ProveedorID;
                        dtpFechaInicioRenta.Value = maquinariaSeleccionada.FechaInicioRenta;
                        dtpFechaFinalizacionRenta.Value = maquinariaSeleccionada.FechaFinalizacionRenta;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar maquinaria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

