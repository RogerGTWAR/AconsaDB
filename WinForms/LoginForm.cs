using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
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
            //Para ocultar la contraseña
            txtPassword.UseSystemPasswordChar = true;
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
                    _apiClient.SetAuthToken(token);

                    this.Hide();
                    BienvenidadForm frm = new BienvenidadForm(username);
                    frm.ShowDialog();
                    //Hide();

                    MenuForm menuForm = new MenuForm(_apiClient, username);
                    menuForm.Show();
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
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}