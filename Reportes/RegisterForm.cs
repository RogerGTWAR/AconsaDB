using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Reportes
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            txtConstraseña.UseSystemPasswordChar = true;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtConstraseña.Text;

            ValidarUsuario(usuario, contrasena);
        }
        private void ValidarUsuario(string usuario, string contrasena)
        {
            string permisos = string.Empty;

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ValidarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contrasena);

                        SqlParameter permisosParam = new SqlParameter("@Permisos", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(permisosParam);

                        cmd.ExecuteNonQuery();

                        permisos = permisosParam.Value.ToString();

                    }

                    if (permisos != "Sin Acceso")
                    {
                        MessageBox.Show($"Acceso permitido. Permisos: {permisos}", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuForm menuForm = new MenuForm();
                        menuForm.Show();

                        // Cerramos el formulario de login para que no se quede abierto
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //string permisos = string.Empty;
            //string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        conn.Open();
            //        using (SqlCommand cmd = new SqlCommand("ValidarUsuarios", conn))
            //        {
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@Usuario", usuario);
            //            cmd.Parameters.AddWithValue("@Contraseña", contrasena);

            //            SqlParameter permisosParam = new SqlParameter("@Permisos", SqlDbType.NVarChar, 500)
            //            {
            //                Direction = ParameterDirection.Output
            //            };
            //            cmd.Parameters.Add(permisosParam);

            //            cmd.ExecuteNonQuery();

            //            permisos = permisosParam.Value.ToString();
            //        }

            //        if (!string.IsNullOrEmpty(permisos) && permisos != "Sin Acceso")
            //        {
            //            MessageBox.Show($"Acceso permitido. Permisos: {permisos}", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            MenuForm menuForm = new MenuForm();
            //            menuForm.Show();

            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
