namespace OhShot_Pos
{
    partial class FrmStat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sumprice1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Summenu1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbMenu = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Sumprice1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Summenu1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CboMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbMenu);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 398);
            this.panel1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(539, 100);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowTodayCircle = false;
            this.monthCalendar2.TabIndex = 3;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar1.Location = new System.Drawing.Point(307, 100);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(624, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "매출액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(40, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "매출액";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(624, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = " 0 개";
            // 
            // Sumprice1
            // 
            this.Sumprice1.AutoSize = true;
            this.Sumprice1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sumprice1.Location = new System.Drawing.Point(214, 320);
            this.Sumprice1.Name = "Sumprice1";
            this.Sumprice1.Size = new System.Drawing.Size(21, 14);
            this.Sumprice1.TabIndex = 2;
            this.Sumprice1.Text = " 0 ";
            this.Sumprice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(433, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = " 0 개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(433, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "판매량";
            // 
            // Summenu1
            // 
            this.Summenu1.AutoSize = true;
            this.Summenu1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Summenu1.Location = new System.Drawing.Point(214, 202);
            this.Summenu1.Name = "Summenu1";
            this.Summenu1.Size = new System.Drawing.Size(21, 14);
            this.Summenu1.TabIndex = 2;
            this.Summenu1.Text = " 0 ";
            this.Summenu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "판매량";
            // 
            // CboMenu
            // 
            this.CboMenu.FormattingEnabled = true;
            this.CboMenu.Location = new System.Drawing.Point(42, 99);
            this.CboMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CboMenu.Name = "CboMenu";
            this.CboMenu.Size = new System.Drawing.Size(215, 22);
            this.CboMenu.TabIndex = 1;
            this.CboMenu.SelectedIndexChanged += new System.EventHandler(this.CboMenu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(493, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "-- 날짜별 --";
            // 
            // LbMenu
            // 
            this.LbMenu.AutoSize = true;
            this.LbMenu.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbMenu.Location = new System.Drawing.Point(101, 42);
            this.LbMenu.Name = "LbMenu";
            this.LbMenu.Size = new System.Drawing.Size(89, 18);
            this.LbMenu.TabIndex = 0;
            this.LbMenu.Text = "-- 메뉴별 --";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(800, 302);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(197, 105);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "포스기 화면으로 돌아가기";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.total.Location = new System.Drawing.Point(844, 264);
            this.total.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(28, 23);
            this.total.TabIndex = 2;
            this.total.Text = " 0";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(858, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "총 매출액";
            // 
            // FrmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 421);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStat";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CboMenu;
        private System.Windows.Forms.Label LbMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sumprice1;
        private System.Windows.Forms.Label Summenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label7;
    }
}