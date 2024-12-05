namespace WinForms
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            clienteIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoContactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direcciónDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paísDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teléfonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            panelSubContenedor = new Panel();
            label9 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            panelSubContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clienteIDDataGridViewTextBoxColumn, nombreEmpresaDataGridViewTextBoxColumn, nombreContactoDataGridViewTextBoxColumn, cargoContactoDataGridViewTextBoxColumn, direcciónDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, paísDataGridViewTextBoxColumn, teléfonoDataGridViewTextBoxColumn });
            dgvClientes.DataSource = clienteBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Dock = DockStyle.Bottom;
            dgvClientes.Location = new Point(0, 319);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1060, 217);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            clienteIDDataGridViewTextBoxColumn.HeaderText = "ID";
            clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "Nombre de la Empresa";
            nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre de Contacto";
            nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoContactoDataGridViewTextBoxColumn
            // 
            cargoContactoDataGridViewTextBoxColumn.DataPropertyName = "CargoContacto";
            cargoContactoDataGridViewTextBoxColumn.HeaderText = "Cargo del Contacto";
            cargoContactoDataGridViewTextBoxColumn.Name = "cargoContactoDataGridViewTextBoxColumn";
            cargoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            direcciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección";
            direcciónDataGridViewTextBoxColumn.HeaderText = "Dirección";
            direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            direcciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paísDataGridViewTextBoxColumn
            // 
            paísDataGridViewTextBoxColumn.DataPropertyName = "País";
            paísDataGridViewTextBoxColumn.HeaderText = "País";
            paísDataGridViewTextBoxColumn.Name = "paísDataGridViewTextBoxColumn";
            paísDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            teléfonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(SharedModels.Cliente);
            // 
            // panelSubContenedor
            // 
            panelSubContenedor.Controls.Add(label9);
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
            panelSubContenedor.Location = new Point(2, 4);
            panelSubContenedor.Margin = new Padding(3, 2, 3, 2);
            panelSubContenedor.Name = "panelSubContenedor";
            panelSubContenedor.Size = new Size(1060, 536);
            panelSubContenedor.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(410, 5);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 20;
            label9.Text = "Clientes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(457, 161);
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
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 67);
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
            label6.ForeColor = Color.White;
            label6.Location = new Point(457, 114);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 15;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(457, 62);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 14;
            label5.Text = "País:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
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
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 211);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 12;
            label3.Text = "Cargo del Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 161);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 11;
            label2.Text = "Nombre de Contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
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
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(927, 125);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 46);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(927, 187);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 46);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(927, 67);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 46);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1061, 447);
            Controls.Add(panelSubContenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientesForm";
            Text = "Clientes";
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
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private Label label9;
        private DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paísDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
    }
}