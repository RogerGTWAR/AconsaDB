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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinariaDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(363, 54);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(164, 23);
            cbProyectoID.TabIndex = 0;
            // 
            // cbMaquinariaID
            // 
            cbMaquinariaID.FormattingEnabled = true;
            cbMaquinariaID.Location = new Point(363, 113);
            cbMaquinariaID.Name = "cbMaquinariaID";
            cbMaquinariaID.Size = new Size(164, 23);
            cbMaquinariaID.TabIndex = 1;
            // 
            // txtHorasUtilizadas
            // 
            txtHorasUtilizadas.Location = new Point(363, 176);
            txtHorasUtilizadas.Name = "txtHorasUtilizadas";
            txtHorasUtilizadas.Size = new Size(164, 23);
            txtHorasUtilizadas.TabIndex = 2;
            // 
            // dtpFechaInicioAsignacion
            // 
            dtpFechaInicioAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaInicioAsignacion.Location = new Point(687, 62);
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
            dgvMaquinariaDetalle.Location = new Point(280, 229);
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
            dgvMaquinariaDetalle.Size = new Size(637, 259);
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
            proyectoIDDataGridViewTextBoxColumn.HeaderText = "Proyecto ID";
            proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            proyectoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maquinariaIDDataGridViewTextBoxColumn
            // 
            maquinariaIDDataGridViewTextBoxColumn.DataPropertyName = "MaquinariaID";
            maquinariaIDDataGridViewTextBoxColumn.HeaderText = "Maquinaria ID";
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
            dtpFechaFinAsignacion.Location = new Point(687, 122);
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
            btnEliminar.Location = new Point(843, 113);
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
            btnModificar.Location = new Point(843, 178);
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
            btnAgregar.Location = new Point(843, 52);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 52);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 25;
            label1.Text = "Proyecto ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 115);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 26;
            label2.Text = "Maquinaria ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(236, 178);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 27;
            label3.Text = "Horas Utilizadas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(569, 66);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 28;
            label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(585, 129);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 29;
            label5.Text = "Fecha Fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(492, 9);
            label6.Name = "label6";
            label6.Size = new Size(243, 32);
            label6.TabIndex = 30;
            label6.Text = "Maquinaria Detalles";
            // 
            // MaquinariaDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1159, 546);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}