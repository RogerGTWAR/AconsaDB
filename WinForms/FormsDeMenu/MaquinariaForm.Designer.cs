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
            dgvMaquinaria = new DataGridView();
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
            maquinariaBindingSource = new BindingSource(components);
            maquinariaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreMaquinariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioRentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinalizacionRentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioPorHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMaquinaria
            // 
            dgvMaquinaria.AutoGenerateColumns = false;
            dgvMaquinaria.BackgroundColor = Color.White;
            dgvMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinaria.Columns.AddRange(new DataGridViewColumn[] { maquinariaIDDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, nombreMaquinariaDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, fechaInicioRentaDataGridViewTextBoxColumn, fechaFinalizacionRentaDataGridViewTextBoxColumn, precioPorHoraDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dgvMaquinaria.DataSource = maquinariaBindingSource;
            dgvMaquinaria.Dock = DockStyle.Bottom;
            dgvMaquinaria.Location = new Point(0, 272);
            dgvMaquinaria.Margin = new Padding(3, 2, 3, 2);
            dgvMaquinaria.Name = "dgvMaquinaria";
            dgvMaquinaria.ReadOnly = true;
            dgvMaquinaria.RowHeadersWidth = 51;
            dgvMaquinaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaquinaria.Size = new Size(966, 297);
            dgvMaquinaria.TabIndex = 0;
            dgvMaquinaria.CellContentClick += dgvMaquinaria_CellContentClick;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(96, 88);
            cbProveedorID.Margin = new Padding(3, 2, 3, 2);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(133, 23);
            cbProveedorID.TabIndex = 1;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(96, 128);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(131, 23);
            cbEstado.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(317, 115);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(129, 23);
            txtMarca.TabIndex = 3;
            // 
            // dtpFechaInicioRenta
            // 
            dtpFechaInicioRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioRenta.Format = DateTimePickerFormat.Short;
            dtpFechaInicioRenta.Location = new Point(567, 112);
            dtpFechaInicioRenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicioRenta.Name = "dtpFechaInicioRenta";
            dtpFechaInicioRenta.Size = new Size(134, 26);
            dtpFechaInicioRenta.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(335, 174);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(129, 23);
            txtModelo.TabIndex = 5;
            // 
            // txtPrecioPorHora
            // 
            txtPrecioPorHora.Location = new Point(335, 219);
            txtPrecioPorHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioPorHora.Name = "txtPrecioPorHora";
            txtPrecioPorHora.Size = new Size(129, 23);
            txtPrecioPorHora.TabIndex = 6;
            // 
            // txtNombreMaquinaria
            // 
            txtNombreMaquinaria.Location = new Point(317, 69);
            txtNombreMaquinaria.Margin = new Padding(3, 2, 3, 2);
            txtNombreMaquinaria.Name = "txtNombreMaquinaria";
            txtNombreMaquinaria.Size = new Size(129, 23);
            txtNombreMaquinaria.TabIndex = 7;
            // 
            // dtpFechaFinalizacionRenta
            // 
            dtpFechaFinalizacionRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinalizacionRenta.Format = DateTimePickerFormat.Short;
            dtpFechaFinalizacionRenta.Location = new Point(567, 160);
            dtpFechaFinalizacionRenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFinalizacionRenta.Name = "dtpFechaFinalizacionRenta";
            dtpFechaFinalizacionRenta.Size = new Size(134, 26);
            dtpFechaFinalizacionRenta.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(811, 88);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 47);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(811, 156);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 47);
            btnModificar.TabIndex = 10;
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
            btnEliminar.Location = new Point(811, 25);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 47);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // maquinariaBindingSource
            // 
            maquinariaBindingSource.DataSource = typeof(SharedModels.Maquinaria);
            // 
            // maquinariaIDDataGridViewTextBoxColumn
            // 
            maquinariaIDDataGridViewTextBoxColumn.DataPropertyName = "MaquinariaID";
            maquinariaIDDataGridViewTextBoxColumn.HeaderText = "MaquinariaID";
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
            nombreMaquinariaDataGridViewTextBoxColumn.HeaderText = "NombreMaquinaria";
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
            fechaInicioRentaDataGridViewTextBoxColumn.HeaderText = "FechaInicioRenta";
            fechaInicioRentaDataGridViewTextBoxColumn.Name = "fechaInicioRentaDataGridViewTextBoxColumn";
            fechaInicioRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalizacionRentaDataGridViewTextBoxColumn
            // 
            fechaFinalizacionRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaFinalizacionRenta";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.HeaderText = "FechaFinalizacionRenta";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.Name = "fechaFinalizacionRentaDataGridViewTextBoxColumn";
            fechaFinalizacionRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioPorHoraDataGridViewTextBoxColumn
            // 
            precioPorHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecioPorHora";
            precioPorHoraDataGridViewTextBoxColumn.HeaderText = "PrecioPorHora";
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
            // panel1
            // 
            panel1.Controls.Add(dgvMaquinaria);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(cbProveedorID);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(dtpFechaFinalizacionRenta);
            panel1.Controls.Add(dtpFechaInicioRenta);
            panel1.Controls.Add(txtNombreMaquinaria);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(txtPrecioPorHora);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 569);
            panel1.TabIndex = 12;
            // 
            // MaquinariaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1195, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MaquinariaForm";
            Text = "MaquinariaForm";
            Load += MaquinariaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinariaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn maquinariaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreMaquinariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioRentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinalizacionRentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioPorHoraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource maquinariaBindingSource;
        private Panel panel1;
    }
}