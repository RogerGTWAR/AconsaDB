﻿namespace WinForms
{
    partial class AvaluoForm
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
            cbProyectoID = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            txtDescripcion = new TextBox();
            txtMontoEjecutado = new TextBox();
            dgvAvaluo = new DataGridView();
            avaluoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proyectoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoEjecutadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tiempoTotalDiasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avaluoBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAvaluo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avaluoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbProyectoID
            // 
            cbProyectoID.FormattingEnabled = true;
            cbProyectoID.Location = new Point(162, 56);
            cbProyectoID.Margin = new Padding(3, 2, 3, 2);
            cbProyectoID.Name = "cbProyectoID";
            cbProyectoID.Size = new Size(176, 23);
            cbProyectoID.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(562, 53);
            dtpFechaInicio.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(126, 26);
            dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(562, 91);
            dtpFechaFin.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(126, 26);
            dtpFechaFin.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(162, 94);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtMontoEjecutado
            // 
            txtMontoEjecutado.Location = new Point(162, 135);
            txtMontoEjecutado.Margin = new Padding(3, 2, 3, 2);
            txtMontoEjecutado.Name = "txtMontoEjecutado";
            txtMontoEjecutado.Size = new Size(176, 23);
            txtMontoEjecutado.TabIndex = 4;
            // 
            // dgvAvaluo
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvaluo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvaluo.AutoGenerateColumns = false;
            dgvAvaluo.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAvaluo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAvaluo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvaluo.Columns.AddRange(new DataGridViewColumn[] { avaluoIDDataGridViewTextBoxColumn, proyectoIDDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, montoEjecutadoDataGridViewTextBoxColumn, fechaInicioDataGridViewTextBoxColumn, fechaFinDataGridViewTextBoxColumn, tiempoTotalDiasDataGridViewTextBoxColumn });
            dgvAvaluo.DataSource = avaluoBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAvaluo.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAvaluo.Location = new Point(0, 226);
            dgvAvaluo.Margin = new Padding(3, 2, 3, 2);
            dgvAvaluo.Name = "dgvAvaluo";
            dgvAvaluo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAvaluo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAvaluo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAvaluo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAvaluo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvaluo.Size = new Size(940, 248);
            dgvAvaluo.TabIndex = 5;
            dgvAvaluo.CellContentClick += dgvAvaluo_CellContentClick;
            // 
            // avaluoIDDataGridViewTextBoxColumn
            // 
            avaluoIDDataGridViewTextBoxColumn.DataPropertyName = "AvaluoID";
            avaluoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            avaluoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            avaluoIDDataGridViewTextBoxColumn.Name = "avaluoIDDataGridViewTextBoxColumn";
            avaluoIDDataGridViewTextBoxColumn.ReadOnly = true;
            avaluoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // proyectoIDDataGridViewTextBoxColumn
            // 
            proyectoIDDataGridViewTextBoxColumn.DataPropertyName = "ProyectoID";
            proyectoIDDataGridViewTextBoxColumn.HeaderText = "Proyecto ID";
            proyectoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            proyectoIDDataGridViewTextBoxColumn.Name = "proyectoIDDataGridViewTextBoxColumn";
            proyectoIDDataGridViewTextBoxColumn.ReadOnly = true;
            proyectoIDDataGridViewTextBoxColumn.Width = 125;
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
            // montoEjecutadoDataGridViewTextBoxColumn
            // 
            montoEjecutadoDataGridViewTextBoxColumn.DataPropertyName = "MontoEjecutado";
            montoEjecutadoDataGridViewTextBoxColumn.HeaderText = "Monto Ejecutado";
            montoEjecutadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            montoEjecutadoDataGridViewTextBoxColumn.Name = "montoEjecutadoDataGridViewTextBoxColumn";
            montoEjecutadoDataGridViewTextBoxColumn.ReadOnly = true;
            montoEjecutadoDataGridViewTextBoxColumn.Width = 125;
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
            // tiempoTotalDiasDataGridViewTextBoxColumn
            // 
            tiempoTotalDiasDataGridViewTextBoxColumn.DataPropertyName = "TiempoTotalDias";
            tiempoTotalDiasDataGridViewTextBoxColumn.HeaderText = "Tiempo Total de Dias";
            tiempoTotalDiasDataGridViewTextBoxColumn.MinimumWidth = 6;
            tiempoTotalDiasDataGridViewTextBoxColumn.Name = "tiempoTotalDiasDataGridViewTextBoxColumn";
            tiempoTotalDiasDataGridViewTextBoxColumn.ReadOnly = true;
            tiempoTotalDiasDataGridViewTextBoxColumn.Width = 125;
            // 
            // avaluoBindingSource
            // 
            avaluoBindingSource.DataSource = typeof(SharedModels.Avaluo);
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(828, 35);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 46);
            btnAgregar.TabIndex = 6;
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
            btnModificar.Location = new Point(828, 150);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 46);
            btnModificar.TabIndex = 7;
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
            btnEliminar.Location = new Point(828, 98);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 56);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 9;
            label1.Text = "Proyecto ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(438, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 10;
            label2.Text = "Fecha Fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(438, 54);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 11;
            label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 132);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 12;
            label4.Text = "Monto Ejecutado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 93);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 13;
            label5.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(438, 9);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 14;
            label6.Text = "Avaluos";
            // 
            // AvaluoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(949, 447);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvAvaluo);
            Controls.Add(txtMontoEjecutado);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cbProyectoID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AvaluoForm";
            Text = "Avaluo";
            Load += AvaluoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvaluo).EndInit();
            ((System.ComponentModel.ISupportInitialize)avaluoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProyectoID;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private TextBox txtDescripcion;
        private TextBox txtMontoEjecutado;
        private DataGridView dgvAvaluo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private DataGridViewTextBoxColumn avaluoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoEjecutadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tiempoTotalDiasDataGridViewTextBoxColumn;
        private BindingSource avaluoBindingSource;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}