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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.backBtn = new System.Windows.Forms.Button();
            this.tableNum = new System.Windows.Forms.Label();
            this.nowDateTIme = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.AllCancelBtn = new System.Windows.Forms.Button();
            this.BtnEggRice = new System.Windows.Forms.Button();
            this.Btncoffee = new System.Windows.Forms.Button();
            this.BtnSalmonRice = new System.Windows.Forms.Button();
            this.BtnNuddle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnminusnum = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            // BtnEggRice
            // 
            this.BtnEggRice.Location = new System.Drawing.Point(21, 20);
            this.BtnEggRice.Name = "BtnEggRice";
            this.BtnEggRice.Size = new System.Drawing.Size(80, 29);
            this.BtnEggRice.TabIndex = 0;
            this.BtnEggRice.Text = "계란볶음밥";
            this.BtnEggRice.UseVisualStyleBackColor = true;
            this.BtnEggRice.Click += new System.EventHandler(this.BtnEggRice_Click);
            // 
            // Btncoffee
            // 
            this.Btncoffee.Location = new System.Drawing.Point(21, 69);
            this.Btncoffee.Name = "Btncoffee";
            this.Btncoffee.Size = new System.Drawing.Size(80, 29);
            this.Btncoffee.TabIndex = 0;
            this.Btncoffee.Text = "커피";
            this.Btncoffee.UseVisualStyleBackColor = true;
            this.Btncoffee.Click += new System.EventHandler(this.Btncoffee_Click);
            // 
            // BtnSalmonRice
            // 
            this.BtnSalmonRice.Location = new System.Drawing.Point(240, 20);
            this.BtnSalmonRice.Name = "BtnSalmonRice";
            this.BtnSalmonRice.Size = new System.Drawing.Size(80, 29);
            this.BtnSalmonRice.TabIndex = 0;
            this.BtnSalmonRice.Text = "연어덮밥";
            this.BtnSalmonRice.UseVisualStyleBackColor = true;
            this.BtnSalmonRice.Click += new System.EventHandler(this.BtnSalmonRice_Click);
            // 
            // BtnNuddle
            // 
            this.BtnNuddle.Location = new System.Drawing.Point(132, 20);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(697, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 438);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEggRice);
            this.tabPage1.Controls.Add(this.BtnNuddle);
            this.tabPage1.Controls.Add(this.Btncoffee);
            this.tabPage1.Controls.Add(this.BtnSalmonRice);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "전체";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "밥";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(345, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "후식";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "계란볶음밥";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnEggRice_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "라면";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnNuddle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "커피";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btncoffee_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "연어덮밥";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnSalmonRice_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.nowDateTIme);
            this.Controls.Add(this.tableNum);
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
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrder_FormClosing);
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label nowDateTIme;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button AllCancelBtn;
        private System.Windows.Forms.Button BtnEggRice;
        private System.Windows.Forms.Button Btncoffee;
        private System.Windows.Forms.Button BtnSalmonRice;
        private System.Windows.Forms.Button BtnNuddle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnminusnum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
    }
}