namespace Reportes
{
    partial class EmpleadosProyectosForm
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
            this.reporteEmpleadosProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistasGrupo1DS = new Reportes.VistasGrupo1DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteEmpleadosProyectosTableAdapter = new Reportes.VistasGrupo1DSTableAdapters.ReporteEmpleadosProyectosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosProyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteEmpleadosProyectosBindingSource
            // 
            this.reporteEmpleadosProyectosBindingSource.DataMember = "ReporteEmpleadosProyectos";
            this.reporteEmpleadosProyectosBindingSource.DataSource = this.vistasGrupo1DS;
            // 
            // vistasGrupo1DS
            // 
            this.vistasGrupo1DS.DataSetName = "VistasGrupo1DS";
            this.vistasGrupo1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EmpleadosProyectosReport";
            reportDataSource1.Value = this.reporteEmpleadosProyectosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informes.EmpleadosProyectosReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteEmpleadosProyectosTableAdapter
            // 
            this.reporteEmpleadosProyectosTableAdapter.ClearBeforeFill = true;
            // 
            // EmpleadosProyectosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmpleadosProyectosForm";
            this.Text = "Empleados Proyectos";
            this.Load += new System.EventHandler(this.EmpleadosProyectosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosProyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistasGrupo1DS vistasGrupo1DS;
        private System.Windows.Forms.BindingSource reporteEmpleadosProyectosBindingSource;
        private VistasGrupo1DSTableAdapters.ReporteEmpleadosProyectosTableAdapter reporteEmpleadosProyectosTableAdapter;
    }
}