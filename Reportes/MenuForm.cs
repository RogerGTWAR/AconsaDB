using FontAwesome.Sharp;
using Reportes.Formularios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Reportes
{
    public partial class MenuForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentchilform;
        private readonly string _usuario;
        public MenuForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //CustomizeDesing();
            //hidesubMenu();
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(102, 179, 102);
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
                currentBtn.BackColor = Color.FromArgb(102, 179, 102);
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

        private void btnEmpleadosProyecto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChilForm(new EmpleadosProyectosForm());
        }

        private void pcIcono_Click(object sender, EventArgs e)
        {
            currentchilform.Close();
            Reset();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChilForm(new EmpleadosVehiculosForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChilForm(new ProductoForm());
        }
        //Avaluos
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChilForm(new AvaluosForm());
        }

        private void btnProyectosVerdaderos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChilForm(new ProyectosForm());
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChilForm(new MaquinariaForm());
        }

        private void btnAvaluoDetalles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChilForm(new AvaluoDetalleForm());
        }

        private void btnEmpleadosReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChilForm(new EmpleadosForm());
        }

        //private void CustomizeDesing()
        //{
        //    panelSubContenedor.Visible = false;
        //}

        //private void hidesubMenu()
        //{
        //    if (panelSubContenedor.Visible == true)
        //        panelSubContenedor.Visible = false;
        //}
    }
}
