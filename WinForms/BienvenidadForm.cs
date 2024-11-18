using Gestor_Api.Repository.IRepository;
using SharedModels;
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
    public partial class BienvenidadForm : Form
    {
        private readonly string _usuario; 
        private readonly ApiClient _apiClient;

        public BienvenidadForm(string usuario)
        {
            _apiClient = new ApiClient();
            InitializeComponent();
            _usuario = usuario; 

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                timer2.Stop();
                this.Close();

            }
        }
        private void BienvenidadForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _usuario;
            this.Opacity = 1.0;
            timer1.Start();
        }
    }
}
