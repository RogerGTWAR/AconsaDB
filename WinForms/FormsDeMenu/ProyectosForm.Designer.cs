namespace WinForms
{
    partial class ProyectosForm
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
            panel1 = new Panel();
            txtPresupuestoTotal = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            cbEstado = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombreProyecto = new TextBox();
            txtUbicacion = new TextBox();
            cbClienteID = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvProyectos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPresupuestoTotal);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNombreProyecto);
            panel1.Controls.Add(txtUbicacion);
            panel1.Controls.Add(cbClienteID);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(dgvProyectos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 633);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtPresupuestoTotal
            // 
            txtPresupuestoTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPresupuestoTotal.Location = new Point(223, 310);
            txtPresupuestoTotal.Name = "txtPresupuestoTotal";
            txtPresupuestoTotal.Size = new Size(191, 30);
            txtPresupuestoTotal.TabIndex = 12;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(977, 123);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(141, 30);
            dtpFechaInicio.TabIndex = 11;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(977, 183);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(141, 30);
            dtpFechaFin.TabIndex = 10;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(977, 55);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(173, 28);
            cbEstado.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(223, 186);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(191, 30);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProyecto.Location = new Point(223, 122);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(191, 30);
            txtNombreProyecto.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacion.Location = new Point(223, 249);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(191, 30);
            txtUbicacion.TabIndex = 6;
            // 
            // cbClienteID
            // 
            cbClienteID.FormattingEnabled = true;
            cbClienteID.Location = new Point(223, 55);
            cbClienteID.Name = "cbClienteID";
            cbClienteID.Size = new Size(191, 28);
            cbClienteID.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(61, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 66);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(592, 361);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 66);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1009, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 66);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProyectos
            // 
            dgvProyectos.BackgroundColor = Color.White;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Dock = DockStyle.Bottom;
            dgvProyectos.Location = new Point(0, 445);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowHeadersWidth = 51;
            dgvProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyectos.Size = new Size(1185, 188);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 13;
            label1.Text = "Cliente ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(785, 124);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 14;
            label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(826, 55);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 15;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(759, 186);
            label4.Name = "label4";
            label4.Size = new Size(200, 28);
            label4.TabIndex = 16;
            label4.Text = "Fecha de Finalizacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 17;
            label5.Text = "Presupuesto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 18;
            label6.Text = "Ubicacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 188);
            label7.Name = "label7";
            label7.Size = new Size(118, 28);
            label7.TabIndex = 19;
            label7.Text = "Descripcion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 124);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 20;
            label8.Text = "Nombre del proyecto:";
            // 
            // ProyectosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1198, 648);
            Controls.Add(panel1);
            Name = "ProyectosForm";
            Text = "ProyectosForm";
            Load += ProyectosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvProyectos;
        private ComboBox cbClienteID;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private ComboBox cbEstado;
        private TextBox txtDescripcion;
        private TextBox txtNombreProyecto;
        private TextBox txtUbicacion;
        private TextBox txtPresupuestoTotal;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}