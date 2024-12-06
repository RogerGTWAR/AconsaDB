namespace WinForms
{
    partial class MaquinariaForm
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
            dgvMaquinaria = new DataGridView();
            maquinariaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreMaquinariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioRentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinalizacionRentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioPorHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maquinariaBindingSource = new BindingSource(components);
            cbProveedorID = new ComboBox();
            cbEstado = new ComboBox();
            txtMarca = new TextBox();
            dtpFechaInicioRenta = new DateTimePicker();
            txtModelo = new TextBox();
            txtPrecioPorHora = new TextBox();
            txtNombreMaquinaria = new TextBox();
            dtpFechaFinalizacionRenta = new DateTimePicker();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvMaquinaria
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaquinaria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaquinaria.AutoGenerateColumns = false;
            dgvMaquinaria.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMaquinaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinaria.Columns.AddRange(new DataGridViewColumn[] { maquinariaIDDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, nombreMaquinariaDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, fechaInicioRentaDataGridViewTextBoxColumn, fechaFinalizacionRentaDataGridViewTextBoxColumn, precioPorHoraDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dgvMaquinaria.DataSource = maquinariaBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMaquinaria.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMaquinaria.Location = new Point(-1, 271);
            dgvMaquinaria.Margin = new Padding(3, 2, 3, 2);
            dgvMaquinaria.Name = "dgvMaquinaria";
            dgvMaquinaria.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMaquinaria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMaquinaria.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaquinaria.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMaquinaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaquinaria.Size = new Size(981, 349);
            dgvMaquinaria.TabIndex = 0;
            dgvMaquinaria.CellContentClick += dgvMaquinaria_CellContentClick;
            // 
            // maquinariaIDDataGridViewTextBoxColumn
            // 
            maquinariaIDDataGridViewTextBoxColumn.DataPropertyName = "MaquinariaID";
            maquinariaIDDataGridViewTextBoxColumn.HeaderText = "ID";
            maquinariaIDDataGridViewTextBoxColumn.Name = "maquinariaIDDataGridViewTextBoxColumn";
            maquinariaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorIDDataGridViewTextBoxColumn
            // 
            proveedorIDDataGridViewTextBoxColumn.DataPropertyName = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.HeaderText = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.Name = "proveedorIDDataGridViewTextBoxColumn";
            proveedorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMaquinariaDataGridViewTextBoxColumn
            // 
            nombreMaquinariaDataGridViewTextBoxColumn.DataPropertyName = "NombreMaquinaria";
            nombreMaquinariaDataGridViewTextBoxColumn.HeaderText = "Nombre de Maquinaria";
            nombreMaquinariaDataGridViewTextBoxColumn.Name = "nombreMaquinariaDataGridViewTextBoxColumn";
            nombreMaquinariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioRentaDataGridViewTextBoxColumn
            // 
            fechaInicioRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaInicioRenta";
            fechaInicioRentaDataGridViewTextBoxColumn.HeaderText = "Fecha de Renta";
            fechaInicioRentaDataGridViewTextBoxColumn.Name = "fechaInicioRentaDataGridViewTextBoxColumn";
            fechaInicioRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalizacionRentaDataGridViewTextBoxColumn
            // 
            fechaFinalizacionRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaFinalizacionRenta";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion de Renta";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.Name = "fechaFinalizacionRentaDataGridViewTextBoxColumn";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioPorHoraDataGridViewTextBoxColumn
            // 
            precioPorHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecioPorHora";
            precioPorHoraDataGridViewTextBoxColumn.HeaderText = "Precio por Hora";
            precioPorHoraDataGridViewTextBoxColumn.Name = "precioPorHoraDataGridViewTextBoxColumn";
            precioPorHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maquinariaBindingSource
            // 
            maquinariaBindingSource.DataSource = typeof(SharedModels.Maquinaria);
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(114, 109);
            cbProveedorID.Margin = new Padding(3, 2, 3, 2);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(133, 23);
            cbProveedorID.TabIndex = 1;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(114, 156);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(131, 23);
            cbEstado.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(352, 114);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(129, 23);
            txtMarca.TabIndex = 3;
            // 
            // dtpFechaInicioRenta
            // 
            dtpFechaInicioRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioRenta.Format = DateTimePickerFormat.Short;
            dtpFechaInicioRenta.Location = new Point(661, 67);
            dtpFechaInicioRenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicioRenta.Name = "dtpFechaInicioRenta";
            dtpFechaInicioRenta.Size = new Size(134, 26);
            dtpFechaInicioRenta.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(352, 156);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(129, 23);
            txtModelo.TabIndex = 5;
            // 
            // txtPrecioPorHora
            // 
            txtPrecioPorHora.Location = new Point(352, 193);
            txtPrecioPorHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioPorHora.Name = "txtPrecioPorHora";
            txtPrecioPorHora.Size = new Size(129, 23);
            txtPrecioPorHora.TabIndex = 6;
            // 
            // txtNombreMaquinaria
            // 
            txtNombreMaquinaria.Location = new Point(352, 73);
            txtNombreMaquinaria.Margin = new Padding(3, 2, 3, 2);
            txtNombreMaquinaria.Name = "txtNombreMaquinaria";
            txtNombreMaquinaria.Size = new Size(129, 23);
            txtNombreMaquinaria.TabIndex = 7;
            // 
            // dtpFechaFinalizacionRenta
            // 
            dtpFechaFinalizacionRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinalizacionRenta.Format = DateTimePickerFormat.Short;
            dtpFechaFinalizacionRenta.Location = new Point(661, 106);
            dtpFechaFinalizacionRenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFinalizacionRenta.Name = "dtpFechaFinalizacionRenta";
            dtpFechaFinalizacionRenta.Size = new Size(134, 26);
            dtpFechaFinalizacionRenta.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(841, 141);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 47);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SeaGreen;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(841, 200);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 47);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(841, 80);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 52);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(661, 156);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1, 109);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 13;
            label1.Text = "MaquinariaID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-1, 154);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 14;
            label2.Text = "ProveedorID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(266, 71);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 15;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(279, 114);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 16;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(269, 154);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 17;
            label5.Text = "Modelo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(266, 191);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 18;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(521, 66);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 19;
            label7.Text = "Fecha Inicial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(511, 106);
            label8.Name = "label8";
            label8.Size = new Size(138, 21);
            label8.TabIndex = 20;
            label8.Text = "Fecha Finalizacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(521, 149);
            label9.Name = "label9";
            label9.Size = new Size(121, 21);
            label9.TabIndex = 21;
            label9.Text = "Precio Por Hora:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(450, 352);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 22;
            label10.Text = "Fecha Inicial:";
            // 
            // MaquinariaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(980, 721);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaFinalizacionRenta);
            Controls.Add(txtNombreMaquinaria);
            Controls.Add(txtPrecioPorHora);
            Controls.Add(txtModelo);
            Controls.Add(dtpFechaInicioRenta);
            Controls.Add(txtMarca);
            Controls.Add(cbEstado);
            Controls.Add(cbProveedorID);
            Controls.Add(dgvMaquinaria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MaquinariaForm";
            Text = "Maquinaria";
            Load += MaquinariaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaquinaria;
        private ComboBox cbProveedorID;
        private ComboBox cbEstado;
        private TextBox txtMarca;
        private DateTimePicker dtpFechaInicioRenta;
        private TextBox txtModelo;
        private TextBox txtPrecioPorHora;
        private TextBox txtNombreMaquinaria;
        private DateTimePicker dtpFechaFinalizacionRenta;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private BindingSource maquinariaBindingSource;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn maquinariaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreMaquinariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioRentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinalizacionRentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioPorHoraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private Label label10;
    }
}