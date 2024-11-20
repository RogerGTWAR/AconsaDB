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
            panel1 = new Panel();
            panelTitleBar = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtxUserName
            // 
            txtxUserName.Location = new Point(249, 28);
            txtxUserName.Margin = new Padding(3, 2, 3, 2);
            txtxUserName.Name = "txtxUserName";
            txtxUserName.Size = new Size(177, 23);
            txtxUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(249, 83);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 30, 68);
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(31, 30, 68);
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 80);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(46, 59, 104);
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(59, 138);
            btnCargar.Margin = new Padding(3, 2, 3, 2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(129, 38);
            btnCargar.TabIndex = 5;
            btnCargar.Text = "Acceder";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(46, 59, 104);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(267, 138);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(129, 38);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtxUserName);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 140);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 221);
            panel1.TabIndex = 7;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(499, 38);
            panelTitleBar.TabIndex = 8;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinForms.Properties.Resources.Aconsa;
            pictureBox1.Location = new Point(169, 42);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 38, 70);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 377);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 11);
            panel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(499, 388);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtxUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnCargar;
        private Button btnCrear;
        private Panel panel1;
        private Panel panelTitleBar;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}