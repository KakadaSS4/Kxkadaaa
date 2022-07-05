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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private List<string> arrCateID = new List<string>();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from tbl_category;";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                SqlDataReader sCate = sCom.ExecuteReader();
                while (sCate.Read())
                {
                    string id = sCate[0].ToString();
                    string catename = sCate[1].ToString();
                    cboCateName.Items.Add(catename);
                    arrCateID.Add(id);
                }
                sCate.Close();
                sCom.Dispose();
                cboCateName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboCateName.SelectedIndex;
                txtCateID.Text = arrCateID[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtBarCode.Text.Trim();
                string pName = txtProdName.Text.Trim();
                int Qty = int.Parse(txtQty.Text.Trim());
                float pIn = float.Parse(txtPricein.Text.Trim());
                float pOut = float.Parse(txtPriceout.Text.Trim());
                int cID = int.Parse(txtCateID.Text.Trim());

                string sql = "insert into tbl_product values" + "('" + barCode + "','" + pName + "'," + Qty + "," + pIn +"," + pOut + "," + cID + ");";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);

                sCom.ExecuteNonQuery();
                sCom.Dispose(); 

                MessageBox.Show("Insert Successful");
                this.Close();
                new frmProduct().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
