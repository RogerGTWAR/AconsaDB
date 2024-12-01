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
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).BeginInit();
            SuspendLayout();
            // 
            // dgvMaquinaria
            // 
            dgvMaquinaria.BackgroundColor = Color.White;
            dgvMaquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquinaria.Location = new Point(138, 338);
            dgvMaquinaria.Name = "dgvMaquinaria";
            dgvMaquinaria.ReadOnly = true;
            dgvMaquinaria.RowHeadersWidth = 51;
            dgvMaquinaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaquinaria.Size = new Size(533, 278);
            dgvMaquinaria.TabIndex = 0;
            dgvMaquinaria.CellContentClick += dgvMaquinaria_CellContentClick;
            // 
            // cbProveedorID
            // 
            cbProveedorID.FormattingEnabled = true;
            cbProveedorID.Location = new Point(138, 90);
            cbProveedorID.Name = "cbProveedorID";
            cbProveedorID.Size = new Size(151, 28);
            cbProveedorID.TabIndex = 1;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(138, 144);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(149, 28);
            cbEstado.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(391, 127);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(147, 27);
            txtMarca.TabIndex = 3;
            // 
            // dtpFechaInicioRenta
            // 
            dtpFechaInicioRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicioRenta.Format = DateTimePickerFormat.Short;
            dtpFechaInicioRenta.Location = new Point(677, 122);
            dtpFechaInicioRenta.Name = "dtpFechaInicioRenta";
            dtpFechaInicioRenta.Size = new Size(153, 30);
            dtpFechaInicioRenta.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(412, 206);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(147, 27);
            txtModelo.TabIndex = 5;
            // 
            // txtPrecioPorHora
            // 
            txtPrecioPorHora.Location = new Point(412, 265);
            txtPrecioPorHora.Name = "txtPrecioPorHora";
            txtPrecioPorHora.Size = new Size(147, 27);
            txtPrecioPorHora.TabIndex = 6;
            // 
            // txtNombreMaquinaria
            // 
            txtNombreMaquinaria.Location = new Point(391, 65);
            txtNombreMaquinaria.Name = "txtNombreMaquinaria";
            txtNombreMaquinaria.Size = new Size(147, 27);
            txtNombreMaquinaria.TabIndex = 7;
            // 
            // dtpFechaFinalizacionRenta
            // 
            dtpFechaFinalizacionRenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFinalizacionRenta.Format = DateTimePickerFormat.Short;
            dtpFechaFinalizacionRenta.Location = new Point(677, 187);
            dtpFechaFinalizacionRenta.Name = "dtpFechaFinalizacionRenta";
            dtpFechaFinalizacionRenta.Size = new Size(153, 30);
            dtpFechaFinalizacionRenta.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(905, 127);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 63);
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
            btnModificar.Location = new Point(905, 217);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(135, 63);
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
            btnEliminar.Location = new Point(905, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 63);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // MaquinariaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1077, 639);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaFinalizacionRenta);
            Controls.Add(txtNombreMaquinaria);
            Controls.Add(txtPrecioPorHora);
            Controls.Add(txtModelo);
            Controls.Add(dtpFechaInicioRenta);
            Controls.Add(txtMarca);
            Controls.Add(cbEstado);
            Controls.Add(cbProveedorID);
            Controls.Add(dgvMaquinaria);
            Name = "MaquinariaForm";
            Text = "MaquinariaForm";
            Load += MaquinariaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquinaria).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}