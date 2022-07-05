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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            cboAuthetication.SelectedIndex = 0;
        }

        private void cboAuthetication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboAuthetication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string serverName = txtServername.Text;
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            string dbName = "db3";
            try
            {
                if (cboAuthetication.SelectedIndex == 0)
                {
                    DataConnection.ConnectDB(serverName, dbName);
                }
                else
                {
                    DataConnection.ConnectDB(serverName, dbName, userName, passWord);
                }
                this.Hide();
                new frnMainForm().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
