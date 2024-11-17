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
using WinForms;

namespace WindowsForm
{
    public partial class LoginForm : Form
    {
        private readonly ApiClient _apiClient;
        private readonly HttpClient _httpClient;
        public LoginForm()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async Task LoginAsync()
        {
            string username = txtxUserName.Text;
            string password = txtPassword.Text;

            try
            {
                var token = await _apiClient.LoginUsers.AuthenticateUserAsync(username, password);

                if (!string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("¡Inicio de sesión exitoso!");
                    _apiClient.SetAuthToken(token);
                    Hide();
                    var mainForm = new MenuForm(_apiClient);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Acceso fallido. Por favor revisar usuario y contraseña.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var mainForm = new RegisterForm(_apiClient, _httpClient);
            mainForm.Show();
        }
    }
}