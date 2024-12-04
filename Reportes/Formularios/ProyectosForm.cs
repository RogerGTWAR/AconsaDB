using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.Formularios
{
    public partial class ProyectosForm : Form
    {
        public ProyectosForm()
        {
            InitializeComponent();
        }

        private void ProyectosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteProyectosYA' Puede moverla o quitarla según sea necesario.
            this.reporteProyectosYATableAdapter.Fill(this.vistasGrupo2DS.ReporteProyectosYA);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteProyectosYA' Puede moverla o quitarla según sea necesario.
            this.reporteProyectosYATableAdapter.Fill(this.vistasGrupo2DS.ReporteProyectosYA);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteProyectosYA' Puede moverla o quitarla según sea necesario.
            this.reporteProyectosYATableAdapter.Fill(this.vistasGrupo2DS.ReporteProyectosYA);

            this.reportViewer1.RefreshReport();
        }
    }
}
