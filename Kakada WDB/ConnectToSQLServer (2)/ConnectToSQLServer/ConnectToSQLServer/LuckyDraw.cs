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
    public partial class frmLuckyDraw : Form
    {
        public frmLuckyDraw()
        {
            InitializeComponent();
        }
        private List<ClassLuckyDraw> arr;
        private List<ClassLuckyDraw> arrWinner;
        private void frmLuckyDraw_Load(object sender, EventArgs e)
        {
            arr = new List<ClassLuckyDraw>();
            arrWinner = new List<ClassLuckyDraw>();
            try
            {
                string sql = "select * from tbl_people;";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader sReader = sCom.ExecuteReader();
                while (sReader.Read())
                {
                    string id = sReader[0] + "";
                    string name = sReader[1] + "";
                    string gender = sReader[2] + "";
                    string email = sReader[3] + "";
                    string phone = sReader[4] + "";
                    ClassLuckyDraw p = new ClassLuckyDraw(id, name, gender, email, phone);
                    arr.Add(p);
                }
                sReader.Close();
                sCom.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnStartandStop_Click(object sender, EventArgs e)
        {
            if(btnStartandStop.Text == "Start")
            {
                if (arr.Count > 0)
                {
                    timer1.Start();
                    btnStartandStop.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("No More Data");
                }
            }
            else
            {
                timer1.Stop();
                btnStartandStop.Text = "Start";
                arrWinner.Add(arr[index]);
                lstLuckyDraw.Items.Add(arr[index].Phone);
                arr.RemoveAt(index);
            }
        }
        int index;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            index = r.Next(arr.Count());
            string phone = arr[index].Phone;
            txtRedomNum.Text = phone;
        }

        private void lstLuckyDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLuckyDraw.Rows.Clear();
            string id = arrWinner[lstLuckyDraw.SelectedIndex].Id;
            string name = arrWinner[lstLuckyDraw.SelectedIndex].Name;
            string gender = arrWinner[lstLuckyDraw.SelectedIndex].Gender;
            string email = arrWinner[lstLuckyDraw.SelectedIndex].Email;
            string phone = arrWinner[lstLuckyDraw.SelectedIndex].Phone;
            dgvLuckyDraw.Rows.Add(id, name, gender, email, phone);

        }

        private void frmLuckyDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frnMainForm().Show();
            this.Close();
        }
    }
}
