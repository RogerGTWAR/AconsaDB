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
    public partial class EmpleadosVehiculosForm : Form
    {
        public EmpleadosVehiculosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosVehiculosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReporteEmpleadosVehiculos' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosVehiculosTableAdapter.Fill(this.vistasGrupo1DS.ReporteEmpleadosVehiculos);
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReporteEmpleadosVehiculos' Puede moverla o quitarla según sea necesario.
            this.reporteEmpleadosVehiculosTableAdapter.Fill(this.vistasGrupo1DS.ReporteEmpleadosVehiculos);

            this.reportViewer1.RefreshReport();
        }
    }
}
