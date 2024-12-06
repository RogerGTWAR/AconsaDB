namespace WinForms
{
    partial class VehiculoForm
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
            dgvVehiculo = new DataGridView();
            vehiculoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            añoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDeVehiculoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDeCombustibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaRegistroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehiculoBindingSource = new BindingSource(components);
            txtMarca = new TextBox();
            txtTipoDeVehiculo = new TextBox();
            txtPlaca = new TextBox();
            txtAño = new TextBox();
            txtModelo = new TextBox();
            txtTipoDeCombustible = new TextBox();
            cbEstado = new ComboBox();
            dtpFechaRegistro = new DateTimePicker();
            bntAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            cbProveedorID = new ComboBox();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehiculo
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVehiculo.AutoGenerateColumns = false;
            dgvVehiculo.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Columns.AddRange(new DataGridViewColumn[] { vehiculoIDDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, añoDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, tipoDeVehiculoDataGridViewTextBoxColumn, tipoDeCombustibleDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaRegistroDataGridViewTextBoxColumn });
            dgvVehiculo.DataSource = vehiculoBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVehiculo.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVehiculo.Location = new Point(0, 296);
            dgvVehiculo.Margin = new Padding(3, 2, 3, 2);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVehiculo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.Size = new Size(1121, 317);
            dgvVehiculo.TabIndex = 0;
            dgvVehiculo.CellContentClick += dgvVehiculo_CellContentClick;
            // 
            // vehiculoIDDataGridViewTextBoxColumn
            // 
            vehiculoIDDataGridViewTextBoxColumn.DataPropertyName = "VehiculoID";
            vehiculoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            vehiculoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            vehiculoIDDataGridViewTextBoxColumn.Name = "vehiculoIDDataGridViewTextBoxColumn";
            vehiculoIDDataGridViewTextBoxColumn.ReadOnly = true;
            vehiculoIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // proveedorIDDataGridViewTextBoxColumn
            // 
            proveedorIDDataGridViewTextBoxColumn.DataPropertyName = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.HeaderText = "ID del Proveedor";
            proveedorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            proveedorIDDataGridViewTextBoxColumn.Name = "proveedorIDDataGridViewTextBoxColumn";
            proveedorIDDataGridViewTextBoxColumn.ReadOnly = true;
            proveedorIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            modeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            añoDataGridViewTextBoxColumn.HeaderText = "Año";
            añoDataGridViewTextBoxColumn.MinimumWidth = 6;
            añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            añoDataGridViewTextBoxColumn.ReadOnly = true;
            añoDataGridViewTextBoxColumn.Width = 125;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            placaDataGridViewTextBoxColumn.MinimumWidth = 6;
            placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            placaDataGridViewTextBoxColumn.ReadOnly = true;
            placaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDeVehiculoDataGridViewTextBoxColumn
            // 
            tipoDeVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoDeVehiculo";
            tipoDeVehiculoDataGridViewTextBoxColumn.HeaderText = "Tipo de Vehiculo";
            tipoDeVehiculoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDeVehiculoDataGridViewTextBoxColumn.Name = "tipoDeVehiculoDataGridViewTextBoxColumn";
            tipoDeVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDeVehiculoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDeCombustibleDataGridViewTextBoxColumn
            // 
            tipoDeCombustibleDataGridViewTextBoxColumn.DataPropertyName = "TipoDeCombustible";
            tipoDeCombustibleDataGridViewTextBoxColumn.HeaderText = "Tipo de Combustible";
            tipoDeCombustibleDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDeCombustibleDataGridViewTextBoxColumn.Name = "tipoDeCombustibleDataGridViewTextBoxColumn";
            tipoDeCombustibleDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDeCombustibleDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            fechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            fechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            fechaRegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehiculoBindingSource
            // 
            vehiculoBindingSource.DataSource = typeof(SharedModels.Vehiculo);
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(102, 112);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtTipoDeVehiculo
            // 
            txtTipoDeVehiculo.Location = new Point(431, 110);
            txtTipoDeVehiculo.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeVehiculo.Name = "txtTipoDeVehiculo";
            txtTipoDeVehiculo.Size = new Size(154, 23);
            txtTipoDeVehiculo.TabIndex = 3;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(431, 60);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 23);
            txtPlaca.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(102, 207);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(154, 23);
            txtAño.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(102, 161);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(154, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtTipoDeCombustible
            // 
            txtTipoDeCombustible.Location = new Point(431, 161);
            txtTipoDeCombustible.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeCombustible.Name = "txtTipoDeCombustible";
            txtTipoDeCombustible.Size = new Size(154, 23);
            txtTipoDeCombustible.TabIndex = 8;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(431, 205);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(154, 23);
            cbEstado.TabIndex = 9;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(747, 59);
            dtpFechaRegistro.Margin = new Padding(3, 2, 3, 2);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(126, 26);
            dtpFechaRegistro.TabIndex = 10;
            // 
            // bntAgregar
            // 
            bntAgregar.FlatAppearance.BorderSize = 0;
            bntAgregar.FlatStyle = FlatStyle.Flat;
            bntAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAgregar.ForeColor = Color.Black;
            bntAgregar.Location = new Point(928, 83);
            bntAgregar.Margin = new Padding(3, 2, 3, 2);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(97, 39);
            bntAgregar.TabIndex = 11;
            bntAgregar.Text = "Agregar";
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(923, 205);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 39);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(928, 142);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(102, 62);
            cbProveedorID.Margin = new Padding(3, 2, 3, 2);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(154, 23);
            cbProveedorID.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbProveedorID);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(txtAño);
            panel1.Controls.Add(bntAgregar);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(dtpFechaRegistro);
            panel1.Controls.Add(dgvVehiculo);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(txtPlaca);
            panel1.Controls.Add(txtTipoDeCombustible);
            panel1.Controls.Add(txtTipoDeVehiculo);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 613);
            panel1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(480, 11);
            label10.Name = "label10";
            label10.Size = new Size(122, 32);
            label10.TabIndex = 24;
            label10.Text = "Vehiculos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(605, 60);
            label9.Name = "label9";
            label9.Size = new Size(136, 21);
            label9.TabIndex = 23;
            label9.Text = "Fecha de Registro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(275, 163);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 22;
            label8.Text = "Tipo de combustible";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(319, 207);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 21;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(14, 112);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 20;
            label6.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 163);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 19;
            label5.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 207);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 18;
            label4.Text = "Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(329, 60);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 17;
            label3.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(283, 112);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 16;
            label2.Text = "Tipo de vehiculo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 15;
            label1.Text = "Proveedor";
            // 
            // VehiculoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1131, 633);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VehiculoForm";
            Text = "Vehiculos";
            Load += VehiculoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVehiculo;
        private BindingSource vehiculoBindingSource;
        private TextBox txtMarca;
        private TextBox txtTipoDeVehiculo;
        private TextBox txtPlaca;
        private TextBox txtAño;
        private TextBox txtModelo;
        private TextBox txtTipoDeCombustible;
        private ComboBox cbEstado;
        private DateTimePicker dtpFechaRegistro;
        private Button bntAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox cbProveedorID;
        private DataGridViewTextBoxColumn vehiculoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeVehiculoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDeCombustibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}