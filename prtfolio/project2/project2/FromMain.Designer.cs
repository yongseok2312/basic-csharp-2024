using Microsoft.Identity.Client;

namespace project2
{
    partial class FromMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkWestern = new MetroFramework.Controls.MetroCheckBox();
            this.ChkChina = new MetroFramework.Controls.MetroCheckBox();
            this.ChkJapan = new MetroFramework.Controls.MetroCheckBox();
            this.ChkKorean = new MetroFramework.Controls.MetroCheckBox();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Btnstart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.PriceBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rbtnnomal = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnNuddle = new MetroFramework.Controls.MetroRadioButton();
            this.Rbtnrice = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkWestern);
            this.groupBox1.Controls.Add(this.ChkChina);
            this.groupBox1.Controls.Add(this.ChkJapan);
            this.groupBox1.Controls.Add(this.ChkKorean);
            this.groupBox1.Location = new System.Drawing.Point(339, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종류";
            // 
            // ChkWestern
            // 
            this.ChkWestern.AutoSize = true;
            this.ChkWestern.Location = new System.Drawing.Point(84, 46);
            this.ChkWestern.Name = "ChkWestern";
            this.ChkWestern.Size = new System.Drawing.Size(47, 15);
            this.ChkWestern.TabIndex = 0;
            this.ChkWestern.Text = "양식";
            this.ChkWestern.UseVisualStyleBackColor = true;
            this.ChkWestern.CheckedChanged += new System.EventHandler(this.ChkWestern_CheckedChanged);
            // 
            // ChkChina
            // 
            this.ChkChina.AutoSize = true;
            this.ChkChina.Location = new System.Drawing.Point(22, 46);
            this.ChkChina.Name = "ChkChina";
            this.ChkChina.Size = new System.Drawing.Size(47, 15);
            this.ChkChina.TabIndex = 0;
            this.ChkChina.Text = "중식";
            this.ChkChina.UseVisualStyleBackColor = true;
            this.ChkChina.CheckedChanged += new System.EventHandler(this.ChkChina_CheckedChanged);
            // 
            // ChkJapan
            // 
            this.ChkJapan.AutoSize = true;
            this.ChkJapan.Location = new System.Drawing.Point(84, 25);
            this.ChkJapan.Name = "ChkJapan";
            this.ChkJapan.Size = new System.Drawing.Size(47, 15);
            this.ChkJapan.TabIndex = 0;
            this.ChkJapan.Text = "일식";
            this.ChkJapan.UseVisualStyleBackColor = true;
            this.ChkJapan.CheckedChanged += new System.EventHandler(this.ChkJapan_CheckedChanged);
            // 
            // ChkKorean
            // 
            this.ChkKorean.AutoSize = true;
            this.ChkKorean.Location = new System.Drawing.Point(22, 25);
            this.ChkKorean.Name = "ChkKorean";
            this.ChkKorean.Size = new System.Drawing.Size(47, 15);
            this.ChkKorean.TabIndex = 0;
            this.ChkKorean.Text = "한식";
            this.ChkKorean.UseVisualStyleBackColor = true;
            this.ChkKorean.CheckedChanged += new System.EventHandler(this.ChkKorean_CheckedChanged);
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(23, 83);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(296, 214);
            this.DgvResult.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "오늘의 메뉴";
            // 
            // Btnstart
            // 
            this.Btnstart.Location = new System.Drawing.Point(340, 245);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(73, 52);
            this.Btnstart.TabIndex = 8;
            this.Btnstart.Text = "START!!";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtPrice);
            this.groupBox2.Controls.Add(this.PriceBar);
            this.groupBox2.Location = new System.Drawing.Point(340, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "가격";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(163, 52);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PromptText = "가격";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(75, 23);
            this.TxtPrice.TabIndex = 12;
            this.TxtPrice.Text = "가격";
            // 
            // PriceBar
            // 
            this.PriceBar.Location = new System.Drawing.Point(8, 18);
            this.PriceBar.Maximum = 20000;
            this.PriceBar.Minimum = 4000;
            this.PriceBar.Name = "PriceBar";
            this.PriceBar.Size = new System.Drawing.Size(230, 45);
            this.PriceBar.TabIndex = 11;
            this.PriceBar.Tag = "";
            this.PriceBar.TickFrequency = 1000;
            this.PriceBar.Value = 4000;
            this.PriceBar.Scroll += new System.EventHandler(this.PriceBar_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rbtnnomal);
            this.groupBox3.Controls.Add(this.RbtnNuddle);
            this.groupBox3.Controls.Add(this.Rbtnrice);
            this.groupBox3.Location = new System.Drawing.Point(497, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "밥,면";
            // 
            // Rbtnnomal
            // 
            this.Rbtnnomal.AutoSize = true;
            this.Rbtnnomal.Location = new System.Drawing.Point(12, 61);
            this.Rbtnnomal.Name = "Rbtnnomal";
            this.Rbtnnomal.Size = new System.Drawing.Size(71, 15);
            this.Rbtnnomal.TabIndex = 0;
            this.Rbtnnomal.TabStop = true;
            this.Rbtnnomal.Text = "상관없음";
            this.Rbtnnomal.UseVisualStyleBackColor = true;
            this.Rbtnnomal.Click += new System.EventHandler(this.Rbtnnomal_Click);
            // 
            // RbtnNuddle
            // 
            this.RbtnNuddle.AutoSize = true;
            this.RbtnNuddle.Location = new System.Drawing.Point(12, 41);
            this.RbtnNuddle.Name = "RbtnNuddle";
            this.RbtnNuddle.Size = new System.Drawing.Size(35, 15);
            this.RbtnNuddle.TabIndex = 0;
            this.RbtnNuddle.TabStop = true;
            this.RbtnNuddle.Text = "면";
            this.RbtnNuddle.UseVisualStyleBackColor = true;
            this.RbtnNuddle.Click += new System.EventHandler(this.RbtnNuddle_Click);
            // 
            // Rbtnrice
            // 
            this.Rbtnrice.AutoSize = true;
            this.Rbtnrice.Location = new System.Drawing.Point(12, 20);
            this.Rbtnrice.Name = "Rbtnrice";
            this.Rbtnrice.Size = new System.Drawing.Size(35, 15);
            this.Rbtnrice.TabIndex = 0;
            this.Rbtnrice.TabStop = true;
            this.Rbtnrice.Text = "밥";
            this.Rbtnrice.UseVisualStyleBackColor = true;
            this.Rbtnrice.Click += new System.EventHandler(this.Rbtnrice_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(430, 245);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.Size = new System.Drawing.Size(154, 50);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.Text = "과연";
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 308);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DgvResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "FromMain";
            this.Text = "메뉴 정하기";
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar PriceBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox ChkJapan;
        private MetroFramework.Controls.MetroCheckBox ChkKorean;
        private MetroFramework.Controls.MetroCheckBox ChkWestern;
        private MetroFramework.Controls.MetroCheckBox ChkChina;
        private MetroFramework.Controls.MetroRadioButton RbtnNuddle;
        private MetroFramework.Controls.MetroRadioButton Rbtnrice;
        private MetroFramework.Controls.MetroRadioButton Rbtnnomal;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private System.Windows.Forms.TextBox metroTextBox1;
    }
}

