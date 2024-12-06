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
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            btnReportes = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            panelSubContenedor = new Panel();
            btnMaquinariaDetalle = new FontAwesome.Sharp.IconButton();
            btnVehiculosDetalles = new FontAwesome.Sharp.IconButton();
            btnEmpleadosDetalles = new FontAwesome.Sharp.IconButton();
            btnAvaluosDetalles = new FontAwesome.Sharp.IconButton();
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
            panelTituloBarra.Location = new Point(192, 0);
            panelTituloBarra.Margin = new Padding(3, 2, 3, 2);
            panelTituloBarra.Name = "panelTituloBarra";
            panelTituloBarra.Size = new Size(1063, 56);
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
            btnUsuario.Location = new Point(1001, 2);
            btnUsuario.Margin = new Padding(3, 2, 3, 2);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(52, 43);
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
            lblFecha.Location = new Point(335, 14);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(78, 32);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(200, 14);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(70, 32);
            lblHora.TabIndex = 2;
            lblHora.Text = "Hora";
            // 
            // TituloFormulario
            // 
            TituloFormulario.AutoSize = true;
            TituloFormulario.ForeColor = Color.White;
            TituloFormulario.Location = new Point(34, 27);
            TituloFormulario.Name = "TituloFormulario";
            TituloFormulario.Size = new Size(40, 15);
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
            IconoFormulario.IconSize = 22;
            IconoFormulario.Location = new Point(5, 27);
            IconoFormulario.Margin = new Padding(3, 2, 3, 2);
            IconoFormulario.Name = "IconoFormulario";
            IconoFormulario.Size = new Size(24, 22);
            IconoFormulario.TabIndex = 0;
            IconoFormulario.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(164, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(102, 32);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(lblUsuario);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(192, 56);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1063, 709);
            panelContenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calculo_y_Diseño_Estructural__ACONSA;
            pictureBox1.Location = new Point(178, 70);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(791, 530);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido";
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
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(192, 105);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.Aconsa;
            btnHome.Location = new Point(21, 0);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(137, 103);
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
            btnEmpleados.Location = new Point(0, 105);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(0, 8, 18, 0);
            btnEmpleados.Size = new Size(192, 58);
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
            btnClientes.Location = new Point(0, 163);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(0, 8, 18, 0);
            btnClientes.Size = new Size(192, 58);
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
            btnProveedores.Location = new Point(0, 221);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(0, 8, 18, 0);
            btnProveedores.Size = new Size(192, 58);
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
            btnProductos.Location = new Point(0, 279);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(0, 8, 18, 0);
            btnProductos.Size = new Size(192, 58);
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
            btnProyectos.Location = new Point(0, 337);
            btnProyectos.Margin = new Padding(3, 2, 3, 2);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Padding = new Padding(0, 8, 18, 0);
            btnProyectos.Size = new Size(192, 58);
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
            btnAvaluos.Location = new Point(0, 395);
            btnAvaluos.Margin = new Padding(3, 2, 3, 2);
            btnAvaluos.Name = "btnAvaluos";
            btnAvaluos.Padding = new Padding(0, 8, 18, 0);
            btnAvaluos.Size = new Size(192, 58);
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
            btnVehiculos.Location = new Point(0, 453);
            btnVehiculos.Margin = new Padding(3, 2, 3, 2);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Padding = new Padding(0, 8, 18, 0);
            btnVehiculos.Size = new Size(192, 58);
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
            btnMaquinarias.Location = new Point(0, 511);
            btnMaquinarias.Margin = new Padding(3, 2, 3, 2);
            btnMaquinarias.Name = "btnMaquinarias";
            btnMaquinarias.Padding = new Padding(0, 8, 18, 0);
            btnMaquinarias.Size = new Size(192, 58);
            btnMaquinarias.TabIndex = 10;
            btnMaquinarias.Text = "Maquinaria";
            btnMaquinarias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaquinarias.UseVisualStyleBackColor = true;
            btnMaquinarias.Click += btnMaquinarias_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(31, 30, 68);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnReportes.IconColor = Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 569);
            btnReportes.Margin = new Padding(3, 2, 3, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(0, 8, 18, 0);
            btnReportes.Size = new Size(192, 58);
            btnReportes.TabIndex = 14;
            btnReportes.Text = "Detalles";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(panelSubContenedor);
            panelMenu.Controls.Add(btnReportes);
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
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 765);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panelSubContenedor
            // 
            panelSubContenedor.Controls.Add(btnMaquinariaDetalle);
            panelSubContenedor.Controls.Add(btnVehiculosDetalles);
            panelSubContenedor.Controls.Add(btnEmpleadosDetalles);
            panelSubContenedor.Controls.Add(btnAvaluosDetalles);
            panelSubContenedor.Dock = DockStyle.Top;
            panelSubContenedor.Location = new Point(0, 627);
            panelSubContenedor.Margin = new Padding(3, 2, 3, 2);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(192, 135);
            panelSubContenedor.TabIndex = 15;
            // 
            // btnMaquinariaDetalle
            // 
            btnMaquinariaDetalle.Dock = DockStyle.Top;
            btnMaquinariaDetalle.FlatAppearance.BorderSize = 0;
            btnMaquinariaDetalle.FlatStyle = FlatStyle.Flat;
            btnMaquinariaDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaquinariaDetalle.ForeColor = Color.White;
            btnMaquinariaDetalle.IconChar = FontAwesome.Sharp.IconChar.TruckArrowRight;
            btnMaquinariaDetalle.IconColor = Color.White;
            btnMaquinariaDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaquinariaDetalle.IconSize = 30;
            btnMaquinariaDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaquinariaDetalle.Location = new Point(0, 87);
            btnMaquinariaDetalle.Margin = new Padding(3, 2, 3, 2);
            btnMaquinariaDetalle.Name = "btnMaquinariaDetalle";
            btnMaquinariaDetalle.Size = new Size(192, 29);
            btnMaquinariaDetalle.TabIndex = 3;
            btnMaquinariaDetalle.Text = "Maquinaria";
            btnMaquinariaDetalle.UseVisualStyleBackColor = true;
            btnMaquinariaDetalle.Click += btnMaquinariaDetalle_Click;
            // 
            // btnVehiculosDetalles
            // 
            btnVehiculosDetalles.Dock = DockStyle.Top;
            btnVehiculosDetalles.FlatAppearance.BorderSize = 0;
            btnVehiculosDetalles.FlatStyle = FlatStyle.Flat;
            btnVehiculosDetalles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVehiculosDetalles.ForeColor = Color.White;
            btnVehiculosDetalles.IconChar = FontAwesome.Sharp.IconChar.Car;
            btnVehiculosDetalles.IconColor = Color.White;
            btnVehiculosDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVehiculosDetalles.IconSize = 30;
            btnVehiculosDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculosDetalles.Location = new Point(0, 58);
            btnVehiculosDetalles.Margin = new Padding(3, 2, 3, 2);
            btnVehiculosDetalles.Name = "btnVehiculosDetalles";
            btnVehiculosDetalles.Size = new Size(192, 29);
            btnVehiculosDetalles.TabIndex = 2;
            btnVehiculosDetalles.Text = "Vehiculos";
            btnVehiculosDetalles.UseVisualStyleBackColor = true;
            btnVehiculosDetalles.Click += btnVehiculosDetalles_Click;
            // 
            // btnEmpleadosDetalles
            // 
            btnEmpleadosDetalles.Dock = DockStyle.Top;
            btnEmpleadosDetalles.FlatAppearance.BorderSize = 0;
            btnEmpleadosDetalles.FlatStyle = FlatStyle.Flat;
            btnEmpleadosDetalles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleadosDetalles.ForeColor = Color.White;
            btnEmpleadosDetalles.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnEmpleadosDetalles.IconColor = Color.White;
            btnEmpleadosDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleadosDetalles.IconSize = 30;
            btnEmpleadosDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleadosDetalles.Location = new Point(0, 29);
            btnEmpleadosDetalles.Margin = new Padding(3, 2, 3, 2);
            btnEmpleadosDetalles.Name = "btnEmpleadosDetalles";
            btnEmpleadosDetalles.Size = new Size(192, 29);
            btnEmpleadosDetalles.TabIndex = 1;
            btnEmpleadosDetalles.Text = "Empleados";
            btnEmpleadosDetalles.UseVisualStyleBackColor = true;
            btnEmpleadosDetalles.Click += btnEmpleadosDetalles_Click;
            // 
            // btnAvaluosDetalles
            // 
            btnAvaluosDetalles.Dock = DockStyle.Top;
            btnAvaluosDetalles.FlatAppearance.BorderSize = 0;
            btnAvaluosDetalles.FlatStyle = FlatStyle.Flat;
            btnAvaluosDetalles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvaluosDetalles.ForeColor = Color.White;
            btnAvaluosDetalles.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnAvaluosDetalles.IconColor = Color.White;
            btnAvaluosDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvaluosDetalles.IconSize = 30;
            btnAvaluosDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvaluosDetalles.Location = new Point(0, 0);
            btnAvaluosDetalles.Margin = new Padding(3, 2, 3, 2);
            btnAvaluosDetalles.Name = "btnAvaluosDetalles";
            btnAvaluosDetalles.Size = new Size(192, 29);
            btnAvaluosDetalles.TabIndex = 0;
            btnAvaluosDetalles.Text = "Avaluos";
            btnAvaluosDetalles.UseVisualStyleBackColor = true;
            btnAvaluosDetalles.Click += btnAvaluosDetalles_Click_1;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 765);
            Controls.Add(panelContenedor);
            Controls.Add(panelTituloBarra);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
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
        private FontAwesome.Sharp.IconButton btnReportes;
        private Panel panelMenu;
        private Panel panelSubContenedor;
        private FontAwesome.Sharp.IconButton btnMaquinariaDetalle;
        private FontAwesome.Sharp.IconButton btnVehiculosDetalles;
        private FontAwesome.Sharp.IconButton btnEmpleadosDetalles;
        private FontAwesome.Sharp.IconButton btnAvaluosDetalles;
    }
}
