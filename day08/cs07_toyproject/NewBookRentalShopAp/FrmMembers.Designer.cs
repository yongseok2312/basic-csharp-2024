namespace NewBookRentalShopAp
{
    partial class FrmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboLevels = new MetroFramework.Controls.MetroComboBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TxtAddr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtMemberidx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtBobile = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvResult);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 400);
            this.panel1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.AllowUserToOrderColumns = true;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowHeadersWidth = 40;
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(631, 400);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(661, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 366);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboLevels);
            this.groupBox1.Controls.Add(this.TxtBobile);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.TxtAddr);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtMemberidx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서회원 입력항목";
            // 
            // CboLevels
            // 
            this.CboLevels.FormattingEnabled = true;
            this.CboLevels.ItemHeight = 23;
            this.CboLevels.Location = new System.Drawing.Point(109, 112);
            this.CboLevels.Name = "CboLevels";
            this.CboLevels.PromptText = "--등급--";
            this.CboLevels.Size = new System.Drawing.Size(217, 29);
            this.CboLevels.TabIndex = 3;
            this.CboLevels.UseSelectable = true;
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(109, 223);
            this.TxtEmail.MaxLength = 13000;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "이메일 입력";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(217, 23);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "이메일 입력";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(52, 227);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "이메일";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 187);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "전화번호";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAddr
            // 
            // 
            // 
            // 
            this.TxtAddr.CustomButton.Image = null;
            this.TxtAddr.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtAddr.CustomButton.Name = "";
            this.TxtAddr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddr.CustomButton.TabIndex = 1;
            this.TxtAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddr.CustomButton.UseSelectable = true;
            this.TxtAddr.CustomButton.Visible = false;
            this.TxtAddr.Lines = new string[0];
            this.TxtAddr.Location = new System.Drawing.Point(109, 150);
            this.TxtAddr.MaxLength = 32767;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.PasswordChar = '\0';
            this.TxtAddr.PromptText = "주소 입력";
            this.TxtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddr.SelectedText = "";
            this.TxtAddr.SelectionLength = 0;
            this.TxtAddr.SelectionStart = 0;
            this.TxtAddr.ShortcutsEnabled = true;
            this.TxtAddr.Size = new System.Drawing.Size(217, 23);
            this.TxtAddr.TabIndex = 4;
            this.TxtAddr.UseSelectable = true;
            this.TxtAddr.WaterMark = "주소 입력";
            this.TxtAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddr.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "주소";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(66, 117);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "등급";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(260, 269);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(66, 32);
            this.BtnDel.TabIndex = 9;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(184, 269);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(66, 32);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(108, 269);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(66, 32);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(109, 80);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.PromptText = "회원명 입력";
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(217, 23);
            this.TxtNames.TabIndex = 2;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "회원명 입력";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtMemberidx
            // 
            // 
            // 
            // 
            this.TxtMemberidx.CustomButton.Image = null;
            this.TxtMemberidx.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtMemberidx.CustomButton.Name = "";
            this.TxtMemberidx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberidx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberidx.CustomButton.TabIndex = 1;
            this.TxtMemberidx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberidx.CustomButton.UseSelectable = true;
            this.TxtMemberidx.CustomButton.Visible = false;
            this.TxtMemberidx.Lines = new string[0];
            this.TxtMemberidx.Location = new System.Drawing.Point(109, 48);
            this.TxtMemberidx.MaxLength = 32767;
            this.TxtMemberidx.Name = "TxtMemberidx";
            this.TxtMemberidx.PasswordChar = '\0';
            this.TxtMemberidx.ReadOnly = true;
            this.TxtMemberidx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberidx.SelectedText = "";
            this.TxtMemberidx.SelectionLength = 0;
            this.TxtMemberidx.SelectionStart = 0;
            this.TxtMemberidx.ShortcutsEnabled = true;
            this.TxtMemberidx.Size = new System.Drawing.Size(217, 23);
            this.TxtMemberidx.TabIndex = 1;
            this.TxtMemberidx.UseSelectable = true;
            this.TxtMemberidx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberidx.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "회원명";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "회원 순번";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBobile
            // 
            // 
            // 
            // 
            this.TxtBobile.CustomButton.Image = null;
            this.TxtBobile.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtBobile.CustomButton.Name = "";
            this.TxtBobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBobile.CustomButton.TabIndex = 1;
            this.TxtBobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBobile.CustomButton.UseSelectable = true;
            this.TxtBobile.CustomButton.Visible = false;
            this.TxtBobile.Lines = new string[0];
            this.TxtBobile.Location = new System.Drawing.Point(108, 185);
            this.TxtBobile.MaxLength = 13;
            this.TxtBobile.Name = "TxtBobile";
            this.TxtBobile.PasswordChar = '\0';
            this.TxtBobile.PromptText = "전화번호 입력";
            this.TxtBobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBobile.SelectedText = "";
            this.TxtBobile.SelectionLength = 0;
            this.TxtBobile.SelectionStart = 0;
            this.TxtBobile.ShortcutsEnabled = true;
            this.TxtBobile.Size = new System.Drawing.Size(217, 23);
            this.TxtBobile.TabIndex = 5;
            this.TxtBobile.UseSelectable = true;
            this.TxtBobile.WaterMark = "전화번호 입력";
            this.TxtBobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBobile.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMembers";
            this.Text = "도서 회원";
            this.Load += new System.EventHandler(this.FrmMembers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtMemberidx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView DgvResult;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TxtAddr;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox CboLevels;
        private MetroFramework.Controls.MetroTextBox TxtBobile;
    }
}