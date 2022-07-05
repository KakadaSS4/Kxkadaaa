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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        public frmPayment(double totalamount)
        {
            InitializeComponent();
            Totalamount = totalamount;
        }
        public double Totalamount { get; set; }
        public double Discount { get; set; }
        public double DiscountPrice { get; set; }
        public double Payment { get; set; }
        public double CashReceived { get; set; }
        public double CashReturned { get; set; }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtTotalamount.Text = Totalamount.ToString("$#,##0.00");
        }

        private void cboDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis = cboDis.SelectedItem + "";
            dis = dis.Substring(0, dis.Length - 1);
            Discount = double.Parse(dis);
            DiscountPrice = Totalamount * Discount / 100;
            Payment = Totalamount - DiscountPrice;
            txtDisP.Text = DiscountPrice.ToString("$#,##0.00");
            txtPayment.Text = Payment.ToString("$#,##0.00");
        }

        private void txtCRece_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    string received = txtCRece.Text.Trim();
                    CashReceived = double.Parse(received);
                    CashReturned = CashReceived - Payment;
                    txtCRetu.Text = CashReturned.ToString("$#,##0.00");
                    if (CashReceived >= Payment)
                        btnpay.Enabled = true;
                    else
                        btnpay.Enabled = false;
                }
                catch (Exception ex)
                {
                    txtCRetu.Text = "$0.00";
                    btnpay.Enabled = false;
                }
            }
            else
                btnpay_Click(sender, e);
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pay...");
            DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
