namespace WinForms.FormsDeMenu.Detalles
{
    partial class MaquinariaDetallesForm
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
            cbProyectoID = new ComboBox();
            cbMaquinariaID = new ComboBox();
            txtHorasUtilizadas = new TextBox();
            dtpFechaInicioAsignacion = new DateTimePicker();
            dgvMaquinariaDetalle = new DataGridView();
            maquinariaDetalleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maquinariaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasUtilizadasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioAsignacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinAsignacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maquinariaDetalleBindingSource = new BindingSource(components);
            dtpFechaFinAsignacion = new DateTimePicker();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinariaDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(38, 52);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(164, 23);
            cbProyectoID.TabIndex = 0;
            // 
            // cbMaquinariaID
            // 
            cbMaquinariaID.FormattingEnabled = true;
            cbMaquinariaID.Location = new Point(38, 111);
            cbMaquinariaID.Name = "cbMaquinariaID";
            cbMaquinariaID.Size = new Size(164, 23);
            cbMaquinariaID.TabIndex = 1;
            // 
            // txtHorasUtilizadas
            // 
            txtHorasUtilizadas.Location = new Point(299, 52);
            txtHorasUtilizadas.Name = "txtHorasUtilizadas";
            txtHorasUtilizadas.Size = new Size(148, 23);
            txtHorasUtilizadas.TabIndex = 2;
            // 
            // dtpFechaInicioAsignacion
            // 
            dtpFechaInicioAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaInicioAsignacion.Location = new Point(521, 47);
            dtpFechaInicioAsignacion.Name = "dtpFechaInicioAsignacion";
            dtpFechaInicioAsignacion.Size = new Size(111, 25);
            dtpFechaInicioAsignacion.TabIndex = 3;
            // 
            // dgvMaquinariaDetalle
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaquinariaDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaquinariaDetalle.AutoGenerateColumns = false;
            dgvMaquinariaDetalle.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMaquinariaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMaquinariaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinariaDetalle.Columns.AddRange(new DataGridViewColumn[] { maquinariaDetalleIDDataGridViewTextBoxColumn, proyectoIDDataGridViewTextBoxColumn, maquinariaIDDataGridViewTextBoxColumn, horasUtilizadasDataGridViewTextBoxColumn, fechaInicioAsignacionDataGridViewTextBoxColumn, fechaFinAsignacionDataGridViewTextBoxColumn });
            dgvMaquinariaDetalle.DataSource = maquinariaDetalleBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMaquinariaDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMaquinariaDetalle.Location = new Point(38, 263);
            dgvMaquinariaDetalle.Name = "dgvMaquinariaDetalle";
            dgvMaquinariaDetalle.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMaquinariaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaquinariaDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMaquinariaDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaquinariaDetalle.Size = new Size(637, 150);
            dgvMaquinariaDetalle.TabIndex = 4;
            dgvMaquinariaDetalle.CellContentClick += dgvMaquinariaDetalle_CellContentClick;
            // 
            // maquinariaDetalleIDDataGridViewTextBoxColumn
            // 
            maquinariaDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Maquinaria_DetalleID";
            maquinariaDetalleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            maquinariaDetalleIDDataGridViewTextBoxColumn.Name = "maquinariaDetalleIDDataGridViewTextBoxColumn";
            maquinariaDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            maquinariaDetalleIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // proyectoIDDataGridViewTextBoxColumn
            // 
            proyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.HeaderText = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            proyectoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maquinariaIDDataGridViewTextBoxColumn
            // 
            maquinariaIDDataGridViewTextBoxColumn.DataPropertyName = "MaquinariaID";
            maquinariaIDDataGridViewTextBoxColumn.HeaderText = "MaquinariaID";
            maquinariaIDDataGridViewTextBoxColumn.Name = "maquinariaIDDataGridViewTextBoxColumn";
            maquinariaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasUtilizadasDataGridViewTextBoxColumn
            // 
            horasUtilizadasDataGridViewTextBoxColumn.DataPropertyName = "HorasUtilizadas";
            horasUtilizadasDataGridViewTextBoxColumn.HeaderText = "Horas Utilizadas";
            horasUtilizadasDataGridViewTextBoxColumn.Name = "horasUtilizadasDataGridViewTextBoxColumn";
            horasUtilizadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioAsignacionDataGridViewTextBoxColumn
            // 
            fechaInicioAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaInicioAsignacion";
            fechaInicioAsignacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Asignacion";
            fechaInicioAsignacionDataGridViewTextBoxColumn.Name = "fechaInicioAsignacionDataGridViewTextBoxColumn";
            fechaInicioAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinAsignacionDataGridViewTextBoxColumn
            // 
            fechaFinAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinAsignacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.Name = "fechaFinAsignacionDataGridViewTextBoxColumn";
            fechaFinAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maquinariaDetalleBindingSource
            // 
            maquinariaDetalleBindingSource.DataSource = typeof(SharedModels.MaquinariaDetalle);
            // 
            // dtpFechaFinAsignacion
            // 
            dtpFechaFinAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaFinAsignacion.Location = new Point(521, 109);
            dtpFechaFinAsignacion.Name = "dtpFechaFinAsignacion";
            dtpFechaFinAsignacion.Size = new Size(111, 25);
            dtpFechaFinAsignacion.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(681, 108);
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
            btnModificar.Location = new Point(681, 174);
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
            btnAgregar.Location = new Point(681, 47);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // MaquinariaDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(805, 469);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaFinAsignacion);
            Controls.Add(dgvMaquinariaDetalle);
            Controls.Add(dtpFechaInicioAsignacion);
            Controls.Add(txtHorasUtilizadas);
            Controls.Add(cbMaquinariaID);
            Controls.Add(cbProyectoID);
            Name = "MaquinariaDetallesForm";
            Text = "MaquinariaDetalles";
            Load += MaquinariaDetallesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquinariaDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaDetalleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProyectoID;
        private ComboBox cbMaquinariaID;
        private TextBox txtHorasUtilizadas;
        private DateTimePicker dtpFechaInicioAsignacion;
        private DataGridView dgvMaquinariaDetalle;
        private DateTimePicker dtpFechaFinAsignacion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private BindingSource maquinariaDetalleBindingSource;
        private DataGridViewTextBoxColumn maquinariaDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maquinariaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasUtilizadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinAsignacionDataGridViewTextBoxColumn;
    }
}