namespace WinForms.FormsDeMenu.Detalles
{
    partial class VehiculosDetallesForm
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
            cbVehiculoID = new ComboBox();
            cbEmpleadoID = new ComboBox();
            dtpFechaAsignacion = new DateTimePicker();
            dtpFechaFinAsignacion = new DateTimePicker();
            txtDescripcion = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvVehiculoDetalles = new DataGridView();
            vehiculoDetalleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehiculoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaAsignacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinAsignacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehiculoDetalleBindingSource = new BindingSource(components);
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculoDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbVehiculoID
            // 
            cbVehiculoID.FormattingEnabled = true;
            cbVehiculoID.Location = new Point(147, 30);
            cbVehiculoID.Name = "cbVehiculoID";
            cbVehiculoID.Size = new Size(121, 23);
            cbVehiculoID.TabIndex = 0;
            // 
            // cbEmpleadoID
            // 
            cbEmpleadoID.FormattingEnabled = true;
            cbEmpleadoID.Location = new Point(147, 99);
            cbEmpleadoID.Name = "cbEmpleadoID";
            cbEmpleadoID.Size = new Size(121, 23);
            cbEmpleadoID.TabIndex = 1;
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaAsignacion.Location = new Point(446, 28);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(108, 25);
            dtpFechaAsignacion.TabIndex = 2;
            // 
            // dtpFechaFinAsignacion
            // 
            dtpFechaFinAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaFinAsignacion.Location = new Point(446, 97);
            dtpFechaFinAsignacion.Name = "dtpFechaFinAsignacion";
            dtpFechaFinAsignacion.Size = new Size(108, 25);
            dtpFechaFinAsignacion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(147, 156);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 79);
            txtDescripcion.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(676, 89);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(676, 156);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(676, 28);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvVehiculoDetalles
            // 
            dgvVehiculoDetalles.AutoGenerateColumns = false;
            dgvVehiculoDetalles.BackgroundColor = Color.White;
            dgvVehiculoDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculoDetalles.Columns.AddRange(new DataGridViewColumn[] { vehiculoDetalleIDDataGridViewTextBoxColumn, empleadoIDDataGridViewTextBoxColumn, vehiculoIDDataGridViewTextBoxColumn, fechaAsignacionDataGridViewTextBoxColumn, fechaFinAsignacionDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dgvVehiculoDetalles.DataSource = vehiculoDetalleBindingSource;
            dgvVehiculoDetalles.Location = new Point(100, 248);
            dgvVehiculoDetalles.Name = "dgvVehiculoDetalles";
            dgvVehiculoDetalles.ReadOnly = true;
            dgvVehiculoDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculoDetalles.Size = new Size(644, 190);
            dgvVehiculoDetalles.TabIndex = 28;
            dgvVehiculoDetalles.CellContentClick += dgvVehiculoDetalles_CellContentClick;
            // 
            // vehiculoDetalleIDDataGridViewTextBoxColumn
            // 
            vehiculoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo_DetalleID";
            vehiculoDetalleIDDataGridViewTextBoxColumn.HeaderText = "Vehiculo_DetalleID";
            vehiculoDetalleIDDataGridViewTextBoxColumn.Name = "vehiculoDetalleIDDataGridViewTextBoxColumn";
            vehiculoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoIDDataGridViewTextBoxColumn
            // 
            vehiculoIDDataGridViewTextBoxColumn.DataPropertyName = "VehiculoID";
            vehiculoIDDataGridViewTextBoxColumn.HeaderText = "VehiculoID";
            vehiculoIDDataGridViewTextBoxColumn.Name = "vehiculoIDDataGridViewTextBoxColumn";
            vehiculoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAsignacionDataGridViewTextBoxColumn
            // 
            fechaAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAsignacion";
            fechaAsignacionDataGridViewTextBoxColumn.HeaderText = "FechaAsignacion";
            fechaAsignacionDataGridViewTextBoxColumn.Name = "fechaAsignacionDataGridViewTextBoxColumn";
            fechaAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinAsignacionDataGridViewTextBoxColumn
            // 
            fechaFinAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinAsignacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.HeaderText = "FechaFinAsignacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.Name = "fechaFinAsignacionDataGridViewTextBoxColumn";
            fechaFinAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoDetalleBindingSource
            // 
            vehiculoDetalleBindingSource.DataSource = typeof(SharedModels.VehiculoDetalle);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(44, 32);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 29;
            label4.Text = "EmpleadoID:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 101);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 30;
            label1.Text = "VehiculoID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 156);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 31;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(349, 28);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 32;
            label3.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(365, 103);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 33;
            label5.Text = "Fecha Fin";
            // 
            // VehiculosDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(871, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dgvVehiculoDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFechaFinAsignacion);
            Controls.Add(dtpFechaAsignacion);
            Controls.Add(cbEmpleadoID);
            Controls.Add(cbVehiculoID);
            Name = "VehiculosDetallesForm";
            Text = "VehiculosDetallesForm";
            Load += VehiculosDetallesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculoDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoDetalleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVehiculoID;
        private ComboBox cbEmpleadoID;
        private DateTimePicker dtpFechaAsignacion;
        private DateTimePicker dtpFechaFinAsignacion;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvVehiculoDetalles;
        private DataGridViewTextBoxColumn vehiculoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehiculoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource vehiculoDetalleBindingSource;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}