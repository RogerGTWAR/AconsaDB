﻿namespace Reportes.Formularios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vistasGrupo2DS = new Reportes.VistasGrupo2DS();
            this.reporteProyectosYABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteProyectosYATableAdapter = new Reportes.VistasGrupo2DSTableAdapters.ReporteProyectosYATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo2DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProyectosYABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProyectosVerdaderosReport";
            reportDataSource1.Value = this.reporteProyectosYABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informes.ProyectosVerdadero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vistasGrupo2DS
            // 
            this.vistasGrupo2DS.DataSetName = "VistasGrupo2DS";
            this.vistasGrupo2DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteProyectosYABindingSource
            // 
            this.reporteProyectosYABindingSource.DataMember = "ReporteProyectosYA";
            this.reporteProyectosYABindingSource.DataSource = this.vistasGrupo2DS;
            // 
            // reporteProyectosYATableAdapter
            // 
            this.reporteProyectosYATableAdapter.ClearBeforeFill = true;
            // 
            // ProyectosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProyectosForm";
            this.Text = "ProyectosFrom";
            this.Load += new System.EventHandler(this.ProyectosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo2DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProyectosYABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistasGrupo2DS vistasGrupo2DS;
        private System.Windows.Forms.BindingSource reporteProyectosYABindingSource;
        private VistasGrupo2DSTableAdapters.ReporteProyectosYATableAdapter reporteProyectosYATableAdapter;
    }
}