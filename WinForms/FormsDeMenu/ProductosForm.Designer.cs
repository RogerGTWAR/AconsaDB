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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(883, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 56);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(195, 45);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(213, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(883, 196);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 56);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(870, 124);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 56);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(582, 153);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(151, 28);
            cbProveedorID.TabIndex = 5;
            // 
            // cbCategoriaID
            // 
            cbCategoriaID.FormattingEnabled = true;
            cbCategoriaID.Location = new Point(582, 219);
            cbCategoriaID.Name = "cbCategoriaID";
            cbCategoriaID.Size = new Size(151, 28);
            cbCategoriaID.TabIndex = 6;
            // 
            // txtCantidadEnStock
            // 
            txtCantidadEnStock.Location = new Point(538, 45);
            txtCantidadEnStock.Name = "txtCantidadEnStock";
            txtCantidadEnStock.Size = new Size(213, 27);
            txtCantidadEnStock.TabIndex = 7;
            // 
            // txtUnidadDeMedida
            // 
            txtUnidadDeMedida.Location = new Point(195, 153);
            txtUnidadDeMedida.Name = "txtUnidadDeMedida";
            txtUnidadDeMedida.Size = new Size(213, 27);
            txtUnidadDeMedida.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(195, 99);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(213, 27);
            txtDescripcion.TabIndex = 9;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(538, 106);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(213, 27);
            txtPrecioUnitario.TabIndex = 10;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { productoIDDataGridViewTextBoxColumn, nombreProductoDataGridViewTextBoxColumn, proveedorIDDataGridViewTextBoxColumn, categoriaIDDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, unidadDeMedidaDataGridViewTextBoxColumn, cantidadEnStockDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn });
            dgvProductos.DataSource = productoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.Location = new Point(0, 275);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1018, 266);
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
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1018, 541);
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
    }
}