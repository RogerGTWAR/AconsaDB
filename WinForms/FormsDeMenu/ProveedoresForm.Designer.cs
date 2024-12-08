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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            proveedorBindingSource = new BindingSource(components);
            dgvProveedores = new DataGridView();
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            txtNombreEmpresa = new TextBox();
            label1 = new Label();
            txtPais = new TextBox();
            txtCiudad = new TextBox();
            txtDireccion = new TextBox();
            txtCargoContacto = new TextBox();
            txtNombreContacto = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            panelSubContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panelSubContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(SharedModels.Proveedor);
            // 
            // dgvProveedores
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { proveedorIDDataGridViewTextBoxColumn, nombreEmpresaDataGridViewTextBoxColumn, nombreContactoDataGridViewTextBoxColumn, cargoContactoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn });
            dgvProveedores.DataSource = proveedorBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedores.Dock = DockStyle.Bottom;
            dgvProveedores.Location = new Point(0, 296);
            dgvProveedores.Margin = new Padding(3, 2, 3, 2);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1054, 317);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
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
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEmpresa.Location = new Point(196, 56);
            txtNombreEmpresa.Margin = new Padding(3, 2, 3, 2);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(168, 26);
            txtNombreEmpresa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 56);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre de la empresa:";
            // 
            // txtPais
            // 
            txtPais.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPais.Location = new Point(685, 107);
            txtPais.Margin = new Padding(3, 2, 3, 2);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(168, 26);
            txtPais.TabIndex = 3;
            // 
            // txtCiudad
            // 
            txtCiudad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCiudad.Location = new Point(685, 55);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(168, 26);
            txtCiudad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(196, 209);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(216, 51);
            txtDireccion.TabIndex = 5;
            // 
            // txtCargoContacto
            // 
            txtCargoContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargoContacto.Location = new Point(196, 160);
            txtCargoContacto.Margin = new Padding(3, 2, 3, 2);
            txtCargoContacto.Name = "txtCargoContacto";
            txtCargoContacto.Size = new Size(168, 26);
            txtCargoContacto.TabIndex = 6;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreContacto.Location = new Point(196, 107);
            txtNombreContacto.Margin = new Padding(3, 2, 3, 2);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(168, 26);
            txtNombreContacto.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(685, 213);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(168, 26);
            txtCorreo.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(685, 160);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(168, 26);
            txtTelefono.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(583, 210);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 10;
            label2.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(583, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 11;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(583, 112);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 12;
            label4.Text = "Pais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(583, 56);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 13;
            label5.Text = "Ciudad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(44, 210);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 14;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(7, 161);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 15;
            label7.Text = "Cargo del contacto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(7, 108);
            label8.Name = "label8";
            label8.Size = new Size(155, 21);
            label8.TabIndex = 16;
            label8.Text = "Nombre de contacto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(429, 7);
            label9.Name = "label9";
            label9.Size = new Size(157, 32);
            label9.TabIndex = 17;
            label9.Text = "Proveedores";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(926, 81);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 38);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.System;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(926, 213);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 38);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.System;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(926, 148);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 38);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            panelSubContenedor.Location = new Point(5, 9);
            panelSubContenedor.Margin = new Padding(3, 2, 3, 2);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(1054, 613);
            panelSubContenedor.TabIndex = 0;
            // 
            // ProveedoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1131, 633);
            Controls.Add(panelSubContenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveedoresForm";
            Text = "Proveedores";
            Load += ProveedoresForm_Load;
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panelSubContenedor.ResumeLayout(false);
            panelSubContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource proveedorBindingSource;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private TextBox txtNombreEmpresa;
        private Label label1;
        private TextBox txtPais;
        private TextBox txtCiudad;
        private TextBox txtDireccion;
        private TextBox txtCargoContacto;
        private TextBox txtNombreContacto;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Panel panelSubContenedor;
    }
}