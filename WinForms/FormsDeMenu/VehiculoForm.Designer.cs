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
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.AutoGenerateColumns = false;
            dgvVehiculo.BackgroundColor = Color.White;
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Columns.AddRange(new DataGridViewColumn[] { vehiculoIDDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, añoDataGridViewTextBoxColumn, placaDataGridViewTextBoxColumn, tipoDeVehiculoDataGridViewTextBoxColumn, tipoDeCombustibleDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, fechaRegistroDataGridViewTextBoxColumn });
            dgvVehiculo.DataSource = vehiculoBindingSource;
            dgvVehiculo.Dock = DockStyle.Bottom;
            dgvVehiculo.Location = new Point(0, 258);
            dgvVehiculo.Margin = new Padding(3, 2, 3, 2);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.ReadOnly = true;
            dgvVehiculo.RowHeadersWidth = 51;
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.Size = new Size(1065, 304);
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
            txtMarca.Location = new Point(83, 98);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtTipoDeVehiculo
            // 
            txtTipoDeVehiculo.Location = new Point(475, 88);
            txtTipoDeVehiculo.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeVehiculo.Name = "txtTipoDeVehiculo";
            txtTipoDeVehiculo.Size = new Size(154, 23);
            txtTipoDeVehiculo.TabIndex = 3;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(475, 38);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 23);
            txtPlaca.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(83, 193);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(154, 23);
            txtAño.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(83, 147);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(154, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtTipoDeCombustible
            // 
            txtTipoDeCombustible.Location = new Point(475, 137);
            txtTipoDeCombustible.Margin = new Padding(3, 2, 3, 2);
            txtTipoDeCombustible.Name = "txtTipoDeCombustible";
            txtTipoDeCombustible.Size = new Size(154, 23);
            txtTipoDeCombustible.TabIndex = 8;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(475, 183);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(154, 23);
            cbEstado.TabIndex = 9;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(674, 34);
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
            bntAgregar.ForeColor = Color.White;
            bntAgregar.Location = new Point(943, 38);
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
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(943, 105);
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
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(943, 175);
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
            cbProveedorID.Location = new Point(83, 48);
            cbProveedorID.Margin = new Padding(3, 2, 3, 2);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(154, 23);
            cbProveedorID.TabIndex = 14;
            // 
            // VehiculoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1065, 562);
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
    }
}