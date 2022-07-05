namespace ConnectToSQLServer
{
    partial class frmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricein = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCateName = new System.Windows.Forms.ComboBox();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BarCode:";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(238, 60);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(178, 24);
            this.txtBarCode.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(238, 90);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(178, 24);
            this.txtProdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(238, 120);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(178, 24);
            this.txtQty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // txtPricein
            // 
            this.txtPricein.Location = new System.Drawing.Point(238, 150);
            this.txtPricein.Name = "txtPricein";
            this.txtPricein.Size = new System.Drawing.Size(178, 24);
            this.txtPricein.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price In:";
            // 
            // txtPriceout
            // 
            this.txtPriceout.Location = new System.Drawing.Point(238, 180);
            this.txtPriceout.Name = "txtPriceout";
            this.txtPriceout.Size = new System.Drawing.Size(178, 24);
            this.txtPriceout.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category Name:";
            // 
            // cboCateName
            // 
            this.cboCateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCateName.FormattingEnabled = true;
            this.cboCateName.Location = new System.Drawing.Point(238, 210);
            this.cboCateName.Name = "cboCateName";
            this.cboCateName.Size = new System.Drawing.Size(178, 26);
            this.cboCateName.TabIndex = 11;
            this.cboCateName.SelectedIndexChanged += new System.EventHandler(this.cboCateName_SelectedIndexChanged);
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(238, 242);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.ReadOnly = true;
            this.txtCateID.Size = new System.Drawing.Size(178, 24);
            this.txtCateID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(238, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 30);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCateID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCateName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPriceout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPricein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCateName;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
    }
}