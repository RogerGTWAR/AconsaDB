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
        private readonly Repository<Empleado> empleadorepository;

        public EmpleadosForm()
        {
        }

        public EmpleadosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            empleadorepository = new Repository<Empleado>(_httpClient, "Empleados");
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var cuentas = empleadorepository.GetAllAsync();
                dgvEmpleados.DataSource = cuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas. Error: " + ex.Message);
            }
        }
    }
}
