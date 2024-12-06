using FontAwesome.Sharp;
using System.Net.Http;
using System.Runtime.InteropServices;
using WinForms.FormsDeMenu.Detalles;

namespace WinForms
{
    public partial class MenuForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private readonly HttpClient _httpClient;
        private Form currentchilform;
        private readonly string _usuario;
        public MenuForm(ApiClient _apiClient, string username)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            _usuario = username;
            //Form
            //Solo con esto, no saldra la barra de tareas
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            ////Para solucionarlo
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7067/api/")
            };
            CustomizeDesing();
            hidesubMenu();
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(6, 57, 112);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                IconoFormulario.IconChar = currentBtn.IconChar;
                IconoFormulario.IconColor = color;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(34, 193, 195);
            public static Color color8 = Color.FromArgb(253, 187, 45);
            public static Color color9 = Color.FromArgb(252, 74, 85);
            public static Color color10 = Color.FromArgb(43, 203, 186);
            public static Color color11 = Color.FromArgb(120, 87, 246);
            public static Color color12 = Color.FromArgb(255, 159, 67);
            public static Color color13 = Color.FromArgb(75, 192, 192);
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(6, 57, 112);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            IconoFormulario.IconChar = IconChar.Home;
            IconoFormulario.IconColor = Color.MediumPurple;
            TituloFormulario.Text = "Home";
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChilForm(new EmpleadosForm(_httpClient));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChilForm(new ClientesForm(_httpClient));
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            currentchilform.Close();
            Reset();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTituloBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenChilForm(Form chilform)
        {
            if (currentchilform != null)
            {
                currentchilform.Close();
            }
            currentchilform = chilform;
            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(chilform);
            panelContenedor.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
            TituloFormulario.Text = chilform.Text;
        }
        private void CustomizeDesing()
        {
            panelSubContenedor.Visible = false;
        }

        private void hidesubMenu()
        {
            if (panelSubContenedor.Visible == true)
                panelSubContenedor.Visible = false;
        }
        private void showsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetalles_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
        }
        //Revisar luego
        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuario;

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChilForm(new ProyectosForm(_httpClient));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChilForm(new MenuProductosForm(_httpClient));

        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChilForm(new ProyectosForm(_httpClient));
        }

        private void btnAvaluos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChilForm(new AvaluoForm(_httpClient));


        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChilForm(new VehiculoForm(_httpClient));

        }

        private void btnMaquinarias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChilForm(new MaquinariaForm(_httpClient));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            showsubMenu(panelSubContenedor);

        }

        private void btnAvaluosDetalles_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChilForm(new AvaluoDetallesForm(_httpClient));
        }

        private void btnEmpleadosDetalles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChilForm(new EmpleadosDetallesForm(_httpClient));
        }

        private void btnVehiculosDetalles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            OpenChilForm(new VehiculosDetallesForm(_httpClient));
        }

        private void btnMaquinariaDetalle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color11);
            OpenChilForm(new MaquinariaDetallesForm(_httpClient));
        }
    }
}
    
