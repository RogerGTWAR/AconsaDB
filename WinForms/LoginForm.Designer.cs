namespace WindowsForm
{
    partial class LoginForm
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
            txtxUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCargar = new Button();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtxUserName
            // 
            txtxUserName.Location = new Point(348, 73);
            txtxUserName.Name = "txtxUserName";
            txtxUserName.Size = new Size(202, 27);
            txtxUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(202, 27);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(49, 66, 82);
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(130, 73);
            label1.Name = "label1";
            label1.Size = new Size(94, 27);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(49, 66, 82);
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 163);
            label2.Name = "label2";
            label2.Size = new Size(142, 27);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.SeaGreen;
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.Black;
            btnCargar.Location = new Point(249, 251);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(147, 50);
            btnCargar.TabIndex = 5;
            btnCargar.Text = "Acceder";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.SeaGreen;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.Black;
            btnCrear.Location = new Point(459, 251);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(147, 50);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(704, 367);
            Controls.Add(btnCrear);
            Controls.Add(btnCargar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtxUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnCargar;
        private Button btnCrear;
    }
}