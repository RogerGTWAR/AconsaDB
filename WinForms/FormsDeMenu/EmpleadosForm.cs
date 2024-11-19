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
        private int registrosPorPagina = 10;
        private int totalPaginas;
        private List<EmpleadoDto> empleados;

        public EmpleadosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void CargarPaginas()
        {
        }

        private async Task RefreshData()
        {
            try
            {
                //    var empleados = await _apiClient.Empleados.GetAllAsync();
                //dgvEmpleados.DataSource = empleados.ToList();
                empleados = (await _apiClient.Empleados.GetAllAsync()).ToList();

                totalPaginas = (int)Math.Ceiling((double)empleados.Count / registrosPorPagina);

                // Configura el ComboBox con las páginas
                CargarComboBoxPaginas();

                // Carga la primera página
                CargarPagina(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagina(int pagina)
        {
            if (empleados == null || empleados.Count == 0)
                return;

            // Obtiene los empleados correspondientes a la página seleccionada
            var empleadosPagina = empleados
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToList();

            // Asigna los datos al DataGridView
            dgvEmpleados.DataSource = empleadosPagina;
        }

        private void cmbPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagina = cbPagina.SelectedIndex + 1;
            CargarPagina(pagina);
        }

        private void CargarComboBoxPaginas()
        {
            // Limpia el ComboBox
            cbPagina.Items.Clear();

            // Añade las páginas al ComboBox
            for (int i = 1; i <= totalPaginas; i++)
            {
                cbPagina.Items.Add($"Página {i}");
            }

            // Selecciona la primera página por defecto
            if (cbPagina.Items.Count > 0)
                cbPagina.SelectedIndex = 0;
        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await RefreshData();

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var empleado = (EmpleadoDto)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
                txtNombres.Text = empleado.Nombres;
                txtApellidos.Text = empleado.Apellidos;
                txtCedula.Text = empleado.Cedula;
                txtCargo.Text = empleado.Cargo;
                dtpFechaNacimiento.Value = empleado.FechaNacimiento;
                dtpFechaContratacion.Value = empleado.FechaContratacion;
                txtDireccion.Text = empleado.Direccion;
                txtPais.Text = empleado.Pais;
                txtTelefono.Text = empleado.Telefono;
                txtCorreo.Text = empleado.Correo;
            }
        }

        private void cbPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            int paginaSeleccionada = cbPagina.SelectedIndex + 1;

            // Llama al método con el argumento correcto
            CargarPagina(paginaSeleccionada);
        }
    }
}
