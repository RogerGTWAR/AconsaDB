namespace WinForms.FormsDeMenu.Detalles
{
    partial class EmpleadosDetallesForm
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
            cbEmpleadoID = new ComboBox();
            cbProyectoID = new ComboBox();
            dtpFechaProyecto = new DateTimePicker();
            dgvEmpleadosDetalles = new DataGridView();
            empleadoDetalleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDeProyectoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoDetalleBindingSource = new BindingSource(components);
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbEmpleadoID
            // 
            cbEmpleadoID.FormattingEnabled = true;
            cbEmpleadoID.Location = new Point(40, 44);
            cbEmpleadoID.Name = "cbEmpleadoID";
            cbEmpleadoID.Size = new Size(155, 23);
            cbEmpleadoID.TabIndex = 0;
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(40, 99);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(155, 23);
            cbProyectoID.TabIndex = 1;
            // 
            // dtpFechaProyecto
            // 
            dtpFechaProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaProyecto.Format = DateTimePickerFormat.Short;
            dtpFechaProyecto.Location = new Point(40, 152);
            dtpFechaProyecto.Name = "dtpFechaProyecto";
            dtpFechaProyecto.Size = new Size(111, 25);
            dtpFechaProyecto.TabIndex = 2;
            // 
            // dgvEmpleadosDetalles
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleadosDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleadosDetalles.AutoGenerateColumns = false;
            dgvEmpleadosDetalles.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleadosDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleadosDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosDetalles.Columns.AddRange(new DataGridViewColumn[] { empleadoDetalleIDDataGridViewTextBoxColumn, empleadoIDDataGridViewTextBoxColumn, proyectoIDDataGridViewTextBoxColumn, fechaDeProyectoDataGridViewTextBoxColumn });
            dgvEmpleadosDetalles.DataSource = empleadoDetalleBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmpleadosDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleadosDetalles.Location = new Point(40, 241);
            dgvEmpleadosDetalles.Name = "dgvEmpleadosDetalles";
            dgvEmpleadosDetalles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmpleadosDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleadosDetalles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmpleadosDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleadosDetalles.Size = new Size(507, 220);
            dgvEmpleadosDetalles.TabIndex = 3;
            dgvEmpleadosDetalles.CellContentClick += dgvEmpleadosDetalles_CellContentClick;
            // 
            // empleadoDetalleIDDataGridViewTextBoxColumn
            // 
            empleadoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Empleado_DetalleID";
            empleadoDetalleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            empleadoDetalleIDDataGridViewTextBoxColumn.Name = "empleadoDetalleIDDataGridViewTextBoxColumn";
            empleadoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            empleadoDetalleIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID";
            empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proyectoIDDataGridViewTextBoxColumn
            // 
            proyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.HeaderText = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            proyectoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeProyectoDataGridViewTextBoxColumn
            // 
            fechaDeProyectoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeProyecto";
            fechaDeProyectoDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio del Proyecto";
            fechaDeProyectoDataGridViewTextBoxColumn.Name = "fechaDeProyectoDataGridViewTextBoxColumn";
            fechaDeProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDeProyectoDataGridViewTextBoxColumn.Width = 120;
            // 
            // empleadoDetalleBindingSource
            // 
            empleadoDetalleBindingSource.DataSource = typeof(SharedModels.EmpleadoDetalle);
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(416, 105);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 24;
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
            btnModificar.Location = new Point(416, 171);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 23;
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
            btnAgregar.Location = new Point(416, 44);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // EmpleadosDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(832, 473);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvEmpleadosDetalles);
            Controls.Add(dtpFechaProyecto);
            Controls.Add(cbProyectoID);
            Controls.Add(cbEmpleadoID);
            Name = "EmpleadosDetallesForm";
            Text = "EmpleadosDetalles";
            Load += EmpleadosDetallesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDetalleBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbEmpleadoID;
        private ComboBox cbProyectoID;
        private DateTimePicker dtpFechaProyecto;
        private DataGridView dgvEmpleadosDetalles;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private BindingSource empleadoDetalleBindingSource;
        private DataGridViewTextBoxColumn empleadoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDeProyectoDataGridViewTextBoxColumn;
    }
}