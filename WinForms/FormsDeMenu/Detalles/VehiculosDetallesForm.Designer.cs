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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculoDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbVehiculoID
            // 
            cbVehiculoID.FormattingEnabled = true;
            cbVehiculoID.Location = new Point(376, 52);
            cbVehiculoID.Name = "cbVehiculoID";
            cbVehiculoID.Size = new Size(155, 23);
            cbVehiculoID.TabIndex = 0;
            // 
            // cbEmpleadoID
            // 
            cbEmpleadoID.FormattingEnabled = true;
            cbEmpleadoID.Location = new Point(376, 117);
            cbEmpleadoID.Name = "cbEmpleadoID";
            cbEmpleadoID.Size = new Size(155, 23);
            cbEmpleadoID.TabIndex = 1;
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaAsignacion.Location = new Point(724, 48);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(108, 25);
            dtpFechaAsignacion.TabIndex = 2;
            // 
            // dtpFechaFinAsignacion
            // 
            dtpFechaFinAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaFinAsignacion.Location = new Point(724, 114);
            dtpFechaFinAsignacion.Name = "dtpFechaFinAsignacion";
            dtpFechaFinAsignacion.Size = new Size(108, 25);
            dtpFechaFinAsignacion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(376, 172);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 79);
            txtDescripcion.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.System;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(855, 113);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 38);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.System;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(855, 179);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 38);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(855, 52);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 38);
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
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVehiculoDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVehiculoDetalles.Location = new Point(301, 273);
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
            dgvVehiculoDetalles.Size = new Size(652, 398);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(275, 52);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 29;
            label1.Text = "Empleado ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(282, 117);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 30;
            label2.Text = "Vehiculo ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(275, 198);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 31;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(598, 117);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 32;
            label4.Text = "Fecha Fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(598, 54);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 33;
            label5.Text = "Fecha Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(545, 9);
            label6.Name = "label6";
            label6.Size = new Size(209, 32);
            label6.TabIndex = 34;
            label6.Text = "Vehiculo Detalles";
            // 
            // VehiculosDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1157, 721);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvVehiculoDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFechaFinAsignacion);
            Controls.Add(dtpFechaAsignacion);
            Controls.Add(cbEmpleadoID);
            Controls.Add(cbVehiculoID);
            ForeColor = Color.Black;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}