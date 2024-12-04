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
    public partial class AvaluoDetalleForm : Form
    {
        public AvaluoDetalleForm()
        {
            InitializeComponent();
        }

        private void AvaluoDetalleForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteAvaluoDetalle' Puede moverla o quitarla según sea necesario.
            this.reporteAvaluoDetalleTableAdapter.Fill(this.vistasGrupo2DS.ReporteAvaluoDetalle);

            this.reportViewer1.RefreshReport();
        }
    }
}
