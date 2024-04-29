namespace OhShot_Pos
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.backBtn = new System.Windows.Forms.Button();
            this.tableNum = new System.Windows.Forms.Label();
            this.nowDateTIme = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.AllViewBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.AllCancelBtn = new System.Windows.Forms.Button();
            this.MenuTablePanel = new System.Windows.Forms.Panel();
            this.BtnEggRice = new System.Windows.Forms.Button();
            this.Btncoffee = new System.Windows.Forms.Button();
            this.BtnSalmonRice = new System.Windows.Forms.Button();
            this.BtnNuddle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnminusnum = new System.Windows.Forms.Button();
            this.MenuTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(28, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(265, 92);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "메인으로 돌아가기";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.Location = new System.Drawing.Point(354, 58);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(73, 16);
            this.tableNum.TabIndex = 1;
            this.tableNum.Text = "tableNum";
            // 
            // nowDateTIme
            // 
            this.nowDateTIme.AutoSize = true;
            this.nowDateTIme.Location = new System.Drawing.Point(554, 58);
            this.nowDateTIme.Name = "nowDateTIme";
            this.nowDateTIme.Size = new System.Drawing.Size(102, 16);
            this.nowDateTIme.TabIndex = 1;
            this.nowDateTIme.Text = "nowDateTIme";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(571, 502);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(73, 16);
            this.totalPrice.TabIndex = 1;
            this.totalPrice.Text = "totalPrice";
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(785, 22);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(265, 77);
            this.PaymentBtn.TabIndex = 0;
            this.PaymentBtn.Text = "결제";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // AllViewBtn
            // 
            this.AllViewBtn.Location = new System.Drawing.Point(697, 120);
            this.AllViewBtn.Name = "AllViewBtn";
            this.AllViewBtn.Size = new System.Drawing.Size(353, 67);
            this.AllViewBtn.TabIndex = 0;
            this.AllViewBtn.Text = "전체보기";
            this.AllViewBtn.UseVisualStyleBackColor = true;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(28, 470);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(168, 88);
            this.OrderBtn.TabIndex = 0;
            this.OrderBtn.Text = "주문하기";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(228, 517);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(152, 41);
            this.MinusBtn.TabIndex = 0;
            this.MinusBtn.Text = "품목제거";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // AllCancelBtn
            // 
            this.AllCancelBtn.Location = new System.Drawing.Point(412, 470);
            this.AllCancelBtn.Name = "AllCancelBtn";
            this.AllCancelBtn.Size = new System.Drawing.Size(126, 90);
            this.AllCancelBtn.TabIndex = 0;
            this.AllCancelBtn.Text = "전체취소";
            this.AllCancelBtn.UseVisualStyleBackColor = true;
            this.AllCancelBtn.Click += new System.EventHandler(this.AllCancelBtn_Click);
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.Controls.Add(this.BtnEggRice);
            this.MenuTablePanel.Controls.Add(this.Btncoffee);
            this.MenuTablePanel.Controls.Add(this.BtnSalmonRice);
            this.MenuTablePanel.Controls.Add(this.BtnNuddle);
            this.MenuTablePanel.Location = new System.Drawing.Point(697, 198);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.Size = new System.Drawing.Size(353, 357);
            this.MenuTablePanel.TabIndex = 4;
            // 
            // BtnEggRice
            // 
            this.BtnEggRice.Location = new System.Drawing.Point(28, 123);
            this.BtnEggRice.Name = "BtnEggRice";
            this.BtnEggRice.Size = new System.Drawing.Size(80, 29);
            this.BtnEggRice.TabIndex = 0;
            this.BtnEggRice.Text = "계란볶음밥";
            this.BtnEggRice.UseVisualStyleBackColor = true;
            this.BtnEggRice.Click += new System.EventHandler(this.BtnEggRice_Click);
            // 
            // Btncoffee
            // 
            this.Btncoffee.Location = new System.Drawing.Point(28, 88);
            this.Btncoffee.Name = "Btncoffee";
            this.Btncoffee.Size = new System.Drawing.Size(80, 29);
            this.Btncoffee.TabIndex = 0;
            this.Btncoffee.Text = "커피";
            this.Btncoffee.UseVisualStyleBackColor = true;
            this.Btncoffee.Click += new System.EventHandler(this.Btncoffee_Click);
            // 
            // BtnSalmonRice
            // 
            this.BtnSalmonRice.Location = new System.Drawing.Point(28, 53);
            this.BtnSalmonRice.Name = "BtnSalmonRice";
            this.BtnSalmonRice.Size = new System.Drawing.Size(80, 29);
            this.BtnSalmonRice.TabIndex = 0;
            this.BtnSalmonRice.Text = "연어덮밥";
            this.BtnSalmonRice.UseVisualStyleBackColor = true;
            this.BtnSalmonRice.Click += new System.EventHandler(this.BtnSalmonRice_Click);
            // 
            // BtnNuddle
            // 
            this.BtnNuddle.Location = new System.Drawing.Point(28, 18);
            this.BtnNuddle.Name = "BtnNuddle";
            this.BtnNuddle.Size = new System.Drawing.Size(80, 29);
            this.BtnNuddle.TabIndex = 0;
            this.BtnNuddle.Text = "라면";
            this.BtnNuddle.UseVisualStyleBackColor = true;
            this.BtnNuddle.Click += new System.EventHandler(this.BtnNuddle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 339);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(555, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "원";
            // 
            // Btnminusnum
            // 
            this.Btnminusnum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnminusnum.Location = new System.Drawing.Point(228, 470);
            this.Btnminusnum.Name = "Btnminusnum";
            this.Btnminusnum.Size = new System.Drawing.Size(152, 41);
            this.Btnminusnum.TabIndex = 0;
            this.Btnminusnum.Text = "수량감소";
            this.Btnminusnum.UseVisualStyleBackColor = true;
            this.Btnminusnum.Click += new System.EventHandler(this.Btnminusnum_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MenuTablePanel);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.nowDateTIme);
            this.Controls.Add(this.tableNum);
            this.Controls.Add(this.AllViewBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.AllCancelBtn);
            this.Controls.Add(this.Btnminusnum);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.MenuTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label nowDateTIme;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button AllViewBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button AllCancelBtn;
        private System.Windows.Forms.Panel MenuTablePanel;
        private System.Windows.Forms.Button BtnEggRice;
        private System.Windows.Forms.Button Btncoffee;
        private System.Windows.Forms.Button BtnSalmonRice;
        private System.Windows.Forms.Button BtnNuddle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnminusnum;
    }
}