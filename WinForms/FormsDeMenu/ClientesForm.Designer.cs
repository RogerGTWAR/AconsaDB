﻿namespace WinForms
{
    partial class ClientesForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            clienteIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            panelSubContenedor = new Panel();
            label8 = new Label();
            txtCiudad = new TextBox();
            label7 = new Label();
            txtClienteID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtPais = new TextBox();
            txtDireccion = new TextBox();
            txtCargoContacto = new TextBox();
            txtNombreContacto = new TextBox();
            txtNombreEmpresa = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnClientes = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            panelSubContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clienteIDDataGridViewTextBoxColumn, nombreEmpresaDataGridViewTextBoxColumn, nombreContactoDataGridViewTextBoxColumn, cargoContactoDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dgvClientes.DataSource = clienteBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.Dock = DockStyle.Bottom;
            dgvClientes.Location = new Point(0, 298);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(925, 217);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new Padding(0, 10, 20, 0);
            clienteIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            clienteIDDataGridViewTextBoxColumn.HeaderText = "ID";
            clienteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "Nombre de la Empresa";
            nombreEmpresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            nombreEmpresaDataGridViewTextBoxColumn.Width = 140;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre de Contacto";
            nombreContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            nombreContactoDataGridViewTextBoxColumn.Width = 140;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            paisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(SharedModels.Cliente);
            // 
            // panelSubContenedor
            // 
            panelSubContenedor.BackColor = Color.LightSlateGray;
            panelSubContenedor.Controls.Add(label8);
            panelSubContenedor.Controls.Add(txtCiudad);
            panelSubContenedor.Controls.Add(label7);
            panelSubContenedor.Controls.Add(txtClienteID);
            panelSubContenedor.Controls.Add(label6);
            panelSubContenedor.Controls.Add(label5);
            panelSubContenedor.Controls.Add(label4);
            panelSubContenedor.Controls.Add(label3);
            panelSubContenedor.Controls.Add(label2);
            panelSubContenedor.Controls.Add(label1);
            panelSubContenedor.Controls.Add(txtTelefono);
            panelSubContenedor.Controls.Add(txtPais);
            panelSubContenedor.Controls.Add(txtDireccion);
            panelSubContenedor.Controls.Add(txtCargoContacto);
            panelSubContenedor.Controls.Add(txtNombreContacto);
            panelSubContenedor.Controls.Add(txtNombreEmpresa);
            panelSubContenedor.Controls.Add(btnModificar);
            panelSubContenedor.Controls.Add(btnEliminar);
            panelSubContenedor.Controls.Add(btnAgregar);
            panelSubContenedor.Controls.Add(dgvClientes);
            panelSubContenedor.Location = new Point(0, 55);
            panelSubContenedor.Margin = new Padding(3, 2, 3, 2);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(925, 515);
            panelSubContenedor.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(473, 161);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 19;
            label8.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            txtCiudad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCiudad.Location = new Point(550, 161);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(210, 26);
            txtCiudad.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(153, 67);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 17;
            label7.Text = "ID:";
            // 
            // txtClienteID
            // 
            txtClienteID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClienteID.Location = new Point(187, 62);
            txtClienteID.Margin = new Padding(3, 2, 3, 2);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(210, 26);
            txtClienteID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(464, 114);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 15;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(495, 62);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 14;
            label5.Text = "País:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(457, 211);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 210);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 12;
            label3.Text = "Cargo del Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 162);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 11;
            label2.Text = "Nombre de Contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 114);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 10;
            label1.Text = "Nombre de la empresa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(550, 113);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 26);
            txtTelefono.TabIndex = 9;
            // 
            // txtPais
            // 
            txtPais.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPais.Location = new Point(550, 62);
            txtPais.Margin = new Padding(3, 2, 3, 2);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(210, 26);
            txtPais.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(550, 211);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(210, 74);
            txtDireccion.TabIndex = 7;
            // 
            // txtCargoContacto
            // 
            txtCargoContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCargoContacto.Location = new Point(187, 210);
            txtCargoContacto.Margin = new Padding(3, 2, 3, 2);
            txtCargoContacto.Name = "txtCargoContacto";
            txtCargoContacto.Size = new Size(210, 26);
            txtCargoContacto.TabIndex = 6;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreContacto.Location = new Point(187, 161);
            txtNombreContacto.Margin = new Padding(3, 2, 3, 2);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(210, 26);
            txtNombreContacto.TabIndex = 5;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEmpresa.Location = new Point(187, 114);
            txtNombreEmpresa.Margin = new Padding(3, 2, 3, 2);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(210, 26);
            txtNombreEmpresa.TabIndex = 4;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(783, 136);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 46);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(783, 198);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 46);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(783, 78);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 46);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DarkOliveGreen;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.Black;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(0, 8, 18, 0);
            btnClientes.Size = new Size(922, 58);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(922, 568);
            Controls.Add(btnClientes);
            Controls.Add(panelSubContenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientesForm";
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            panelSubContenedor.ResumeLayout(false);
            panelSubContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Panel panelSubContenedor;
        private BindingSource clienteBindingSource;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtNombreEmpresa;
        private Button btnModificar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtPais;
        private TextBox txtDireccion;
        private TextBox txtCargoContacto;
        private TextBox txtNombreContacto;
        private Label label6;
        private Label label7;
        private TextBox txtClienteID;
        private TextBox txtCiudad;
        private Label label8;
        private DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnClientes;
    }
}