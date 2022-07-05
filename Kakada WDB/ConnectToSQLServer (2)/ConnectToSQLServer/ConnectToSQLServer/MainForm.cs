using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToSQLServer
{
    public partial class frnMainForm : Form
    {
        public frnMainForm()
        {
            InitializeComponent();
        }

        private void btnViewPeople_Click(object sender, EventArgs e)
        {
            new frmViewPeople().ShowDialog();
            this.Hide();
        }

        private void btnLuckyDraw_Click(object sender, EventArgs e)
        {
            new frmLuckyDraw().ShowDialog();
            this.Dispose();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new frmProduct().ShowDialog();
            this.Close();
        }

        private void btnOderProduct_Click(object sender, EventArgs e)
        {
            new frmProductOrder().Show();
            this.Hide();
        }
    }
}
