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
            btnProyectos = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proyectoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btnProyectos);
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
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 562);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 122);
            label8.Name = "label8";
            label8.Size = new Size(161, 21);
            label8.TabIndex = 20;
            label8.Text = "Nombre del proyecto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(90, 183);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 19;
            label7.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(103, 246);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 18;
            label6.Text = "Ubicacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(595, 72);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 17;
            label5.Text = "Presupuesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(535, 250);
            label4.Name = "label4";
            label4.Size = new Size(159, 21);
            label4.TabIndex = 16;
            label4.Text = "Fecha de Finalizacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(635, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 15;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(579, 188);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 14;
            label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 13;
            label1.Text = "Cliente ID:";
            // 
            // txtPresupuestoTotal
            // 
            txtPresupuestoTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPresupuestoTotal.Location = new Point(716, 71);
            txtPresupuestoTotal.Margin = new Padding(3, 2, 3, 2);
            txtPresupuestoTotal.Name = "txtPresupuestoTotal";
            txtPresupuestoTotal.Size = new Size(168, 26);
            txtPresupuestoTotal.TabIndex = 12;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(716, 184);
            dtpFechaInicio.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(124, 26);
            dtpFechaInicio.TabIndex = 11;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(716, 246);
            dtpFechaFin.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(124, 26);
            dtpFechaFin.TabIndex = 10;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(716, 125);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(124, 23);
            cbEstado.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(195, 183);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 43);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProyecto.Location = new Point(195, 122);
            txtNombreProyecto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(168, 26);
            txtNombreProyecto.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacion.Location = new Point(195, 246);
            txtUbicacion.Margin = new Padding(3, 2, 3, 2);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(168, 26);
            txtUbicacion.TabIndex = 6;
            // 
            // cbClienteID
            // 
            cbClienteID.FormattingEnabled = true;
            cbClienteID.Location = new Point(195, 71);
            cbClienteID.Margin = new Padding(3, 2, 3, 2);
            cbClienteID.Name = "cbClienteID";
            cbClienteID.Size = new Size(168, 23);
            cbClienteID.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(952, 68);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 50);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DimGray;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(952, 218);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 50);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DimGray;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(952, 141);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 50);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProyectos
            // 
            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.BackgroundColor = Color.LightGray;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Columns.AddRange(new DataGridViewColumn[] { proyectoIDDataGridViewTextBoxColumn, clienteIDDataGridViewTextBoxColumn, nombreProyectoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, ubicacionDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, presupuestoTotalDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, tiempoTotalDiasDataGridViewTextBoxColumn });
            dgvProyectos.DataSource = proyectoBindingSource;
            dgvProyectos.Dock = DockStyle.Bottom;
            dgvProyectos.Location = new Point(0, 355);
            dgvProyectos.Margin = new Padding(3, 2, 3, 2);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowHeadersWidth = 51;
            dgvProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyectos.Size = new Size(1131, 207);
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
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.DarkOliveGreen;
            btnProyectos.Dock = DockStyle.Top;
            btnProyectos.FlatStyle = FlatStyle.Flat;
            btnProyectos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = Color.Black;
            btnProyectos.IconChar = FontAwesome.Sharp.IconChar.PersonDigging;
            btnProyectos.IconColor = Color.White;
            btnProyectos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProyectos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProyectos.Location = new Point(0, 0);
            btnProyectos.Margin = new Padding(3, 2, 3, 2);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Padding = new Padding(0, 8, 18, 0);
            btnProyectos.Size = new Size(1131, 58);
            btnProyectos.TabIndex = 21;
            btnProyectos.Text = "Proyectos";
            btnProyectos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProyectos.UseVisualStyleBackColor = false;
            // 
            // ProyectosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 56);
            ClientSize = new Size(1131, 560);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private FontAwesome.Sharp.IconButton btnProyectos;
    }
}