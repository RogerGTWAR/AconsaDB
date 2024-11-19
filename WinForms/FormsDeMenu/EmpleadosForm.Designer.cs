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
            cargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            txtCargo = new TextBox();
            txtCedula = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            txtReportes = new TextBox();
            dtpFechaContratacion = new DateTimePicker();
            dtpFechaNacimiento = new DateTimePicker();
            panelSubcontenedor = new Panel();
            cbPagina = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            panelSubcontenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { empleadoIDDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, cargoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, fechaContratacionDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, reportesDataGridViewTextBoxColumn });
            dgvEmpleados.DataSource = empleadoBindingSource;
            dgvEmpleados.Dock = DockStyle.Bottom;
            dgvEmpleados.Location = new Point(0, 315);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1448, 333);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            empleadoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            empleadoIDDataGridViewTextBoxColumn.Width = 60;
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
            // cargoDataGridViewTextBoxColumn
            // 
            cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            cargoDataGridViewTextBoxColumn.ReadOnly = true;
            cargoDataGridViewTextBoxColumn.Width = 125;
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
            reportesDataGridViewTextBoxColumn.Width = 70;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Empleado);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 243);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 48);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(541, 243);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 48);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(678, 243);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 48);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(337, 30);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 27);
            txtNombres.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(680, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 5;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(522, 30);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(974, 30);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(269, 107);
            txtDireccion.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(522, 95);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 27);
            txtCargo.TabIndex = 8;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(662, 95);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(308, 95);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 27);
            txtApellidos.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(801, 172);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 11;
            // 
            // txtReportes
            // 
            txtReportes.Location = new Point(642, 172);
            txtReportes.Name = "txtReportes";
            txtReportes.Size = new Size(125, 27);
            txtReportes.TabIndex = 12;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(317, 170);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(126, 27);
            dtpFechaContratacion.TabIndex = 13;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(479, 172);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(126, 27);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // panelSubcontenedor
            // 
            panelSubcontenedor.Controls.Add(cbPagina);
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
            panelSubcontenedor.Controls.Add(txtCargo);
            panelSubcontenedor.Controls.Add(txtDireccion);
            panelSubcontenedor.Location = new Point(12, 12);
            panelSubcontenedor.Name = "panelSubcontenedor";
            panelSubcontenedor.Size = new Size(1448, 648);
            panelSubcontenedor.TabIndex = 15;
            // 
            // cbPagina
            // 
            cbPagina.FormattingEnabled = true;
            cbPagina.Location = new Point(949, 243);
            cbPagina.Name = "cbPagina";
            cbPagina.Size = new Size(151, 28);
            cbPagina.TabIndex = 15;
            cbPagina.SelectedIndexChanged += cbPagina_SelectedIndexChanged;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1463, 820);
            Controls.Add(panelSubcontenedor);
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
        private TextBox txtCargo;
        private TextBox txtCedula;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private TextBox txtReportes;
        private DateTimePicker dtpFechaContratacion;
        private DateTimePicker dtpFechaNacimiento;
        private BindingSource empleadoBindingSource;
        private Panel panelSubcontenedor;
        private ComboBox cbPagina;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaContratacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reportesDataGridViewTextBoxColumn;
    }
}