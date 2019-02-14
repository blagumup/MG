using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_WindowsForms
{
    public partial class MerchGod : Form
    {
        public MerchGod()
        {
            InitializeComponent();
        }

        private void viewOllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm Pl = new ProductListForm();
            Pl.Show();
        }
    }
}
