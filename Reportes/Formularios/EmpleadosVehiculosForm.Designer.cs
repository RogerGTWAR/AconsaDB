namespace Reportes
{
    partial class EmpleadosVehiculosForm
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
            this.reporteEmpleadosVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistasGrupo1DS = new Reportes.VistasGrupo1DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteEmpleadosVehiculosTableAdapter = new Reportes.VistasGrupo1DSTableAdapters.ReporteEmpleadosVehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteEmpleadosVehiculosBindingSource
            // 
            this.reporteEmpleadosVehiculosBindingSource.DataMember = "ReporteEmpleadosVehiculos";
            this.reporteEmpleadosVehiculosBindingSource.DataSource = this.vistasGrupo1DS;
            // 
            // vistasGrupo1DS
            // 
            this.vistasGrupo1DS.DataSetName = "VistasGrupo1DS";
            this.vistasGrupo1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EmpleadosVehiculosReport";
            reportDataSource1.Value = this.reporteEmpleadosVehiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Informes.EmpleadoVehiculosReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteEmpleadosVehiculosTableAdapter
            // 
            this.reporteEmpleadosVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // EmpleadosVehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmpleadosVehiculosForm";
            this.Text = "EmpleadosVehiculos";
            this.Load += new System.EventHandler(this.EmpleadosVehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasGrupo1DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistasGrupo1DS vistasGrupo1DS;
        private System.Windows.Forms.BindingSource reporteEmpleadosVehiculosBindingSource;
        private VistasGrupo1DSTableAdapters.ReporteEmpleadosVehiculosTableAdapter reporteEmpleadosVehiculosTableAdapter;
    }
}