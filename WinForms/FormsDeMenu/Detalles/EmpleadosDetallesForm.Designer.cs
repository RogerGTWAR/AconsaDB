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
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbEmpleadoID
            // 
            cbEmpleadoID.FormattingEnabled = true;
            cbEmpleadoID.Location = new Point(113, 46);
            cbEmpleadoID.Name = "cbEmpleadoID";
            cbEmpleadoID.Size = new Size(155, 23);
            cbEmpleadoID.TabIndex = 0;
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(113, 104);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(155, 23);
            cbProyectoID.TabIndex = 1;
            // 
            // dtpFechaProyecto
            // 
            dtpFechaProyecto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaProyecto.Format = DateTimePickerFormat.Short;
            dtpFechaProyecto.Location = new Point(404, 46);
            dtpFechaProyecto.Name = "dtpFechaProyecto";
            dtpFechaProyecto.Size = new Size(111, 25);
            dtpFechaProyecto.TabIndex = 2;
            // 
            // dgvEmpleadosDetalles
            // 
            dgvEmpleadosDetalles.AutoGenerateColumns = false;
            dgvEmpleadosDetalles.BackgroundColor = Color.White;
            dgvEmpleadosDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosDetalles.Columns.AddRange(new DataGridViewColumn[] { empleadoDetalleIDDataGridViewTextBoxColumn, empleadoIDDataGridViewTextBoxColumn, proyectoIDDataGridViewTextBoxColumn, fechaDeProyectoDataGridViewTextBoxColumn });
            dgvEmpleadosDetalles.DataSource = empleadoDetalleBindingSource;
            dgvEmpleadosDetalles.Location = new Point(200, 227);
            dgvEmpleadosDetalles.Name = "dgvEmpleadosDetalles";
            dgvEmpleadosDetalles.ReadOnly = true;
            dgvEmpleadosDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleadosDetalles.Size = new Size(443, 234);
            dgvEmpleadosDetalles.TabIndex = 3;
            dgvEmpleadosDetalles.CellContentClick += dgvEmpleadosDetalles_CellContentClick;
            // 
            // empleadoDetalleIDDataGridViewTextBoxColumn
            // 
            empleadoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Empleado_DetalleID";
            empleadoDetalleIDDataGridViewTextBoxColumn.HeaderText = "Empleado_DetalleID";
            empleadoDetalleIDDataGridViewTextBoxColumn.Name = "empleadoDetalleIDDataGridViewTextBoxColumn";
            empleadoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            fechaDeProyectoDataGridViewTextBoxColumn.HeaderText = "FechaDeProyecto";
            fechaDeProyectoDataGridViewTextBoxColumn.Name = "fechaDeProyectoDataGridViewTextBoxColumn";
            fechaDeProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoDetalleBindingSource
            // 
            empleadoDetalleBindingSource.DataSource = typeof(SharedModels.EmpleadoDetalle);
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(531, 158);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 24;
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
            btnModificar.Location = new Point(531, 90);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 23;
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
            btnAgregar.Location = new Point(531, 23);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(113, 158);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(155, 27);
            txtDescripcion.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 104);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 26;
            label1.Text = "ProyectoID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 27;
            label2.Text = "EmpleadoID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 164);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 28;
            label3.Text = "Detalles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(280, 46);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 29;
            label4.Text = "Fecha Proyecto:";
            // 
            // EmpleadosDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(832, 473);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvEmpleadosDetalles);
            Controls.Add(dtpFechaProyecto);
            Controls.Add(cbProyectoID);
            Controls.Add(cbEmpleadoID);
            Name = "EmpleadosDetallesForm";
            Text = "EmpleadosDetallesForm";
            Load += EmpleadosDetallesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoDetalleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEmpleadoID;
        private ComboBox cbProyectoID;
        private DateTimePicker dtpFechaProyecto;
        private DataGridView dgvEmpleadosDetalles;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn empleadoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDeProyectoDataGridViewTextBoxColumn;
        private BindingSource empleadoDetalleBindingSource;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}