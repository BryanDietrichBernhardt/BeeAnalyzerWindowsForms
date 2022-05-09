using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BeeAnalyzer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_caixas_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenCaixas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCaixas()
        {
            Application.Run(new frmCaixas());
        }

        private void btn_abelhas_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenAbelhas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAbelhas()
        {
            Application.Run(new frmAbelhas());
        }
    }
}
