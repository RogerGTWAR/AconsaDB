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
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinariaDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(116, 36);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(135, 23);
            cbProyectoID.TabIndex = 0;
            // 
            // cbMaquinariaID
            // 
            cbMaquinariaID.FormattingEnabled = true;
            cbMaquinariaID.Location = new Point(116, 87);
            cbMaquinariaID.Name = "cbMaquinariaID";
            cbMaquinariaID.Size = new Size(135, 23);
            cbMaquinariaID.TabIndex = 1;
            // 
            // txtHorasUtilizadas
            // 
            txtHorasUtilizadas.Location = new Point(116, 131);
            txtHorasUtilizadas.Name = "txtHorasUtilizadas";
            txtHorasUtilizadas.Size = new Size(135, 23);
            txtHorasUtilizadas.TabIndex = 2;
            // 
            // dtpFechaInicioAsignacion
            // 
            dtpFechaInicioAsignacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaInicioAsignacion.Location = new Point(406, 87);
            dtpFechaInicioAsignacion.Name = "dtpFechaInicioAsignacion";
            dtpFechaInicioAsignacion.Size = new Size(111, 25);
            dtpFechaInicioAsignacion.TabIndex = 3;
            // 
            // dgvMaquinariaDetalle
            // 
            dgvMaquinariaDetalle.AutoGenerateColumns = false;
            dgvMaquinariaDetalle.BackgroundColor = Color.White;
            dgvMaquinariaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinariaDetalle.Columns.AddRange(new DataGridViewColumn[] { maquinariaDetalleIDDataGridViewTextBoxColumn, proyectoIDDataGridViewTextBoxColumn, maquinariaIDDataGridViewTextBoxColumn, horasUtilizadasDataGridViewTextBoxColumn, fechaInicioAsignacionDataGridViewTextBoxColumn, fechaFinAsignacionDataGridViewTextBoxColumn });
            dgvMaquinariaDetalle.DataSource = maquinariaDetalleBindingSource;
            dgvMaquinariaDetalle.Location = new Point(69, 286);
            dgvMaquinariaDetalle.Name = "dgvMaquinariaDetalle";
            dgvMaquinariaDetalle.ReadOnly = true;
            dgvMaquinariaDetalle.Size = new Size(647, 150);
            dgvMaquinariaDetalle.TabIndex = 4;
            dgvMaquinariaDetalle.CellContentClick += dgvMaquinariaDetalle_CellContentClick;
            // 
            // maquinariaDetalleIDDataGridViewTextBoxColumn
            // 
            maquinariaDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Maquinaria_DetalleID";
            maquinariaDetalleIDDataGridViewTextBoxColumn.HeaderText = "Maquinaria_DetalleID";
            maquinariaDetalleIDDataGridViewTextBoxColumn.Name = "maquinariaDetalleIDDataGridViewTextBoxColumn";
            maquinariaDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            horasUtilizadasDataGridViewTextBoxColumn.HeaderText = "HorasUtilizadas";
            horasUtilizadasDataGridViewTextBoxColumn.Name = "horasUtilizadasDataGridViewTextBoxColumn";
            horasUtilizadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioAsignacionDataGridViewTextBoxColumn
            // 
            fechaInicioAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaInicioAsignacion";
            fechaInicioAsignacionDataGridViewTextBoxColumn.HeaderText = "FechaInicioAsignacion";
            fechaInicioAsignacionDataGridViewTextBoxColumn.Name = "fechaInicioAsignacionDataGridViewTextBoxColumn";
            fechaInicioAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinAsignacionDataGridViewTextBoxColumn
            // 
            fechaFinAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinAsignacion";
            fechaFinAsignacionDataGridViewTextBoxColumn.HeaderText = "FechaFinAsignacion";
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
            dtpFechaFinAsignacion.Location = new Point(406, 133);
            dtpFechaFinAsignacion.Name = "dtpFechaFinAsignacion";
            dtpFechaFinAsignacion.Size = new Size(111, 25);
            dtpFechaFinAsignacion.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(604, 86);
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
            btnModificar.Location = new Point(604, 152);
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
            btnAgregar.Location = new Point(604, 25);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 25;
            label1.Text = "ProyectoID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 85);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 26;
            label2.Text = "MaquinariaID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(42, 133);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 27;
            label3.Text = "Detalles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(275, 36);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 28;
            label4.Text = "Horas Utilizadas:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(406, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(309, 91);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 30;
            label5.Text = "Fecha Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(325, 136);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 31;
            label6.Text = "Fecha Fin";
            // 
            // MaquinariaDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(805, 469);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
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
            Text = "MaquinariaDetallesForm";
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
        private DataGridViewTextBoxColumn maquinariaDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maquinariaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasUtilizadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinAsignacionDataGridViewTextBoxColumn;
        private BindingSource maquinariaDetalleBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
    }
}