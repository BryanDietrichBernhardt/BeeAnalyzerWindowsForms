using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeAnalyzer
{
    public partial class frmCaixas : Form
    {
        public frmCaixas()
        {
            InitializeComponent();

            listViewCaixas.View = View.Details;
            listViewCaixas.LabelEdit = true;
            listViewCaixas.AllowColumnReorder = true;
            listViewCaixas.FullRowSelect = true;
            listViewCaixas.GridLines = true;

            listViewCaixas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewCaixas.Columns.Add("Espécie", 150, HorizontalAlignment.Left);
            listViewCaixas.Columns.Add("Matriz", 150, HorizontalAlignment.Left);
            listViewCaixas.Columns.Add("Data Nasc.", 150, HorizontalAlignment.Left); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
