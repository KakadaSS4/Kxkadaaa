namespace ConnectToSQLServer
{
    partial class frmLuckyDraw
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
            this.components = new System.ComponentModel.Container();
            this.dgvLuckyDraw = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartandStop = new System.Windows.Forms.Button();
            this.txtRedomNum = new System.Windows.Forms.TextBox();
            this.lstLuckyDraw = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLuckyDraw
            // 
            this.dgvLuckyDraw.AllowUserToAddRows = false;
            this.dgvLuckyDraw.AllowUserToDeleteRows = false;
            this.dgvLuckyDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuckyDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLuckyDraw.Location = new System.Drawing.Point(444, 21);
            this.dgvLuckyDraw.Name = "dgvLuckyDraw";
            this.dgvLuckyDraw.ReadOnly = true;
            this.dgvLuckyDraw.Size = new System.Drawing.Size(745, 347);
            this.dgvLuckyDraw.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnStartandStop
            // 
            this.btnStartandStop.Location = new System.Drawing.Point(328, 21);
            this.btnStartandStop.Name = "btnStartandStop";
            this.btnStartandStop.Size = new System.Drawing.Size(110, 43);
            this.btnStartandStop.TabIndex = 2;
            this.btnStartandStop.Text = "Start";
            this.btnStartandStop.UseVisualStyleBackColor = true;
            this.btnStartandStop.Click += new System.EventHandler(this.btnStartandStop_Click);
            // 
            // txtRedomNum
            // 
            this.txtRedomNum.Location = new System.Drawing.Point(12, 21);
            this.txtRedomNum.Multiline = true;
            this.txtRedomNum.Name = "txtRedomNum";
            this.txtRedomNum.Size = new System.Drawing.Size(310, 43);
            this.txtRedomNum.TabIndex = 3;
            // 
            // lstLuckyDraw
            // 
            this.lstLuckyDraw.FormattingEnabled = true;
            this.lstLuckyDraw.ItemHeight = 18;
            this.lstLuckyDraw.Location = new System.Drawing.Point(14, 75);
            this.lstLuckyDraw.Name = "lstLuckyDraw";
            this.lstLuckyDraw.Size = new System.Drawing.Size(424, 292);
            this.lstLuckyDraw.TabIndex = 4;
            this.lstLuckyDraw.SelectedIndexChanged += new System.EventHandler(this.lstLuckyDraw_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 380);
            this.Controls.Add(this.lstLuckyDraw);
            this.Controls.Add(this.txtRedomNum);
            this.Controls.Add(this.btnStartandStop);
            this.Controls.Add(this.dgvLuckyDraw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLuckyDraw";
            this.Text = "LuckyDraw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLuckyDraw_FormClosed);
            this.Load += new System.EventHandler(this.frmLuckyDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLuckyDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnStartandStop;
        private System.Windows.Forms.TextBox txtRedomNum;
        private System.Windows.Forms.ListBox lstLuckyDraw;
        private System.Windows.Forms.Timer timer1;
    }
}