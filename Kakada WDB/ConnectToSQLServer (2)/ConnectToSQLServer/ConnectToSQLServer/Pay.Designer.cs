
namespace ConnectToSQLServer
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDis = new System.Windows.Forms.ComboBox();
            this.txtCRece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCRetu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnpay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalamount
            // 
            this.txtTotalamount.Location = new System.Drawing.Point(190, 46);
            this.txtTotalamount.Name = "txtTotalamount";
            this.txtTotalamount.ReadOnly = true;
            this.txtTotalamount.Size = new System.Drawing.Size(178, 24);
            this.txtTotalamount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discount:";
            // 
            // txtDisP
            // 
            this.txtDisP.Location = new System.Drawing.Point(190, 106);
            this.txtDisP.Name = "txtDisP";
            this.txtDisP.ReadOnly = true;
            this.txtDisP.Size = new System.Drawing.Size(178, 24);
            this.txtDisP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount Price:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(190, 138);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(178, 24);
            this.txtPayment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment:";
            // 
            // cboDis
            // 
            this.cboDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDis.FormattingEnabled = true;
            this.cboDis.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cboDis.Location = new System.Drawing.Point(190, 74);
            this.cboDis.Name = "cboDis";
            this.cboDis.Size = new System.Drawing.Size(178, 26);
            this.cboDis.TabIndex = 12;
            this.cboDis.SelectedIndexChanged += new System.EventHandler(this.cboDis_SelectedIndexChanged);
            // 
            // txtCRece
            // 
            this.txtCRece.Location = new System.Drawing.Point(190, 168);
            this.txtCRece.Name = "txtCRece";
            this.txtCRece.Size = new System.Drawing.Size(178, 24);
            this.txtCRece.TabIndex = 14;
            this.txtCRece.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCRece_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cash Received:";
            // 
            // txtCRetu
            // 
            this.txtCRetu.Location = new System.Drawing.Point(190, 200);
            this.txtCRetu.Name = "txtCRetu";
            this.txtCRetu.ReadOnly = true;
            this.txtCRetu.Size = new System.Drawing.Size(178, 24);
            this.txtCRetu.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cash Returned:";
            // 
            // btnpay
            // 
            this.btnpay.Enabled = false;
            this.btnpay.Location = new System.Drawing.Point(190, 231);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(75, 38);
            this.btnpay.TabIndex = 17;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 291);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.txtCRetu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCRece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDis);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDisP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalamount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDis;
        private System.Windows.Forms.TextBox txtCRece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCRetu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnpay;
    }
}