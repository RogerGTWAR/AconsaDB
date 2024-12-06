namespace Reportes.Formularios
{
    partial class EmpleadosForm
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
            this.reporteEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistasGrupo2DS = new Reportes.VistasGrupo2DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteEmpleadosTableAdapter = new Reportes.VistasGrupo2DSTableAdapters.ReporteEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo2DS)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteEmpleadosBindingSource
            // 
            this.reporteEmpleadosBindingSource.DataMember = "ReporteEmpleados";
            this.reporteEmpleadosBindingSource.DataSource = this.vistasGrupo2DS;
            // 
            // vistasGrupo2DS
            // 
            this.vistasGrupo2DS.DataSetName = "VistasGrupo2DS";
            this.vistasGrupo2DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EmpleadosReport";
            reportDataSource1.Value = this.reporteEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informes.EmpleadosReporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteEmpleadosTableAdapter
            // 
            this.reporteEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmpleadosForm";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo2DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistasGrupo2DS vistasGrupo2DS;
        private System.Windows.Forms.BindingSource reporteEmpleadosBindingSource;
        private VistasGrupo2DSTableAdapters.ReporteEmpleadosTableAdapter reporteEmpleadosTableAdapter;
    }
}