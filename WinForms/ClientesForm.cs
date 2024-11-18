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
    }
}
