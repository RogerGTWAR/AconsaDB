using SharedModels;
using SharedModels.Dto.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinForms
{
    public partial class EmpleadosForm : Form
    {
        private readonly ApiClient _apiClient;

        public EmpleadosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async Task CargarRoles()
        {
            try
            {
                var roles = await _apiClient.Roles.GetAllAsync();
                cbRolID.DataSource = roles.ToList();
                cbRolID.DisplayMember = "RolID";
                cbRolID.ValueMember = "RolID";
                cbRolID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                var empleados = await _apiClient.Empleados.GetAllAsync();
                dgvEmpleados.DataSource = empleados.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            await CargarRoles();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var empleadoSeleccionado = dgvEmpleados.Rows[e.RowIndex].DataBoundItem as EmpleadoDto;

                    if (empleadoSeleccionado != null)
                    {
                        txtNombres.Text = empleadoSeleccionado.Nombres;
                        txtApellidos.Text = empleadoSeleccionado.Apellidos;
                        txtCedula.Text = empleadoSeleccionado.Cedula;
                        cbRolID.SelectedValue = empleadoSeleccionado.RolID;
                        dtpFechaNacimiento.Value = empleadoSeleccionado.FechaNacimiento;
                        dtpFechaContratacion.Value = empleadoSeleccionado.FechaContratacion;
                        txtDireccion.Text = empleadoSeleccionado.Direccion;
                        txtPais.Text = empleadoSeleccionado.País;
                        txtTelefono.Text = empleadoSeleccionado.Telefono;
                        txtCorreo.Text = empleadoSeleccionado.Correo;
                        txtReportes.Text = empleadoSeleccionado.Reportes?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as EmpleadoDto;

                if (empleadoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var empleadosExistentes = await _apiClient.Empleados.GetAllAsync();
                var cedulaEnUso = empleadosExistentes.Any(e => e.Cedula == txtCedula.Text && e.EmpleadoID != empleadoSeleccionado.EmpleadoID);

                if (cedulaEnUso)
                {
                    MessageBox.Show("La cédula ya está en uso por otro empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empleadoSeleccionado.Nombres = txtNombres.Text;
                empleadoSeleccionado.Apellidos = txtApellidos.Text;
                empleadoSeleccionado.Cedula = txtCedula.Text;
                empleadoSeleccionado.RolID = (int)cbRolID.SelectedValue;
                empleadoSeleccionado.FechaNacimiento = dtpFechaNacimiento.Value;
                empleadoSeleccionado.FechaContratacion = dtpFechaContratacion.Value;
                empleadoSeleccionado.Direccion = txtDireccion.Text;
                empleadoSeleccionado.País = txtPais.Text;
                empleadoSeleccionado.Telefono = txtTelefono.Text;
                empleadoSeleccionado.Correo = txtCorreo.Text;
                empleadoSeleccionado.Reportes = string.IsNullOrEmpty(txtReportes.Text) ? null : int.Parse(txtReportes.Text);

                await _apiClient.Empleados.UpdateAsync(empleadoSeleccionado.EmpleadoID, empleadoSeleccionado);
                MessageBox.Show("Empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var empleadoSeleccionado = dgvEmpleados.SelectedRows[0].DataBoundItem as EmpleadoDto;

                if (empleadoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.Empleados.DeleteAsync(empleadoSeleccionado.EmpleadoID);
                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshData();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadosExistentes = await _apiClient.Empleados.GetAllAsync();
                if (empleadosExistentes.Any(e => e.Cedula == txtCedula.Text))
                {
                    MessageBox.Show("Ya existe un empleado con la misma cédula. Por favor, ingrese una cédula diferente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevoEmpleado = new EmpleadoDto
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Cedula = txtCedula.Text,
                    RolID = (int)cbRolID.SelectedValue,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    FechaContratacion = dtpFechaContratacion.Value,
                    Direccion = txtDireccion.Text,
                    País = txtPais.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Reportes = string.IsNullOrEmpty(txtReportes.Text) ? null : int.Parse(txtReportes.Text)
                };

                await _apiClient.Empleados.CreateAsync(nuevoEmpleado);

                MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await RefreshData();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtReportes.Text = string.Empty;
            cbRolID.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaContratacion.Value = DateTime.Now;
        }
    }
}
