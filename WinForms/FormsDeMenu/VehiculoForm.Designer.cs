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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnVehiculos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.AutoGenerateColumns = false;
            dgvVehiculo.BackgroundColor = Color.LightGray;
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Columns.AddRange(new DataGridViewColumn[] { vehiculoIDDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, añoDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, tipoDeVehiculoDataGridViewTextBoxColumn, tipoDeCombustibleDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaRegistroDataGridViewTextBoxColumn });
            dgvVehiculo.DataSource = vehiculoBindingSource;
            dgvVehiculo.Location = new Point(16, 322);
            dgvVehiculo.Margin = new Padding(3, 2, 3, 2);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.ReadOnly = true;
            dgvVehiculo.RowHeadersWidth = 51;
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.Size = new Size(1193, 167);
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
            txtMarca.Location = new Point(170, 173);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtTipoDeVehiculo
            // 
            txtTipoDeVehiculo.Location = new Point(501, 173);
            txtTipoDeVehiculo.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeVehiculo.Name = "txtTipoDeVehiculo";
            txtTipoDeVehiculo.Size = new Size(154, 23);
            txtTipoDeVehiculo.TabIndex = 3;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(501, 123);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 23);
            txtPlaca.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(170, 268);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(154, 23);
            txtAño.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(170, 222);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(154, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtTipoDeCombustible
            // 
            txtTipoDeCombustible.Location = new Point(501, 222);
            txtTipoDeCombustible.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeCombustible.Name = "txtTipoDeCombustible";
            txtTipoDeCombustible.Size = new Size(154, 23);
            txtTipoDeCombustible.TabIndex = 8;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(501, 268);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(154, 23);
            cbEstado.TabIndex = 9;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(822, 119);
            dtpFechaRegistro.Margin = new Padding(3, 2, 3, 2);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(126, 26);
            dtpFechaRegistro.TabIndex = 10;
            // 
            // bntAgregar
            // 
            bntAgregar.BackColor = Color.White;
            bntAgregar.FlatAppearance.BorderColor = Color.Black;
            bntAgregar.FlatAppearance.BorderSize = 2;
            bntAgregar.FlatStyle = FlatStyle.Flat;
            bntAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAgregar.ForeColor = Color.Black;
            bntAgregar.Location = new Point(1045, 113);
            bntAgregar.Margin = new Padding(3, 2, 3, 2);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(119, 39);
            bntAgregar.TabIndex = 11;
            bntAgregar.Text = "Agregar";
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(1045, 185);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(119, 39);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1045, 252);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(170, 123);
            cbProveedorID.Margin = new Padding(3, 2, 3, 2);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(154, 23);
            cbProveedorID.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(57, 175);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 39;
            label8.Text = "ProoverdorID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(108, 224);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 38;
            label7.Text = "Marca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(436, 270);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 37;
            label6.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(681, 123);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 35;
            label2.Text = "Fecha de Registro:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 125);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 34;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(339, 224);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 40;
            label3.Text = "Tipo de Combustible:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(368, 171);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 41;
            label4.Text = "Tipo de Vehiculo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(446, 125);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 42;
            label9.Text = "Placa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(98, 270);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 43;
            label10.Text = "Modelo:";
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.DarkOliveGreen;
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehiculos.ForeColor = Color.Black;
            btnVehiculos.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            btnVehiculos.IconColor = Color.White;
            btnVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.Location = new Point(0, 0);
            btnVehiculos.Margin = new Padding(3, 2, 3, 2);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Padding = new Padding(0, 8, 18, 0);
            btnVehiculos.Size = new Size(1208, 58);
            btnVehiculos.TabIndex = 44;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehiculos.UseVisualStyleBackColor = false;
            // 
            // VehiculoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1208, 489);
            Controls.Add(btnVehiculos);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbProveedorID);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(bntAgregar);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(cbEstado);
            Controls.Add(txtTipoDeCombustible);
            Controls.Add(txtModelo);
            Controls.Add(txtAño);
            Controls.Add(txtPlaca);
            Controls.Add(txtTipoDeVehiculo);
            Controls.Add(txtMarca);
            Controls.Add(dgvVehiculo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VehiculoForm";
            Text = "VehiculoForm";
            Load += VehiculoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehiculo;
        private BindingSource vehiculoBindingSource;
        private ComboBox comboBox1;
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
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnVehiculos;
    }
}