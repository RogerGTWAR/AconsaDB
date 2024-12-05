namespace WinForms
{
    partial class ProductosForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            txtNombreProducto = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            cbProveedorID = new ComboBox();
            cbCategoriaID = new ComboBox();
            txtCantidadEnStock = new TextBox();
            txtUnidadDeMedida = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioUnitario = new TextBox();
            dgvProductos = new DataGridView();
            productoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unidadDeMedidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadEnStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(899, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 47);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(196, 80);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(239, 26);
            txtNombreProducto.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(899, 214);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 52);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(899, 146);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(117, 48);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(196, 125);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(169, 27);
            cbProveedorID.TabIndex = 5;
            // 
            // cbCategoriaID
            // 
            cbCategoriaID.FormattingEnabled = true;
            cbCategoriaID.Location = new Point(192, 183);
            cbCategoriaID.Name = "cbCategoriaID";
            cbCategoriaID.Size = new Size(169, 27);
            cbCategoriaID.TabIndex = 6;
            // 
            // txtCantidadEnStock
            // 
            txtCantidadEnStock.Location = new Point(586, 185);
            txtCantidadEnStock.Name = "txtCantidadEnStock";
            txtCantidadEnStock.Size = new Size(147, 26);
            txtCantidadEnStock.TabIndex = 7;
            // 
            // txtUnidadDeMedida
            // 
            txtUnidadDeMedida.Location = new Point(192, 247);
            txtUnidadDeMedida.Name = "txtUnidadDeMedida";
            txtUnidadDeMedida.Size = new Size(239, 26);
            txtUnidadDeMedida.TabIndex = 8;
            txtUnidadDeMedida.TextChanged += txtUnidadDeMedida_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(586, 80);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(239, 72);
            txtDescripcion.TabIndex = 9;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(586, 247);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(147, 26);
            txtPrecioUnitario.TabIndex = 10;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { productoIDDataGridViewTextBoxColumn, nombreProductoDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, categoriaIDDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, unidadDeMedidaDataGridViewTextBoxColumn, cantidadEnStockDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn });
            dgvProductos.DataSource = productoBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.Location = new Point(0, 315);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1053, 307);
            dgvProductos.TabIndex = 11;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick_1;
            // 
            // productoIDDataGridViewTextBoxColumn
            // 
            productoIDDataGridViewTextBoxColumn.DataPropertyName = "ProductoID";
            productoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            productoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productoIDDataGridViewTextBoxColumn.Name = "productoIDDataGridViewTextBoxColumn";
            productoIDDataGridViewTextBoxColumn.ReadOnly = true;
            productoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            nombreProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveedorIDDataGridViewTextBoxColumn
            // 
            proveedorIDDataGridViewTextBoxColumn.DataPropertyName = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.HeaderText = "ProveedorID";
            proveedorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            proveedorIDDataGridViewTextBoxColumn.Name = "proveedorIDDataGridViewTextBoxColumn";
            proveedorIDDataGridViewTextBoxColumn.ReadOnly = true;
            proveedorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaIDDataGridViewTextBoxColumn
            // 
            categoriaIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriaID";
            categoriaIDDataGridViewTextBoxColumn.HeaderText = "CategoriaID";
            categoriaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoriaIDDataGridViewTextBoxColumn.Name = "categoriaIDDataGridViewTextBoxColumn";
            categoriaIDDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadDeMedidaDataGridViewTextBoxColumn
            // 
            unidadDeMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadDeMedida";
            unidadDeMedidaDataGridViewTextBoxColumn.HeaderText = "UnidadDeMedida";
            unidadDeMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            unidadDeMedidaDataGridViewTextBoxColumn.Name = "unidadDeMedidaDataGridViewTextBoxColumn";
            unidadDeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            unidadDeMedidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadEnStockDataGridViewTextBoxColumn
            // 
            cantidadEnStockDataGridViewTextBoxColumn.DataPropertyName = "CantidadEnStock";
            cantidadEnStockDataGridViewTextBoxColumn.HeaderText = "CantidadEnStock";
            cantidadEnStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadEnStockDataGridViewTextBoxColumn.Name = "cantidadEnStockDataGridViewTextBoxColumn";
            cantidadEnStockDataGridViewTextBoxColumn.ReadOnly = true;
            cantidadEnStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            precioUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(SharedModels.Producto);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 12;
            label1.Text = "Nombre del Producto:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(498, 83);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 13;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(61, 247);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 14;
            label3.Text = "Unidad de Medida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(457, 193);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 15;
            label4.Text = "Cantidad en Stock:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(478, 250);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 16;
            label5.Text = "Precio Unitario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(104, 128);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 17;
            label6.Text = "ProveedorID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(104, 183);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 18;
            label7.Text = "CategoriaID:";
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.DarkOliveGreen;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.Black;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProductos.IconColor = Color.White;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(0, 8, 18, 0);
            btnProductos.Size = new Size(1053, 58);
            btnProductos.TabIndex = 19;
            btnProductos.Text = "Productos";
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1053, 622);
            Controls.Add(btnProductos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtUnidadDeMedida);
            Controls.Add(txtCantidadEnStock);
            Controls.Add(cbCategoriaID);
            Controls.Add(cbProveedorID);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombreProducto);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 10.2F);
            ForeColor = Color.Black;
            Name = "ProductosForm";
            Text = "ProductosForm";
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNombreProducto;
        private Button btnEliminar;
        private Button btnModificar;
        private ComboBox cbProveedorID;
        private ComboBox cbCategoriaID;
        private TextBox txtCantidadEnStock;
        private TextBox txtUnidadDeMedida;
        private TextBox txtDescripcion;
        private TextBox txtPrecioUnitario;
        private DataGridView dgvProductos;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn productoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadDeMedidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadEnStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnProductos;
    }
}