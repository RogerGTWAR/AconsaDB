﻿namespace WinForms
{
    partial class MenuProductosForm
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
            btnProductos = new Button();
            btnCategorias = new Button();
            panel1 = new Panel();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.Black;
            btnProductos.Location = new Point(391, 22);
            btnProductos.Margin = new Padding(5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(164, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = Color.Black;
            btnCategorias.Location = new Point(643, 22);
            btnCategorias.Margin = new Padding(5);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(164, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCategorias);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1720, 75);
            panel1.TabIndex = 2;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Beige;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            panelContenedor.ForeColor = Color.Black;
            panelContenedor.Location = new Point(0, 75);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1720, 637);
            panelContenedor.TabIndex = 3;
            // 
            // MenuProductosForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1720, 712);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "MenuProductosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuProductos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnCategorias;
        private Panel panel1;
        private Panel panelContenedor;
    }
}