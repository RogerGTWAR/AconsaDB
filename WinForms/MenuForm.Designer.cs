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
            components = new System.ComponentModel.Container();
            panelTituloBarra = new Panel();
            btnUsuario = new FontAwesome.Sharp.IconButton();
            lblFecha = new Label();
            lblHora = new Label();
            TituloFormulario = new Label();
            IconoFormulario = new FontAwesome.Sharp.IconPictureBox();
            lblUsuario = new Label();
            panelContenedor = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            horafecha = new System.Windows.Forms.Timer(components);
            panelLogo = new Panel();
            btnHome = new PictureBox();
            btnEmpleados = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            btnProyectos = new FontAwesome.Sharp.IconButton();
            btnAvaluos = new FontAwesome.Sharp.IconButton();
            btnVehiculos = new FontAwesome.Sharp.IconButton();
            btnMaquinarias = new FontAwesome.Sharp.IconButton();
            btnDetalles = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            panelSubContenedor = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelTituloBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormulario).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelMenu.SuspendLayout();
            panelSubContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelTituloBarra
            // 
            panelTituloBarra.BackColor = Color.FromArgb(26, 25, 62);
            panelTituloBarra.Controls.Add(btnUsuario);
            panelTituloBarra.Controls.Add(lblFecha);
            panelTituloBarra.Controls.Add(lblHora);
            panelTituloBarra.Controls.Add(TituloFormulario);
            panelTituloBarra.Controls.Add(IconoFormulario);
            panelTituloBarra.Dock = DockStyle.Top;
            panelTituloBarra.Location = new Point(220, 0);
            panelTituloBarra.Name = "panelTituloBarra";
            panelTituloBarra.Size = new Size(1627, 75);
            panelTituloBarra.TabIndex = 2;
            panelTituloBarra.MouseDown += panelTituloBarra_MouseDown;
            // 
            // btnUsuario
            // 
            btnUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuario.IconColor = Color.White;
            btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(1556, 15);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(59, 45);
            btnUsuario.TabIndex = 4;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(383, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(98, 41);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(228, 19);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(87, 41);
            lblHora.TabIndex = 2;
            lblHora.Text = "Hora";
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(188, 21);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(126, 41);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(34, 33, 74);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(lblUsuario);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 75);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1627, 980);
            panelContenedor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Aconsa;
            pictureBox1.Location = new Point(753, 357);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
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
            btnHome.Location = new Point(24, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(157, 137);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 10.2F);
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
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10.2F);
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
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 10.2F);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            btnProveedores.IconColor = Color.White;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 260);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(0, 10, 20, 0);
            btnProveedores.Size = new Size(220, 60);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10.2F);
            btnProductos.ForeColor = Color.White;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProductos.IconColor = Color.White;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 320);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(0, 10, 20, 0);
            btnProductos.Size = new Size(220, 60);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Dock = DockStyle.Top;
            btnProyectos.FlatAppearance.BorderSize = 0;
            btnProyectos.FlatStyle = FlatStyle.Flat;
            btnProyectos.Font = new Font("Segoe UI", 10.2F);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.IconChar = FontAwesome.Sharp.IconChar.PersonDigging;
            btnProyectos.IconColor = Color.White;
            btnProyectos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProyectos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProyectos.Location = new Point(0, 380);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Padding = new Padding(0, 10, 20, 0);
            btnProyectos.Size = new Size(220, 60);
            btnProyectos.TabIndex = 7;
            btnProyectos.Text = "Proyectos";
            btnProyectos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnAvaluos
            // 
            btnAvaluos.Dock = DockStyle.Top;
            btnAvaluos.FlatAppearance.BorderSize = 0;
            btnAvaluos.FlatStyle = FlatStyle.Flat;
            btnAvaluos.Font = new Font("Segoe UI", 10.2F);
            btnAvaluos.ForeColor = Color.White;
            btnAvaluos.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnAvaluos.IconColor = Color.White;
            btnAvaluos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvaluos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvaluos.Location = new Point(0, 440);
            btnAvaluos.Name = "btnAvaluos";
            btnAvaluos.Padding = new Padding(0, 10, 20, 0);
            btnAvaluos.Size = new Size(220, 60);
            btnAvaluos.TabIndex = 8;
            btnAvaluos.Text = "Avaluos";
            btnAvaluos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAvaluos.UseVisualStyleBackColor = true;
            btnAvaluos.Click += btnAvaluos_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 10.2F);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            btnVehiculos.IconColor = Color.White;
            btnVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.Location = new Point(0, 500);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Padding = new Padding(0, 10, 20, 0);
            btnVehiculos.Size = new Size(220, 60);
            btnVehiculos.TabIndex = 9;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnMaquinarias
            // 
            btnMaquinarias.Dock = DockStyle.Top;
            btnMaquinarias.FlatAppearance.BorderSize = 0;
            btnMaquinarias.FlatStyle = FlatStyle.Flat;
            btnMaquinarias.Font = new Font("Segoe UI", 10.2F);
            btnMaquinarias.ForeColor = Color.White;
            btnMaquinarias.IconChar = FontAwesome.Sharp.IconChar.Truck;
            btnMaquinarias.IconColor = Color.White;
            btnMaquinarias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaquinarias.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaquinarias.Location = new Point(0, 560);
            btnMaquinarias.Name = "btnMaquinarias";
            btnMaquinarias.Padding = new Padding(0, 10, 20, 0);
            btnMaquinarias.Size = new Size(220, 60);
            btnMaquinarias.TabIndex = 10;
            btnMaquinarias.Text = "Maquinaria";
            btnMaquinarias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaquinarias.UseVisualStyleBackColor = true;
            btnMaquinarias.Click += btnMaquinarias_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(31, 30, 68);
            btnDetalles.Dock = DockStyle.Top;
            btnDetalles.FlatAppearance.BorderSize = 0;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Segoe UI", 10.2F);
            btnDetalles.ForeColor = Color.White;
            btnDetalles.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnDetalles.IconColor = Color.White;
            btnDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalles.Location = new Point(0, 620);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Padding = new Padding(0, 10, 20, 0);
            btnDetalles.Size = new Size(220, 65);
            btnDetalles.TabIndex = 12;
            btnDetalles.Text = "Detalles";
            btnDetalles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click_1;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(31, 30, 68);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            btnReportes.IconColor = Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 685);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(0, 10, 20, 0);
            btnReportes.Size = new Size(220, 61);
            btnReportes.TabIndex = 14;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(panelSubContenedor);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnDetalles);
            panelMenu.Controls.Add(btnMaquinarias);
            panelMenu.Controls.Add(btnVehiculos);
            panelMenu.Controls.Add(btnAvaluos);
            panelMenu.Controls.Add(btnProyectos);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 1055);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panelSubContenedor
            // 
            panelSubContenedor.Controls.Add(iconButton4);
            panelSubContenedor.Controls.Add(iconButton3);
            panelSubContenedor.Controls.Add(iconButton2);
            panelSubContenedor.Controls.Add(iconButton1);
            panelSubContenedor.Dock = DockStyle.Top;
            panelSubContenedor.Location = new Point(0, 746);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(220, 142);
            panelSubContenedor.TabIndex = 15;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(0, 87);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(220, 29);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "iconButton4";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(0, 58);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(220, 29);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "iconButton3";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(0, 29);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(220, 29);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(220, 29);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1847, 1055);
            Controls.Add(panelContenedor);
            Controls.Add(panelTituloBarra);
            Controls.Add(panelMenu);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MenuForm_Load;
            panelTituloBarra.ResumeLayout(false);
            panelTituloBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormulario).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelMenu.ResumeLayout(false);
            panelSubContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTituloBarra;
        private FontAwesome.Sharp.IconPictureBox IconoFormulario;
        private Label TituloFormulario;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private Label lblHora;
        private System.Windows.Forms.Timer horafecha;
        private Label lblFecha;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private Label lblUsuario;
        private Label label1;
        private Panel panelLogo;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnProyectos;
        private FontAwesome.Sharp.IconButton btnAvaluos;
        private FontAwesome.Sharp.IconButton btnVehiculos;
        private FontAwesome.Sharp.IconButton btnMaquinarias;
        private FontAwesome.Sharp.IconButton btnDetalles;
        private FontAwesome.Sharp.IconButton btnReportes;
        private Panel panelMenu;
        private Panel panelSubContenedor;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
