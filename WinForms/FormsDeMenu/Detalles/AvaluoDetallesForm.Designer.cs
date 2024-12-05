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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            avaluoDetalleBindingSource = new BindingSource(components);
            avaluoDetalleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avaluoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAvaluoDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avaluoDetalleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 26;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 25;
            label4.Text = "Producto ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 22;
            label1.Text = "Avaluo ID:";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(714, 87);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 21;
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
            btnModificar.Location = new Point(714, 153);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(714, 26);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 155);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 76);
            txtDescripcion.TabIndex = 17;
            // 
            // cbAvaluoID
            // 
            cbAvaluoID.FormattingEnabled = true;
            cbAvaluoID.Location = new Point(164, 49);
            cbAvaluoID.Margin = new Padding(3, 2, 3, 2);
            cbAvaluoID.Name = "cbAvaluoID";
            cbAvaluoID.Size = new Size(176, 23);
            cbAvaluoID.TabIndex = 14;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(500, 92);
            txtPrecioUnitario.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(176, 23);
            txtPrecioUnitario.TabIndex = 27;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(500, 49);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(176, 23);
            txtCantidad.TabIndex = 28;
            // 
            // cbProductoID
            // 
            cbProductoID.FormattingEnabled = true;
            cbProductoID.Location = new Point(164, 103);
            cbProductoID.Margin = new Padding(3, 2, 3, 2);
            cbProductoID.Name = "cbProductoID";
            cbProductoID.Size = new Size(176, 23);
            cbProductoID.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(379, 51);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 30;
            label2.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(379, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 31;
            label3.Text = "Precio Unitario:";
            // 
            // dgvAvaluoDetalle
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvaluoDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvaluoDetalle.AutoGenerateColumns = false;
            dgvAvaluoDetalle.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAvaluoDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAvaluoDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvaluoDetalle.Columns.AddRange(new DataGridViewColumn[] { avaluoDetalleIDDataGridViewTextBoxColumn, avaluoIDDataGridViewTextBoxColumn, productoIDDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn });
            dgvAvaluoDetalle.DataSource = avaluoDetalleBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAvaluoDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAvaluoDetalle.Location = new Point(12, 275);
            dgvAvaluoDetalle.Name = "dgvAvaluoDetalle";
            dgvAvaluoDetalle.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAvaluoDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvaluoDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAvaluoDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvaluoDetalle.Size = new Size(664, 150);
            dgvAvaluoDetalle.TabIndex = 32;
            dgvAvaluoDetalle.CellContentClick += dgvAvaluoDetalle_CellContentClick;
            // 
            // avaluoDetalleBindingSource
            // 
            avaluoDetalleBindingSource.DataSource = typeof(SharedModels.AvaluoDetalle);
            // 
            // avaluoDetalleIDDataGridViewTextBoxColumn
            // 
            avaluoDetalleIDDataGridViewTextBoxColumn.DataPropertyName = "Avaluo_DetalleID";
            avaluoDetalleIDDataGridViewTextBoxColumn.HeaderText = "ID";
            avaluoDetalleIDDataGridViewTextBoxColumn.Name = "avaluoDetalleIDDataGridViewTextBoxColumn";
            avaluoDetalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            avaluoDetalleIDDataGridViewTextBoxColumn.Width = 80;
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
            precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AvaluoDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(854, 450);
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
        private BindingSource avaluoDetalleBindingSource;
        private DataGridViewTextBoxColumn avaluoDetalleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avaluoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
    }
}