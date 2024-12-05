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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dgvVehiculoDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbVehiculoID
            // 
            cbVehiculoID.FormattingEnabled = true;
            cbVehiculoID.Location = new Point(44, 45);
            cbVehiculoID.Name = "cbVehiculoID";
            cbVehiculoID.Size = new Size(155, 23);
            cbVehiculoID.TabIndex = 0;
            // 
            // cbEmpleadoID
            // 
            cbEmpleadoID.FormattingEnabled = true;
            cbEmpleadoID.Location = new Point(44, 112);
            cbEmpleadoID.Name = "cbEmpleadoID";
            cbEmpleadoID.Size = new Size(155, 23);
            cbEmpleadoID.TabIndex = 1;
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaAsignacion.Location = new Point(283, 40);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(108, 25);
            dtpFechaAsignacion.TabIndex = 2;
            // 
            // dtpFechaFinAsignacion
            // 
            dtpFechaFinAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaFinAsignacion.Location = new Point(283, 107);
            dtpFechaFinAsignacion.Name = "dtpFechaFinAsignacion";
            dtpFechaFinAsignacion.Size = new Size(108, 25);
            dtpFechaFinAsignacion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(427, 76);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 79);
            txtDescripcion.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(689, 90);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(689, 156);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(689, 29);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvVehiculoDetalles
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculoDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehiculoDetalles.AutoGenerateColumns = false;
            dgvVehiculoDetalles.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVehiculoDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVehiculoDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculoDetalles.Columns.AddRange(new DataGridViewColumn[] { vehiculoDetalleIDDataGridViewTextBoxColumn, empleadoIDDataGridViewTextBoxColumn, vehiculoIDDataGridViewTextBoxColumn, fechaAsignacionDataGridViewTextBoxColumn, fechaFinAsignacionDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dgvVehiculoDetalles.DataSource = vehiculoDetalleBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVehiculoDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVehiculoDetalles.Location = new Point(44, 207);
            dgvVehiculoDetalles.Name = "dgvVehiculoDetalles";
            dgvVehiculoDetalles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVehiculoDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculoDetalles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVehiculoDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculoDetalles.Size = new Size(652, 150);
            dgvVehiculoDetalles.TabIndex = 28;
            dgvVehiculoDetalles.CellContentClick += dgvVehiculoDetalles_CellContentClick;
            // 
            // vehiculoDetalleIDDataGridViewTextBoxColumn
            // 
            vehiculoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo_DetalleID";
            vehiculoDetalleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            vehiculoDetalleIDDataGridViewTextBoxColumn.Name = "vehiculoDetalleIDDataGridViewTextBoxColumn";
            vehiculoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            vehiculoDetalleIDDataGridViewTextBoxColumn.Width = 80;
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
            fechaAsignacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Asignacion";
            fechaAsignacionDataGridViewTextBoxColumn.Name = "fechaAsignacionDataGridViewTextBoxColumn";
            fechaAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinAsignacionDataGridViewTextBoxColumn
            // 
            fechaFinAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinAsignacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion";
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
            // VehiculosDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
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
            Text = "VehiculosDetalles";
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
        private BindingSource vehiculoDetalleBindingSource;
        private DataGridViewTextBoxColumn vehiculoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehiculoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}