using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ProductosForm : Form
    {
        private readonly ApiClient _apiClient;
        public ProductosForm(HttpClient _httpClient)
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }
    }
}
