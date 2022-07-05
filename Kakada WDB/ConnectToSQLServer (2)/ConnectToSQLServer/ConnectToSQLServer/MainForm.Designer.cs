namespace ConnectToSQLServer
{
    partial class frnMainForm
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
            this.btnViewPeople = new System.Windows.Forms.Button();
            this.btnLuckyDraw = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOderProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewPeople
            // 
            this.btnViewPeople.Location = new System.Drawing.Point(238, 94);
            this.btnViewPeople.Name = "btnViewPeople";
            this.btnViewPeople.Size = new System.Drawing.Size(110, 43);
            this.btnViewPeople.TabIndex = 0;
            this.btnViewPeople.Text = "ViewPeople";
            this.btnViewPeople.UseVisualStyleBackColor = true;
            this.btnViewPeople.Click += new System.EventHandler(this.btnViewPeople_Click);
            // 
            // btnLuckyDraw
            // 
            this.btnLuckyDraw.Location = new System.Drawing.Point(238, 143);
            this.btnLuckyDraw.Name = "btnLuckyDraw";
            this.btnLuckyDraw.Size = new System.Drawing.Size(110, 43);
            this.btnLuckyDraw.TabIndex = 1;
            this.btnLuckyDraw.Text = "LuckyDraw";
            this.btnLuckyDraw.UseVisualStyleBackColor = true;
            this.btnLuckyDraw.Click += new System.EventHandler(this.btnLuckyDraw_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(238, 192);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(110, 43);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOderProduct
            // 
            this.btnOderProduct.Location = new System.Drawing.Point(238, 241);
            this.btnOderProduct.Name = "btnOderProduct";
            this.btnOderProduct.Size = new System.Drawing.Size(110, 43);
            this.btnOderProduct.TabIndex = 3;
            this.btnOderProduct.Text = "Order Product";
            this.btnOderProduct.UseVisualStyleBackColor = true;
            this.btnOderProduct.Click += new System.EventHandler(this.btnOderProduct_Click);
            // 
            // frnMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 378);
            this.Controls.Add(this.btnOderProduct);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnLuckyDraw);
            this.Controls.Add(this.btnViewPeople);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frnMainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewPeople;
        private System.Windows.Forms.Button btnLuckyDraw;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOderProduct;
    }
}