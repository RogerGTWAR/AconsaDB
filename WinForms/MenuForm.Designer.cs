namespace WinForms
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnEmpleados = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTituloBarra = new Panel();
            TituloFormulario = new Label();
            IconoFormulario = new FontAwesome.Sharp.IconPictureBox();
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTituloBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormulario).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 549);
            panelMenu.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.White;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 200);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(0, 10, 20, 0);
            btnClientes.Size = new Size(220, 60);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnEmpleados.IconColor = Color.White;
            btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 140);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(0, 10, 20, 0);
            btnEmpleados.Size = new Size(220, 60);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.Aconsa;
            btnHome.Location = new Point(57, 36);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(91, 83);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // panelTituloBarra
            // 
            panelTituloBarra.BackColor = Color.FromArgb(26, 25, 62);
            panelTituloBarra.Controls.Add(TituloFormulario);
            panelTituloBarra.Controls.Add(IconoFormulario);
            panelTituloBarra.Dock = DockStyle.Top;
            panelTituloBarra.Location = new Point(220, 0);
            panelTituloBarra.Name = "panelTituloBarra";
            panelTituloBarra.Size = new Size(783, 75);
            panelTituloBarra.TabIndex = 2;
            panelTituloBarra.MouseDown += panelTituloBarra_MouseDown;
            // 
            // TituloFormulario
            // 
            TituloFormulario.AutoSize = true;
            TituloFormulario.ForeColor = Color.White;
            TituloFormulario.Location = new Point(39, 36);
            TituloFormulario.Name = "TituloFormulario";
            TituloFormulario.Size = new Size(50, 20);
            TituloFormulario.TabIndex = 1;
            TituloFormulario.Text = "Home";
            // 
            // IconoFormulario
            // 
            IconoFormulario.BackColor = Color.FromArgb(26, 25, 62);
            IconoFormulario.ForeColor = Color.MediumPurple;
            IconoFormulario.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoFormulario.IconColor = Color.MediumPurple;
            IconoFormulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoFormulario.IconSize = 27;
            IconoFormulario.Location = new Point(6, 36);
            IconoFormulario.Name = "IconoFormulario";
            IconoFormulario.Size = new Size(27, 30);
            IconoFormulario.TabIndex = 0;
            IconoFormulario.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(34, 33, 74);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 75);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(783, 474);
            panelContenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Aconsa;
            pictureBox1.Location = new Point(330, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 549);
            Controls.Add(panelContenedor);
            Controls.Add(panelTituloBarra);
            Controls.Add(panelMenu);
            Name = "MenuForm";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTituloBarra.ResumeLayout(false);
            panelTituloBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormulario).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnClientes;
        private PictureBox btnHome;
        private Panel panelTituloBarra;
        private FontAwesome.Sharp.IconPictureBox IconoFormulario;
        private Label TituloFormulario;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
    }
}
