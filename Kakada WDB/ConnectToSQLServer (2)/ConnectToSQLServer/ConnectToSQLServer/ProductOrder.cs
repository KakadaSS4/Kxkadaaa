using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnectToSQLServer
{
    public partial class frmProductOrder : Form
    {
        public frmProductOrder()
        {
            InitializeComponent();
        }

        private List<Orderline> Orderlist = new List<Orderline>();

        private int CheckID(int ID)
        {
            for(int i = 0; i < Orderlist.Count; i++)
            {
                Orderline obj = Orderlist[i];
                if (obj.pID == ID)
                    return i;
            }
            return -1;
        }
        private double totalamount()
        {
            double t = 0;
            foreach (Orderline temp in Orderlist)
                t += temp.qty * temp.price;
            return t;
        }
        

        private void frmProductOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool ProductIsExist(string BarCode)
        {
            string sql = "select * from tbl_product where BarCode = '" + BarCode + "';";
            SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
            SqlDataReader sProduct = sCom.ExecuteReader();
            if (sProduct.Read())
            {
                string id = sProduct[0] + "";           
                string prodName = sProduct[2] + "";
                int qty = 1;
                double price = double.Parse(sProduct[5] + "");
                double amount = qty * price;
                int index = CheckID(int.Parse(id));
                if (index >= 0)
                {
                    qty = Orderlist[index].qty + 1;
                    amount = qty * price;
                    dgvOrderProduct.Rows[index].Cells[2].Value = qty;
                    dgvOrderProduct.Rows[index].Cells[4].Value = amount;
                    Orderlist[index].qty = qty;
                }
                else
                {
                    int num = dgvOrderProduct.Rows.Count + 1;
                    dgvOrderProduct.Rows.Add(num, prodName, qty, price, amount);
                    Orderline obj = new Orderline(int.Parse(id), qty, price);
                    Orderlist.Add(obj);
                }
                sProduct.Close();
                sCom.Dispose();
                return true;
            }
            else
            {
                sProduct.Close();
                sCom.Dispose();
                return false;
            }
        } 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string barcode = txtBarCode.Text;
                if (ProductIsExist(barcode))
                {
                    //MessageBox.Show("This product available");
                    txtBarCode.Clear();
                    txtTotal.Text = totalamount().ToString("c2");
                }
                else
                {
                    MessageBox.Show("THis product is not available");
                }
            }
        }
        private string InsertOrder(double discount)
        {
            string ordDate = DateTime.Now.ToString("yyy-MM-dd");
            string ordTime = DateTime.Now.ToString("HH:mm:ss");
            string seller = DataConnection.Seller;
            string sql = "insert into tbl_order values('" + ordDate + "','" + ordTime + "'," + discount + ",'" + seller + "');";
            SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
            sCom.ExecuteNonQuery();

            sql = "Select SCOPE_IDENTITY()";
            sCom = new SqlCommand(sql, DataConnection.sCon);
            SqlDataReader r = sCom.ExecuteReader();
            string ordID = "";
            if (r.Read())
                ordID = r[0] + "";
            r.Close();
            sCom.Dispose();
            return ordID;
        }
        private void InsertOrderDetail(string ordID)
        {
            foreach(Orderline temp in Orderlist)
            {
                string pid = temp.pID + "";
                string qty = temp.qty + "";
                string price = temp.price + "";
                string sql = "insert into tbl_orderdetail values(" + ordID + "," + pid + "," + qty + ", " +  price + ");";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                sCom.ExecuteNonQuery();
                sCom.Dispose();
            }
        }
        private void updatestock()
        {
            foreach(Orderline temp in Orderlist)
            {
                int pid = temp.pID;
                int qty = temp.qty;
                string sql = "update tbl_product set qty-=" + qty + " where pID=" + pid + ";";
                SqlCommand sCom = new SqlCommand(sql, DataConnection.sCon);
                sCom.ExecuteNonQuery();
                sCom.Dispose();
            }
        }
        string ordID;
        frmPayment payment;
        private void btn_goto_pay_Click(object sender, EventArgs e)
        {
            payment = new frmPayment(totalamount());
            if (payment.ShowDialog() == DialogResult.OK)
            {
                //Insert Orders
                ordID = InsertOrder(payment.Discount);
                //Insert OrderDetail
                InsertOrderDetail(ordID);
                //Update Stock
                updatestock();
                //Print Report
                printPreviewDialog.ShowDialog();
                //Clear for new orders
                Orderlist = new List<Orderline>();
                dgvOrderProduct.Rows.Clear();
                txtTotal.Text = "$0.00";
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 0;
            Image im = Image.FromFile("D:\\Y2S2\\WBD I\\Exercise\\Image\\Logo.png");
            e.Graphics.DrawImage(im, 120, y, 100, 100);

            y += 100;
            e.Graphics.DrawString("Kanzo Coffee", new Font("", 8), Brushes.Black, new Point(0, y));

            y += 15;
            e.Graphics.DrawString($"Order ID: {ordID}", new Font("", 8), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"Seller: {DataConnection.Seller}", new Font("", 8), Brushes.Black, new Point(190, y));

            y += 15;
            e.Graphics.DrawString($"No\tDescription\tQty\tPrice\tAmount", new Font("", 8), Brushes.Black, new Point(0, y));

            y += 15;
            foreach(DataGridViewRow row in dgvOrderProduct.Rows)
            {
                e.Graphics.DrawString($"{row.Cells[0].Value}", new Font("", 8), Brushes.Black, new Point(0, y));
                e.Graphics.DrawString($"{row.Cells[1].Value}", new Font("", 8), Brushes.Black, new Point(45, y));
                e.Graphics.DrawString($"{row.Cells[2].Value}", new Font("", 8), Brushes.Black, new Point(135, y));
                e.Graphics.DrawString($"${row.Cells[3].Value}", new Font("", 8), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString($"${row.Cells[4].Value}", new Font("", 8), Brushes.Black, new Point(225, y));
                y += 15;
            }
            e.Graphics.DrawString($"=========================================================================", new Font("", 8), Brushes.Black, new Point(0, y));

            y += 15;
            e.Graphics.DrawString("Total Amount: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{totalamount().ToString("$#,##0.00")}", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

            y += 15;
            e.Graphics.DrawString("Discount: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{payment.Discount}%", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

            y += 15;
            e.Graphics.DrawString("Discount Price: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{payment.DiscountPrice.ToString("$#,##0.00")}", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

            y += 15;
            e.Graphics.DrawString("Payment: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{payment.Payment.ToString("$#,##0.00")}", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

            y += 15;
            e.Graphics.DrawString("Cash Received: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{payment.CashReceived.ToString("$#,##0.00")}", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

            y += 15;
            e.Graphics.DrawString("Cash Returned: ", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString($"{payment.CashReturned.ToString("$#,##0.00")}", new Font("", 9, FontStyle.Bold), Brushes.Black, new Point(225, y));

        }
    }
}
