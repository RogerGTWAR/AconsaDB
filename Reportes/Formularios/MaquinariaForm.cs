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
    public partial class MaquinariaForm : Form
    {
        public MaquinariaForm()
        {
            InitializeComponent();
        }

        private void MaquinariaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo2DS.ReporteMaquinariasUtilizada' Puede moverla o quitarla según sea necesario.
            this.reporteMaquinariasUtilizadaTableAdapter.Fill(this.vistasGrupo2DS.ReporteMaquinariasUtilizada);

            this.reportViewer1.RefreshReport();
        }
    }
}
