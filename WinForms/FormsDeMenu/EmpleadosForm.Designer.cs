using SharedModels;

namespace WinForms
{
    partial class EmpleadosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvEmpleados = new DataGridView();
            empleadoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaContratacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reportesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtNombres = new TextBox();
            txtTelefono = new TextBox();
            txtPais = new TextBox();
            txtDireccion = new TextBox();
            txtCedula = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            txtReportes = new TextBox();
            dtpFechaContratacion = new DateTimePicker();
            dtpFechaNacimiento = new DateTimePicker();
            panelSubcontenedor = new Panel();
            cbRolID = new ComboBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            panelSubcontenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.BackgroundColor = Color.LightGray;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { empleadoIDDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, rolIDDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, fechaContratacionDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, reportesDataGridViewTextBoxColumn });
            dgvEmpleados.DataSource = empleadoBindingSource;
            dgvEmpleados.Dock = DockStyle.Bottom;
            dgvEmpleados.Location = new Point(0, 333);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1295, 250);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            empleadoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            nombresDataGridViewTextBoxColumn.ReadOnly = true;
            nombresDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolIDDataGridViewTextBoxColumn
            // 
            rolIDDataGridViewTextBoxColumn.DataPropertyName = "RolID";
            rolIDDataGridViewTextBoxColumn.HeaderText = "RolID";
            rolIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            rolIDDataGridViewTextBoxColumn.Name = "rolIDDataGridViewTextBoxColumn";
            rolIDDataGridViewTextBoxColumn.ReadOnly = true;
            rolIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaContratacionDataGridViewTextBoxColumn
            // 
            fechaContratacionDataGridViewTextBoxColumn.DataPropertyName = "FechaContratacion";
            fechaContratacionDataGridViewTextBoxColumn.HeaderText = "FechaContratacion";
            fechaContratacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaContratacionDataGridViewTextBoxColumn.Name = "fechaContratacionDataGridViewTextBoxColumn";
            fechaContratacionDataGridViewTextBoxColumn.ReadOnly = true;
            fechaContratacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.MinimumWidth = 6;
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.ReadOnly = true;
            paisDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reportesDataGridViewTextBoxColumn
            // 
            reportesDataGridViewTextBoxColumn.DataPropertyName = "Reportes";
            reportesDataGridViewTextBoxColumn.HeaderText = "Reportes";
            reportesDataGridViewTextBoxColumn.MinimumWidth = 6;
            reportesDataGridViewTextBoxColumn.Name = "reportesDataGridViewTextBoxColumn";
            reportesDataGridViewTextBoxColumn.ReadOnly = true;
            reportesDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Empleado);
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1071, 103);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DimGray;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1071, 157);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DimGray;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1071, 218);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 36);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(187, 97);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(110, 23);
            txtNombres.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(460, 141);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(160, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(460, 97);
            txtPais.Margin = new Padding(3, 2, 3, 2);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(160, 23);
            txtPais.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(772, 98);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(236, 70);
            txtDireccion.TabIndex = 7;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(187, 189);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(110, 23);
            txtCedula.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(187, 141);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(110, 23);
            txtApellidos.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(460, 189);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(160, 23);
            txtCorreo.TabIndex = 11;
            // 
            // txtReportes
            // 
            txtReportes.Location = new Point(460, 238);
            txtReportes.Margin = new Padding(3, 2, 3, 2);
            txtReportes.Name = "txtReportes";
            txtReportes.Size = new Size(160, 23);
            txtReportes.TabIndex = 12;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(856, 245);
            dtpFechaContratacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(126, 26);
            dtpFechaContratacion.TabIndex = 13;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(187, 239);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(111, 23);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // panelSubcontenedor
            // 
            panelSubcontenedor.BackColor = Color.FromArgb(33, 33, 56);
            panelSubcontenedor.Controls.Add(cbRolID);
            panelSubcontenedor.Controls.Add(label14);
            panelSubcontenedor.Controls.Add(label11);
            panelSubcontenedor.Controls.Add(label10);
            panelSubcontenedor.Controls.Add(label9);
            panelSubcontenedor.Controls.Add(label8);
            panelSubcontenedor.Controls.Add(label7);
            panelSubcontenedor.Controls.Add(label6);
            panelSubcontenedor.Controls.Add(label5);
            panelSubcontenedor.Controls.Add(label4);
            panelSubcontenedor.Controls.Add(label3);
            panelSubcontenedor.Controls.Add(label2);
            panelSubcontenedor.Controls.Add(label1);
            panelSubcontenedor.Controls.Add(dgvEmpleados);
            panelSubcontenedor.Controls.Add(dtpFechaNacimiento);
            panelSubcontenedor.Controls.Add(txtNombres);
            panelSubcontenedor.Controls.Add(dtpFechaContratacion);
            panelSubcontenedor.Controls.Add(btnAgregar);
            panelSubcontenedor.Controls.Add(txtReportes);
            panelSubcontenedor.Controls.Add(btnEliminar);
            panelSubcontenedor.Controls.Add(txtCorreo);
            panelSubcontenedor.Controls.Add(btnModificar);
            panelSubcontenedor.Controls.Add(txtApellidos);
            panelSubcontenedor.Controls.Add(txtTelefono);
            panelSubcontenedor.Controls.Add(txtCedula);
            panelSubcontenedor.Controls.Add(txtPais);
            panelSubcontenedor.Controls.Add(txtDireccion);
            panelSubcontenedor.Controls.Add(label12);
            panelSubcontenedor.Location = new Point(0, -1);
            panelSubcontenedor.Margin = new Padding(3, 2, 3, 2);
            panelSubcontenedor.Name = "panelSubcontenedor";
            panelSubcontenedor.Size = new Size(1295, 583);
            panelSubcontenedor.TabIndex = 15;
            // 
            // cbRolID
            // 
            cbRolID.FormattingEnabled = true;
            cbRolID.Location = new Point(772, 186);
            cbRolID.Margin = new Padding(3, 2, 3, 2);
            cbRolID.Name = "cbRolID";
            cbRolID.Size = new Size(133, 23);
            cbRolID.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(692, 245);
            label14.Name = "label14";
            label14.Size = new Size(139, 17);
            label14.TabIndex = 29;
            label14.Text = "Fecha de contratación:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(692, 104);
            label11.Name = "label11";
            label11.Size = new Size(65, 17);
            label11.TabIndex = 26;
            label11.Text = "Dirección:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(391, 190);
            label10.Name = "label10";
            label10.Size = new Size(52, 17);
            label10.TabIndex = 25;
            label10.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(382, 147);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 24;
            label9.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(722, 186);
            label8.Name = "label8";
            label8.Size = new Size(30, 17);
            label8.TabIndex = 23;
            label8.Text = "Rol:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(379, 239);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 22;
            label7.Text = "Reportes:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(409, 103);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 21;
            label6.Text = "Pais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(609, 10);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 20;
            label5.Text = "Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(104, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 19;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 243);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 18;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 195);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 17;
            label2.Text = "Cedula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 16;
            label1.Text = "Nombres:";
            label1.Click += label1_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.DarkSlateGray;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(1292, 43);
            label12.TabIndex = 31;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1293, 582);
            Controls.Add(panelSubcontenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            Load += EmpleadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            panelSubcontenedor.ResumeLayout(false);
            panelSubcontenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtNombres;
        private TextBox txtTelefono;
        private TextBox txtPais;
        private TextBox txtDireccion;
        private TextBox txtCedula;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private TextBox txtReportes;
        private DateTimePicker dtpFechaContratacion;
        private DateTimePicker dtpFechaNacimiento;
        private Panel panelSubcontenedor;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaContratacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reportesDataGridViewTextBoxColumn;
        private BindingSource empleadoBindingSource;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label14;
        private ComboBox cbRolID;
        private Label label12;
    }
}