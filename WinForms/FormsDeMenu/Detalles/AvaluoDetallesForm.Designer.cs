namespace WinForms.FormsDeMenu.Detalles
{
    partial class AvaluoDetallesForm
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
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            cbAvaluoID = new ComboBox();
            txtPrecioUnitario = new TextBox();
            txtCantidad = new TextBox();
            cbProductoID = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dgvAvaluoDetalle = new DataGridView();
            avaluoDetalleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avaluoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avaluoDetalleBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvAvaluoDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avaluoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 153);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 26;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 25;
            label4.Text = "Producto ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 22;
            label1.Text = "Avaluo ID:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(518, 139);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 21;
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
            btnModificar.Location = new Point(518, 189);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 20;
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
            btnAgregar.Location = new Point(400, 139);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(103, 155);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 76);
            txtDescripcion.TabIndex = 17;
            // 
            // cbAvaluoID
            // 
            cbAvaluoID.FormattingEnabled = true;
            cbAvaluoID.Location = new Point(103, 51);
            cbAvaluoID.Margin = new Padding(3, 2, 3, 2);
            cbAvaluoID.Name = "cbAvaluoID";
            cbAvaluoID.Size = new Size(176, 23);
            cbAvaluoID.TabIndex = 14;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(405, 94);
            txtPrecioUnitario.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(230, 23);
            txtPrecioUnitario.TabIndex = 27;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(405, 51);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(230, 23);
            txtCantidad.TabIndex = 28;
            // 
            // cbProductoID
            // 
            cbProductoID.FormattingEnabled = true;
            cbProductoID.Location = new Point(103, 103);
            cbProductoID.Margin = new Padding(3, 2, 3, 2);
            cbProductoID.Name = "cbProductoID";
            cbProductoID.Size = new Size(176, 23);
            cbProductoID.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(324, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 30;
            label2.Text = "Cantidad:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(287, 96);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 31;
            label3.Text = "Precio Unitario:";
            // 
            // dgvAvaluoDetalle
            // 
            dgvAvaluoDetalle.AutoGenerateColumns = false;
            dgvAvaluoDetalle.BackgroundColor = Color.White;
            dgvAvaluoDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvaluoDetalle.Columns.AddRange(new DataGridViewColumn[] { avaluoDetalleIDDataGridViewTextBoxColumn, avaluoIDDataGridViewTextBoxColumn, productoIDDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn });
            dgvAvaluoDetalle.DataSource = avaluoDetalleBindingSource;
            dgvAvaluoDetalle.Location = new Point(0, 273);
            dgvAvaluoDetalle.Name = "dgvAvaluoDetalle";
            dgvAvaluoDetalle.ReadOnly = true;
            dgvAvaluoDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvaluoDetalle.Size = new Size(653, 175);
            dgvAvaluoDetalle.TabIndex = 32;
            dgvAvaluoDetalle.CellContentClick += dgvAvaluoDetalle_CellContentClick;
            // 
            // avaluoDetalleIDDataGridViewTextBoxColumn
            // 
            avaluoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Avaluo_DetalleID";
            avaluoDetalleIDDataGridViewTextBoxColumn.HeaderText = "Avaluo_DetalleID";
            avaluoDetalleIDDataGridViewTextBoxColumn.Name = "avaluoDetalleIDDataGridViewTextBoxColumn";
            avaluoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avaluoIDDataGridViewTextBoxColumn
            // 
            avaluoIDDataGridViewTextBoxColumn.DataPropertyName = "AvaluoID";
            avaluoIDDataGridViewTextBoxColumn.HeaderText = "AvaluoID";
            avaluoIDDataGridViewTextBoxColumn.Name = "avaluoIDDataGridViewTextBoxColumn";
            avaluoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoIDDataGridViewTextBoxColumn
            // 
            productoIDDataGridViewTextBoxColumn.DataPropertyName = "ProductoID";
            productoIDDataGridViewTextBoxColumn.HeaderText = "ProductoID";
            productoIDDataGridViewTextBoxColumn.Name = "productoIDDataGridViewTextBoxColumn";
            productoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avaluoDetalleBindingSource
            // 
            avaluoDetalleBindingSource.DataSource = typeof(SharedModels.AvaluoDetalle);
            // 
            // AvaluoDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(642, 443);
            Controls.Add(dgvAvaluoDetalle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbProductoID);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(cbAvaluoID);
            Name = "AvaluoDetallesForm";
            Text = "AvaluoDetalles";
            Load += AvaluoDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvaluoDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)avaluoDetalleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private ComboBox cbAvaluoID;
        private TextBox txtPrecioUnitario;
        private TextBox txtCantidad;
        private ComboBox cbProductoID;
        private Label label2;
        private Label label3;
        private DataGridView dgvAvaluoDetalle;
        private DataGridViewTextBoxColumn avaluoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avaluoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private BindingSource avaluoDetalleBindingSource;
    }
}