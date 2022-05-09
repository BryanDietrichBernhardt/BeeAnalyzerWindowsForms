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
    public partial class frmAbelhas : Form
    {
        public frmAbelhas()
        {
            InitializeComponent();

            listView_abelhas.View = View.Details;
            listView_abelhas.LabelEdit = true;
            listView_abelhas.AllowColumnReorder = true;
            listView_abelhas.FullRowSelect = true;
            listView_abelhas.GridLines = true;

            listView_abelhas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView_abelhas.Columns.Add("Espécie", 150, HorizontalAlignment.Left);
            listView_abelhas.Columns.Add("Região", 150, HorizontalAlignment.Left);
            listView_abelhas.Columns.Add("Nome científico", 150, HorizontalAlignment.Left);
        }

        private void textBox_especie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
