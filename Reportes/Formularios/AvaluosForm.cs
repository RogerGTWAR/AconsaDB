using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class AvaluosForm : Form
    {
        public AvaluosForm()
        {
            InitializeComponent();
        }

        private void ProyectoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReportProyectos' Puede moverla o quitarla según sea necesario.
            this.reportProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReportProyectos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReportProyectos' Puede moverla o quitarla según sea necesario.
            this.reportProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReportProyectos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReportProyectos' Puede moverla o quitarla según sea necesario.
            this.reportProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReportProyectos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReportProyectos' Puede moverla o quitarla según sea necesario.
            this.reportProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReportProyectos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReportProyectos' Puede moverla o quitarla según sea necesario.
            this.reportProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReportProyectos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
