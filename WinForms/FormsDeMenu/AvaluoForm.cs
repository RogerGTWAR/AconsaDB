using SharedModels;
using SharedModels.Dto.Avaluo;
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
    public partial class AvaluoForm : Form
    {
        private readonly ApiClient _apiClient;
        public AvaluoForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void AvaluoForm_Load(object sender, EventArgs e)
        {
            await CargarProyectos();
            await RefreshData();
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
                MessageBox.Show($"Error al cargar los proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var avaluo = await _apiClient.Avaluos.GetAllAsync();
                dgvAvaluo.DataSource = avaluo.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposAvaluo())
            {
                MessageBox.Show("Por favor, corrija los campos resaltados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoAvaluo = new AvaluoDto
            {
                ProyectoID = (int)cbProyectoID.SelectedValue,
                Descripcion = txtDescripcion.Text,
                MontoEjecutado = decimal.Parse(txtMontoEjecutado.Text),
                FechaInicio = dtpFechaInicio.Value,
                FechaFin = dtpFechaFin.Value
            };

            try
            {
                var success = await _apiClient.Avaluos.CreateAsync(nuevoAvaluo);

                if (success != null)
                {
                    MessageBox.Show("¡Avalúo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await RefreshData();
                }
                else
                {
                    MessageBox.Show("Error al agregar el avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cbProyectoID.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtMontoEjecutado.Clear();
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
        }
        private bool ValidarCamposAvaluo()
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

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.LightYellow;
                esValido = false;
            }
            else
            {
                txtDescripcion.BackColor = Color.White;
            }

            if (!decimal.TryParse(txtMontoEjecutado.Text, out var monto) || monto < 0)
            {
                txtMontoEjecutado.BackColor = Color.LightCoral;
                esValido = false;
            }
            else
            {
                txtMontoEjecutado.BackColor = Color.White;
            }

            if (dtpFechaInicio.Value >= dtpFechaFin.Value)
            {
                dtpFechaInicio.CalendarForeColor = Color.Red;
                dtpFechaFin.CalendarForeColor = Color.Red;
                esValido = false;
            }
            else
            {
                dtpFechaInicio.CalendarForeColor = Color.Black;
                dtpFechaFin.CalendarForeColor = Color.Black;
            }

            return esValido;
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAvaluo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un avalúo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var filaSeleccionada = dgvAvaluo.SelectedRows[0];
            int avaluoID = Convert.ToInt32(filaSeleccionada.Cells["AvaluoID"].Value);
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el avalúo con ID {avaluoID}?",
                                                "Confirmación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var success = await _apiClient.Avaluos.DeleteAsync(avaluoID);

                    if (success)
                    {
                        MessageBox.Show("Avalúo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshData();
                        LimpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAvaluo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un avalúo para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var filaSeleccionada = dgvAvaluo.SelectedRows[0];
            int avaluoID = Convert.ToInt32(filaSeleccionada.Cells["AvaluoID"].Value);
            if (cbProyectoID.SelectedItem == null || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtMontoEjecutado.Text) || dtpFechaInicio.Value >= dtpFechaFin.Value)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var avalúoModificado = new Avaluo
                {
                    AvaluoID = avaluoID,
                    ProyectoID = Convert.ToInt32(cbProyectoID.SelectedValue),
                    Descripcion = txtDescripcion.Text,
                    MontoEjecutado = decimal.Parse(txtMontoEjecutado.Text),
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value
                };
                var success = await _apiClient.Avaluos.UpdateAsync(avaluoID, avalúoModificado);

                if (success)
                {
                    MessageBox.Show("Avalúo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshData();
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Error al modificar el avalúo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAvaluo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var avalúo = (AvaluoDto)dgvAvaluo.Rows[e.RowIndex].DataBoundItem;
                    cbProyectoID.SelectedValue = avalúo.ProyectoID;
                    txtDescripcion.Text = avalúo.Descripcion;
                    txtMontoEjecutado.Text = avalúo.MontoEjecutado.ToString();
                    dtpFechaInicio.Value = avalúo.FechaInicio;
                    dtpFechaFin.Value = avalúo.FechaFin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar avalúo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
