namespace WinForms
{
    partial class CategoriasForm
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            txtCategoria = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvCategoria = new DataGridView();
            categoriaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(503, 86);
            txtCategoria.Margin = new Padding(3, 2, 3, 2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(192, 23);
            txtCategoria.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(503, 136);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(192, 63);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(754, 26);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 38);
            btnAgregar.TabIndex = 2;
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
            btnModificar.Location = new Point(754, 164);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 38);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.System;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(754, 97);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 38);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(318, 84);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 6;
            label1.Text = "Nombre de la categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(350, 134);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 7;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(503, 9);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 8;
            label3.Text = "Categorias";
            // 
            // dgvCategoria
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.BackgroundColor = Color.White;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { categoriaIDDataGridViewTextBoxColumn, nombreCategoriaDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dgvCategoria.DataSource = categoriaBindingSource;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvCategoria.DefaultCellStyle = dataGridViewCellStyle13;
            dgvCategoria.Location = new Point(306, 226);
            dgvCategoria.Margin = new Padding(3, 2, 3, 2);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvCategoria.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(548, 319);
            dgvCategoria.TabIndex = 9;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // categoriaIDDataGridViewTextBoxColumn
            // 
            categoriaIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriaID";
            categoriaIDDataGridViewTextBoxColumn.HeaderText = "ID";
            categoriaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoriaIDDataGridViewTextBoxColumn.Name = "categoriaIDDataGridViewTextBoxColumn";
            categoriaIDDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Nombre de la Categoria";
            nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            nombreCategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(SharedModels.Categoria);
            // 
            // CategoriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1146, 548);
            Controls.Add(dgvCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCategoria);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoriasForm";
            Text = "Categorias";
            Load += CategoriasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvCategorias;
        private DataGridView dgvCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource categoriaBindingSource;
        private DataGridViewTextBoxColumn categoriaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}