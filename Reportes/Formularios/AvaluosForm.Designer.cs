namespace Reportes
{
    partial class AvaluosForm
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
            this.reportProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistasGrupo1DS = new Reportes.VistasGrupo1DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportProyectosTableAdapter = new Reportes.VistasGrupo1DSTableAdapters.ReportProyectosTableAdapter();
            this.ReporteProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportProyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportProyectosBindingSource
            // 
            this.reportProyectosBindingSource.DataMember = "ReportProyectos";
            this.reportProyectosBindingSource.DataSource = this.vistasGrupo1DS;
            // 
            // vistasGrupo1DS
            // 
            this.vistasGrupo1DS.DataSetName = "VistasGrupo1DS";
            this.vistasGrupo1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProyectoReport";
            reportDataSource1.Value = this.reportProyectosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informes.ReporteAvaluo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(946, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportProyectosTableAdapter
            // 
            this.reportProyectosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProductosBindingSource
            // 
            this.ReporteProductosBindingSource.DataMember = "ReporteProductos";
            this.ReporteProductosBindingSource.DataSource = this.vistasGrupo1DS;
            // 
            // AvaluosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AvaluosForm";
            this.Text = "Avaluo";
            this.Load += new System.EventHandler(this.ProyectoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportProyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistasGrupo1DS vistasGrupo1DS;
        private System.Windows.Forms.BindingSource reportProyectosBindingSource;
        private VistasGrupo1DSTableAdapters.ReportProyectosTableAdapter reportProyectosTableAdapter;
        private System.Windows.Forms.BindingSource ReporteProductosBindingSource;
    }
}