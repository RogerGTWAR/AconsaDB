using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MenuProductosForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly ApiClient _apiClient;

        public MenuProductosForm( HttpClient _httpClient)
        {
            InitializeComponent();
            
            _apiClient = new ApiClient();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosForm frm = new ProductosForm(_httpClient);
            AbrirFormPanel(frm);
        }

        private void AbrirFormPanel(ProductosForm frm)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frm);
            panelContenedor.Tag = frm;
            frm.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CategoriasForm frm = new CategoriasForm(_httpClient);
            AbrirFormPanel(frm);
        }

        private void AbrirFormPanel(CategoriasForm frm)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frm);
            panelContenedor.Tag = frm;
            frm.Show();
        }
    }
}
