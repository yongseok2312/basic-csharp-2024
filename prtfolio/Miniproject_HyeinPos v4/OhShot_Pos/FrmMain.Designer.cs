namespace OhShot_Pos
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTable6 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTable5 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTable4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTable3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Table2 = new System.Windows.Forms.Label();
            this.TxtTable2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table1 = new System.Windows.Forms.Label();
            this.TxtTable1 = new System.Windows.Forms.TextBox();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Datelabel = new System.Windows.Forms.Label();
            this.Btnrecord = new System.Windows.Forms.Button();
            this.TblPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPanel
            // 
            this.TblPanel.ColumnCount = 2;
            this.TblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0473F));
            this.TblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.9527F));
            this.TblPanel.Controls.Add(this.panel6, 1, 2);
            this.TblPanel.Controls.Add(this.panel5, 0, 2);
            this.TblPanel.Controls.Add(this.panel4, 1, 1);
            this.TblPanel.Controls.Add(this.panel3, 0, 1);
            this.TblPanel.Controls.Add(this.panel2, 1, 0);
            this.TblPanel.Controls.Add(this.panel1, 0, 0);
            this.TblPanel.Location = new System.Drawing.Point(17, 19);
            this.TblPanel.Name = "TblPanel";
            this.TblPanel.RowCount = 3;
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.TblPanel.Size = new System.Drawing.Size(1057, 730);
            this.TblPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.TxtTable6);
            this.panel6.Location = new System.Drawing.Point(531, 488);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(523, 238);
            this.panel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("굴림", 23F);
            this.label5.Location = new System.Drawing.Point(175, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Table 6";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable6
            // 
            this.TxtTable6.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable6.Location = new System.Drawing.Point(2, 42);
            this.TxtTable6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable6.Multiline = true;
            this.TxtTable6.Name = "TxtTable6";
            this.TxtTable6.ReadOnly = true;
            this.TxtTable6.Size = new System.Drawing.Size(518, 193);
            this.TxtTable6.TabIndex = 4;
            this.TxtTable6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable6.Click += new System.EventHandler(this.TxtTable6_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.TxtTable5);
            this.panel5.Location = new System.Drawing.Point(3, 488);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 238);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("굴림", 23F);
            this.label4.Location = new System.Drawing.Point(175, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Table 5";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable5
            // 
            this.TxtTable5.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable5.Location = new System.Drawing.Point(2, 42);
            this.TxtTable5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable5.Multiline = true;
            this.TxtTable5.Name = "TxtTable5";
            this.TxtTable5.ReadOnly = true;
            this.TxtTable5.Size = new System.Drawing.Size(518, 193);
            this.TxtTable5.TabIndex = 4;
            this.TxtTable5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable5.Click += new System.EventHandler(this.TxtTable5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TxtTable4);
            this.panel4.Location = new System.Drawing.Point(531, 245);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 238);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("굴림", 23F);
            this.label3.Location = new System.Drawing.Point(175, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table 4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable4
            // 
            this.TxtTable4.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable4.Location = new System.Drawing.Point(2, 42);
            this.TxtTable4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable4.Multiline = true;
            this.TxtTable4.Name = "TxtTable4";
            this.TxtTable4.ReadOnly = true;
            this.TxtTable4.Size = new System.Drawing.Size(518, 193);
            this.TxtTable4.TabIndex = 4;
            this.TxtTable4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable4.Click += new System.EventHandler(this.TxtTable4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TxtTable3);
            this.panel3.Location = new System.Drawing.Point(3, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 238);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("굴림", 23F);
            this.label2.Location = new System.Drawing.Point(175, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table 3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable3
            // 
            this.TxtTable3.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable3.Location = new System.Drawing.Point(2, 42);
            this.TxtTable3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable3.Multiline = true;
            this.TxtTable3.Name = "TxtTable3";
            this.TxtTable3.ReadOnly = true;
            this.TxtTable3.Size = new System.Drawing.Size(518, 193);
            this.TxtTable3.TabIndex = 4;
            this.TxtTable3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable3.Click += new System.EventHandler(this.TxtTable3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Table2);
            this.panel2.Controls.Add(this.TxtTable2);
            this.panel2.Location = new System.Drawing.Point(531, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 238);
            this.panel2.TabIndex = 5;
            // 
            // Table2
            // 
            this.Table2.AutoSize = true;
            this.Table2.BackColor = System.Drawing.Color.Coral;
            this.Table2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table2.Font = new System.Drawing.Font("굴림", 23F);
            this.Table2.Location = new System.Drawing.Point(175, 6);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(123, 33);
            this.Table2.TabIndex = 3;
            this.Table2.Text = "Table 2";
            this.Table2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable2
            // 
            this.TxtTable2.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable2.Location = new System.Drawing.Point(2, 42);
            this.TxtTable2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable2.Multiline = true;
            this.TxtTable2.Name = "TxtTable2";
            this.TxtTable2.ReadOnly = true;
            this.TxtTable2.Size = new System.Drawing.Size(518, 193);
            this.TxtTable2.TabIndex = 4;
            this.TxtTable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable2.Click += new System.EventHandler(this.TxtTable2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table1);
            this.panel1.Controls.Add(this.TxtTable1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 238);
            this.panel1.TabIndex = 0;
            // 
            // table1
            // 
            this.table1.AutoSize = true;
            this.table1.BackColor = System.Drawing.Color.Coral;
            this.table1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table1.Font = new System.Drawing.Font("굴림", 23F);
            this.table1.Location = new System.Drawing.Point(175, 6);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(123, 33);
            this.table1.TabIndex = 3;
            this.table1.Text = "Table 1";
            this.table1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTable1
            // 
            this.TxtTable1.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTable1.Location = new System.Drawing.Point(2, 42);
            this.TxtTable1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTable1.Multiline = true;
            this.TxtTable1.Name = "TxtTable1";
            this.TxtTable1.ReadOnly = true;
            this.TxtTable1.Size = new System.Drawing.Size(518, 193);
            this.TxtTable1.TabIndex = 4;
            this.TxtTable1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTable1.Click += new System.EventHandler(this.TxtTable1_Click);
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(1089, 576);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(283, 78);
            this.BtnStat.TabIndex = 2;
            this.BtnStat.Text = "매출 통계";
            this.BtnStat.UseVisualStyleBackColor = true;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1089, 671);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(283, 78);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "포스기 종료";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Datelabel.Location = new System.Drawing.Point(1108, 82);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(91, 32);
            this.Datelabel.TabIndex = 3;
            this.Datelabel.Text = "Time";
            // 
            // Btnrecord
            // 
            this.Btnrecord.Location = new System.Drawing.Point(1089, 477);
            this.Btnrecord.Name = "Btnrecord";
            this.Btnrecord.Size = new System.Drawing.Size(283, 78);
            this.Btnrecord.TabIndex = 2;
            this.Btnrecord.Text = "결제 기록";
            this.Btnrecord.UseVisualStyleBackColor = true;
            this.Btnrecord.Click += new System.EventHandler(this.Btnrecord_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.Btnrecord);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.TblPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TblPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPanel;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label table1;
        private System.Windows.Forms.TextBox TxtTable1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTable6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTable5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTable4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTable3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Table2;
        private System.Windows.Forms.TextBox TxtTable2;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Button Btnrecord;
    }
}

