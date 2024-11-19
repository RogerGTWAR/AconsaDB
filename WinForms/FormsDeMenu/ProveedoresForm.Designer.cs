namespace WinForms
{
    partial class ProveedoresForm
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
            panelSubContenedor = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombreContacto = new TextBox();
            txtCargoContacto = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtPais = new TextBox();
            label1 = new Label();
            txtNombreEmpresa = new TextBox();
            dgvProveedores = new DataGridView();
            proveedorBindingSource = new BindingSource(components);
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panelSubContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelSubContenedor
            // 
            panelSubContenedor.Controls.Add(btnEliminar);
            panelSubContenedor.Controls.Add(btnModificar);
            panelSubContenedor.Controls.Add(btnAgregar);
            panelSubContenedor.Controls.Add(label9);
            panelSubContenedor.Controls.Add(label8);
            panelSubContenedor.Controls.Add(label7);
            panelSubContenedor.Controls.Add(label6);
            panelSubContenedor.Controls.Add(label5);
            panelSubContenedor.Controls.Add(label4);
            panelSubContenedor.Controls.Add(label3);
            panelSubContenedor.Controls.Add(label2);
            panelSubContenedor.Controls.Add(txtTelefono);
            panelSubContenedor.Controls.Add(txtCorreo);
            panelSubContenedor.Controls.Add(txtNombreContacto);
            panelSubContenedor.Controls.Add(txtCargoContacto);
            panelSubContenedor.Controls.Add(txtDireccion);
            panelSubContenedor.Controls.Add(txtCiudad);
            panelSubContenedor.Controls.Add(txtPais);
            panelSubContenedor.Controls.Add(label1);
            panelSubContenedor.Controls.Add(txtNombreEmpresa);
            panelSubContenedor.Controls.Add(dgvProveedores);
            panelSubContenedor.Location = new Point(6, 12);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(1199, 595);
            panelSubContenedor.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(954, 302);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 50);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(553, 302);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 50);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(141, 302);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 50);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(490, 9);
            label9.Name = "label9";
            label9.Size = new Size(192, 41);
            label9.TabIndex = 17;
            label9.Text = "Proveedores";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 121);
            label8.Name = "label8";
            label8.Size = new Size(198, 28);
            label8.TabIndex = 16;
            label8.Text = "Nombre de contacto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 180);
            label7.Name = "label7";
            label7.Size = new Size(183, 28);
            label7.TabIndex = 15;
            label7.Text = "Cargo del contacto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 241);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 14;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(775, 59);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 13;
            label5.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(775, 117);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 12;
            label4.Text = "Pais:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(775, 180);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 11;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(775, 241);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 10;
            label2.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(925, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(192, 30);
            txtTelefono.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(925, 239);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(192, 30);
            txtCorreo.TabIndex = 8;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreContacto.Location = new Point(224, 119);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(192, 30);
            txtNombreContacto.TabIndex = 7;
            // 
            // txtCargoContacto
            // 
            txtCargoContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargoContacto.Location = new Point(224, 178);
            txtCargoContacto.Name = "txtCargoContacto";
            txtCargoContacto.Size = new Size(192, 30);
            txtCargoContacto.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(224, 239);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(192, 30);
            txtDireccion.TabIndex = 5;
            // 
            // txtCiudad
            // 
            txtCiudad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCiudad.Location = new Point(925, 61);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(192, 30);
            txtCiudad.TabIndex = 4;
            // 
            // txtPais
            // 
            txtPais.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPais.Location = new Point(925, 119);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(192, 30);
            txtPais.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 2;
            label1.Text = "Nombre de la empresa:";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEmpresa.Location = new Point(224, 61);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(192, 30);
            txtNombreEmpresa.TabIndex = 1;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { proveedorIDDataGridViewTextBoxColumn, nombreEmpresaDataGridViewTextBoxColumn, nombreContactoDataGridViewTextBoxColumn, cargoContactoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn });
            dgvProveedores.DataSource = proveedorBindingSource;
            dgvProveedores.Dock = DockStyle.Bottom;
            dgvProveedores.Location = new Point(0, 367);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1199, 228);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(SharedModels.Proveedor);
            // 
            // proveedorIDDataGridViewTextBoxColumn
            // 
            proveedorIDDataGridViewTextBoxColumn.DataPropertyName = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.HeaderText = "ID";
            proveedorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            proveedorIDDataGridViewTextBoxColumn.Name = "proveedorIDDataGridViewTextBoxColumn";
            proveedorIDDataGridViewTextBoxColumn.ReadOnly = true;
            proveedorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "Nombre de la Empresa";
            nombreEmpresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            nombreEmpresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre de Contacto";
            nombreContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            nombreContactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoContactoDataGridViewTextBoxColumn
            // 
            cargoContactoDataGridViewTextBoxColumn.DataPropertyName = "CargoContacto";
            cargoContactoDataGridViewTextBoxColumn.HeaderText = "Cargo del Contacto";
            cargoContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            cargoContactoDataGridViewTextBoxColumn.Name = "cargoContactoDataGridViewTextBoxColumn";
            cargoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            cargoContactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            ciudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            ciudadDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.MinimumWidth = 6;
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.ReadOnly = true;
            paisDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProveedoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1249, 631);
            Controls.Add(panelSubContenedor);
            Name = "ProveedoresForm";
            Text = "ProveedoresForm";
            Load += ProveedoresForm_Load;
            panelSubContenedor.ResumeLayout(false);
            panelSubContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSubContenedor;
        private DataGridView dgvProveedores;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombreContacto;
        private TextBox txtCargoContacto;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private TextBox txtPais;
        private Label label1;
        private TextBox txtNombreEmpresa;
        private Button btnAgregar;
        private Label label9;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private BindingSource proveedorBindingSource;
    }
}