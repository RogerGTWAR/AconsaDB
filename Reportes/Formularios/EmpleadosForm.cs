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
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteEmpleados' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosTableAdapter.Fill(this.vistasGrupo2DS.ReporteEmpleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
