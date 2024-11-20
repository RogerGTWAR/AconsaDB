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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            proyectoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProyectoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ubicacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presupuestoTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tiempoTotalDiasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
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
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 693);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(555, 12);
            label9.Name = "label9";
            label9.Size = new Size(133, 37);
            label9.TabIndex = 21;
            label9.Text = "Proyecto";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 163);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 20;
            label8.Text = "Nombre del proyecto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 245);
            label7.Name = "label7";
            label7.Size = new Size(118, 28);
            label7.TabIndex = 19;
            label7.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 329);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 18;
            label6.Text = "Ubicacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(611, 101);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 17;
            label5.Text = "Presupuesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(611, 333);
            label4.Name = "label4";
            label4.Size = new Size(200, 28);
            label4.TabIndex = 16;
            label4.Text = "Fecha de Finalizacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(611, 169);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 15;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(611, 245);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 14;
            label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 92);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 13;
            label1.Text = "Cliente ID:";
            // 
            // txtPresupuestoTotal
            // 
            txtPresupuestoTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPresupuestoTotal.Location = new Point(818, 95);
            txtPresupuestoTotal.Name = "txtPresupuestoTotal";
            txtPresupuestoTotal.Size = new Size(191, 30);
            txtPresupuestoTotal.TabIndex = 12;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(818, 245);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(141, 30);
            dtpFechaInicio.TabIndex = 11;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(818, 328);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(141, 30);
            dtpFechaFin.TabIndex = 10;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(818, 167);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(141, 28);
            cbEstado.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(223, 244);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(191, 56);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProyecto.Location = new Point(223, 163);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(191, 30);
            txtNombreProyecto.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacion.Location = new Point(223, 328);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(191, 30);
            txtUbicacion.TabIndex = 6;
            // 
            // cbClienteID
            // 
            cbClienteID.FormattingEnabled = true;
            cbClienteID.Location = new Point(223, 95);
            cbClienteID.Name = "cbClienteID";
            cbClienteID.Size = new Size(191, 28);
            cbClienteID.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1088, 91);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 67);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1088, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 67);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1088, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 67);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProyectos
            // 
            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.BackgroundColor = Color.White;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Columns.AddRange(new DataGridViewColumn[] { proyectoIDDataGridViewTextBoxColumn, clienteIDDataGridViewTextBoxColumn, nombreProyectoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, ubicacionDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, presupuestoTotalDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, tiempoTotalDiasDataGridViewTextBoxColumn });
            dgvProyectos.DataSource = proyectoBindingSource;
            dgvProyectos.Dock = DockStyle.Bottom;
            dgvProyectos.Location = new Point(0, 417);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowHeadersWidth = 51;
            dgvProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyectos.Size = new Size(1269, 276);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // proyectoIDDataGridViewTextBoxColumn
            // 
            proyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            proyectoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            proyectoIDDataGridViewTextBoxColumn.ReadOnly = true;
            proyectoIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            clienteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreProyectoDataGridViewTextBoxColumn
            // 
            nombreProyectoDataGridViewTextBoxColumn.DataPropertyName = "NombreProyecto";
            nombreProyectoDataGridViewTextBoxColumn.HeaderText = "Nombre del Proyecto";
            nombreProyectoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreProyectoDataGridViewTextBoxColumn.Name = "nombreProyectoDataGridViewTextBoxColumn";
            nombreProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            nombreProyectoDataGridViewTextBoxColumn.Width = 125;
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
            // ubicacionDataGridViewTextBoxColumn
            // 
            ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            ubicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            ubicacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            fechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion";
            fechaFinDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            fechaFinDataGridViewTextBoxColumn.Width = 125;
            // 
            // presupuestoTotalDataGridViewTextBoxColumn
            // 
            presupuestoTotalDataGridViewTextBoxColumn.DataPropertyName = "PresupuestoTotal";
            presupuestoTotalDataGridViewTextBoxColumn.HeaderText = "Presupuesto Total";
            presupuestoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            presupuestoTotalDataGridViewTextBoxColumn.Name = "presupuestoTotalDataGridViewTextBoxColumn";
            presupuestoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            presupuestoTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tiempoTotalDiasDataGridViewTextBoxColumn
            // 
            tiempoTotalDiasDataGridViewTextBoxColumn.DataPropertyName = "TiempoTotalDias";
            tiempoTotalDiasDataGridViewTextBoxColumn.HeaderText = "Tiempo Total de Dias";
            tiempoTotalDiasDataGridViewTextBoxColumn.MinimumWidth = 6;
            tiempoTotalDiasDataGridViewTextBoxColumn.Name = "tiempoTotalDiasDataGridViewTextBoxColumn";
            tiempoTotalDiasDataGridViewTextBoxColumn.ReadOnly = true;
            tiempoTotalDiasDataGridViewTextBoxColumn.Width = 125;
            // 
            // proyectoBindingSource
            // 
            proyectoBindingSource.DataSource = typeof(SharedModels.Proyecto);
            // 
            // ProyectosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1293, 747);
            Controls.Add(panel1);
            Name = "ProyectosForm";
            Text = "ProyectosForm";
            Load += ProyectosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).EndInit();
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
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProyectoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn presupuestoTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tiempoTotalDiasDataGridViewTextBoxColumn;
        private BindingSource proyectoBindingSource;
        private Label label9;
    }
}