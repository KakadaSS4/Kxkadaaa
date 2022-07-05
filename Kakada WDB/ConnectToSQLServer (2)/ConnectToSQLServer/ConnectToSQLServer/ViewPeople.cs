using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToSQLServer
{
    public partial class frmViewPeople : Form
    {
        public frmViewPeople()
        {
            InitializeComponent();
        }
        private void frmViewPeople_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from tbl_people;";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader sPeople = sCom.ExecuteReader();
                while (sPeople.Read())
                {
                    //string id = sPeople.GetInt32(0) + "";
                    int id = sPeople.GetInt32(0);
                    string name = sPeople.GetString(1);
                    string gender = sPeople[2] + "";
                    string email = sPeople[3] + "";
                    int phone = sPeople.GetInt32(4);
                    dgvViewOrder.Rows.Add(id, name, gender, email, phone);
                }
                sPeople.Close();
                sCom.Dispose();
                //DataConnection.sCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmViewPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frnMainForm().Show();
            this.Close();
        }
    }
}
