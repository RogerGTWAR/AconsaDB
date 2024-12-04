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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistasGrupo1DS.ReporteProductos' Puede moverla o quitarla según sea necesario.
            this.reporteProductosTableAdapter.Fill(this.vistasGrupo1DS.ReporteProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
