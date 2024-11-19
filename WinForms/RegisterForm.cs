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
using WinForms.IRepository.Repository;

namespace WinForms
{
    public partial class RegisterForm : Form
    {
        private readonly ApiClient _apiClient;
        private readonly Repository<Empleado> _empleadorepository;
        public RegisterForm(ApiClient apiClient, HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _httpClient = new HttpClient();
            _empleadorepository = new Repository<Empleado>(_httpClient, "Empleados");
        }
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            await Register();
        }

        private async Task Register()
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) &&
                             !string.IsNullOrWhiteSpace(txtContraseña.Text) &&
                             !string.IsNullOrWhiteSpace(txtEmpleadoID.Text) &&
                             DateTime.TryParse(dtpCreacion.Text, out var fechaCreacion) &&
                             DateTime.TryParse(dtpFechaModificacion.Text, out var fechaModificacion))
            {
                try
                {
                    if (int.TryParse(txtEmpleadoID.Text, out var empleadoId))
                    {
                        string userName = txtUsuario.Text;
                        string contraseña = txtContraseña.Text;
                        var user = await _apiClient.RegisterUsuarios.Register(userName, empleadoId, contraseña, fechaCreacion, fechaModificacion);

                        if (!string.IsNullOrEmpty(user))
                        {
                            MessageBox.Show("¡Registro exitoso!");
                            _apiClient.SetAuthToken(user);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El registro falló. Por favor, verifica los datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empleado ID debe ser un número entero válido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Error: Por favor, rellena todos los campos.");
            }
        }

    }
        
    

}