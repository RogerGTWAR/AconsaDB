namespace WinForms
{
    partial class RegisterForm
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
            btnCrear = new Button();
            txtUsuario = new TextBox();
            txtEmpleadoID = new TextBox();
            txtContraseña = new TextBox();
            dtpCreacion = new DateTimePicker();
            dtpFechaModificacion = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(831, 489);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(290, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(196, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Location = new Point(405, 249);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(196, 27);
            txtEmpleadoID.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(556, 162);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(196, 27);
            txtContraseña.TabIndex = 3;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(316, 372);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(121, 27);
            dtpCreacion.TabIndex = 4;
            // 
            // dtpFechaModificacion
            // 
            dtpFechaModificacion.Format = DateTimePickerFormat.Short;
            dtpFechaModificacion.Location = new Point(592, 372);
            dtpFechaModificacion.Name = "dtpFechaModificacion";
            dtpFechaModificacion.Size = new Size(121, 27);
            dtpFechaModificacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 131);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 6;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(603, 131);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(290, 341);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Creacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(569, 341);
            label4.Name = "label4";
            label4.Size = new Size(208, 28);
            label4.TabIndex = 9;
            label4.Text = "Fecha de Modificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(431, 218);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 10;
            label5.Text = "Empleado ID";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1025, 638);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFechaModificacion);
            Controls.Add(dtpCreacion);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmpleadoID);
            Controls.Add(txtUsuario);
            Controls.Add(btnCrear);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private TextBox txtUsuario;
        private TextBox txtEmpleadoID;
        private TextBox txtContraseña;
        private DateTimePicker dtpCreacion;
        private DateTimePicker dtpFechaModificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}