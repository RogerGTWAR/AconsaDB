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
    public partial class EmpleadosProyectosForm : Form
    {
        public EmpleadosProyectosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosProyectosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReporteEmpleadosProyectos' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReporteEmpleadosProyectos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReporteEmpleadosProyectos' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosProyectosTableAdapter.Fill(this.vistasGrupo1DS.ReporteEmpleadosProyectos);

            this.reportViewer1.RefreshReport();
        }
    }
}
