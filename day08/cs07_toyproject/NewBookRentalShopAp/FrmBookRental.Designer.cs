namespace NewBookRentalShopAp
{
    partial class FrmBookRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookRental));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textnames = new System.Windows.Forms.TextBox();
            this.textmembers = new System.Windows.Forms.TextBox();
            this.btnsearhbook = new System.Windows.Forms.Button();
            this.btnserachmember = new System.Windows.Forms.Button();
            this.Dtpreturndate = new MetroFramework.Controls.MetroDateTime();
            this.Dtprentaldate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtMembers = new MetroFramework.Controls.MetroTextBox();
            this.TxtRentalIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.DgvResult.MultiSelect = false;
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
            this.groupBox1.Controls.Add(this.textnames);
            this.groupBox1.Controls.Add(this.textmembers);
            this.groupBox1.Controls.Add(this.btnsearhbook);
            this.groupBox1.Controls.Add(this.btnserachmember);
            this.groupBox1.Controls.Add(this.Dtpreturndate);
            this.groupBox1.Controls.Add(this.Dtprentaldate);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtMembers);
            this.groupBox1.Controls.Add(this.TxtRentalIdx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대출여부 입력항목";
            // 
            // textnames
            // 
            this.textnames.Location = new System.Drawing.Point(108, 138);
            this.textnames.Name = "textnames";
            this.textnames.Size = new System.Drawing.Size(46, 21);
            this.textnames.TabIndex = 5;
            // 
            // textmembers
            // 
            this.textmembers.Location = new System.Drawing.Point(108, 94);
            this.textmembers.Name = "textmembers";
            this.textmembers.Size = new System.Drawing.Size(46, 21);
            this.textmembers.TabIndex = 2;
            // 
            // btnsearhbook
            // 
            this.btnsearhbook.Image = global::NewBookRentalShopAp.Properties.Resources.search2;
            this.btnsearhbook.Location = new System.Drawing.Point(313, 137);
            this.btnsearhbook.Name = "btnsearhbook";
            this.btnsearhbook.Size = new System.Drawing.Size(24, 23);
            this.btnsearhbook.TabIndex = 7;
            this.btnsearhbook.UseVisualStyleBackColor = true;
            this.btnsearhbook.Click += new System.EventHandler(this.btnsearhbook_Click);
            // 
            // btnserachmember
            // 
            this.btnserachmember.Image = global::NewBookRentalShopAp.Properties.Resources.search2;
            this.btnserachmember.Location = new System.Drawing.Point(313, 93);
            this.btnserachmember.Name = "btnserachmember";
            this.btnserachmember.Size = new System.Drawing.Size(24, 23);
            this.btnserachmember.TabIndex = 4;
            this.btnserachmember.UseVisualStyleBackColor = true;
            this.btnserachmember.Click += new System.EventHandler(this.btnserachmember_Click);
            // 
            // Dtpreturndate
            // 
            this.Dtpreturndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtpreturndate.Location = new System.Drawing.Point(108, 224);
            this.Dtpreturndate.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtpreturndate.Name = "Dtpreturndate";
            this.Dtpreturndate.Size = new System.Drawing.Size(229, 29);
            this.Dtpreturndate.TabIndex = 9;
            // 
            // Dtprentaldate
            // 
            this.Dtprentaldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtprentaldate.Location = new System.Drawing.Point(109, 178);
            this.Dtprentaldate.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dtprentaldate.Name = "Dtprentaldate";
            this.Dtprentaldate.Size = new System.Drawing.Size(228, 29);
            this.Dtprentaldate.TabIndex = 8;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(52, 228);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "반납일";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(52, 183);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "대출일";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(158, 137);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.PromptText = "책 제목 선택";
            this.TxtNames.ReadOnly = true;
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(147, 23);
            this.TxtNames.TabIndex = 6;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "책 제목 선택";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 138);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "책제목";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(268, 272);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(66, 32);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(192, 272);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(66, 32);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtMembers
            // 
            // 
            // 
            // 
            this.TxtMembers.CustomButton.Image = null;
            this.TxtMembers.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.TxtMembers.CustomButton.Name = "";
            this.TxtMembers.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMembers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMembers.CustomButton.TabIndex = 1;
            this.TxtMembers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMembers.CustomButton.UseSelectable = true;
            this.TxtMembers.CustomButton.Visible = false;
            this.TxtMembers.Lines = new string[0];
            this.TxtMembers.Location = new System.Drawing.Point(158, 93);
            this.TxtMembers.MaxLength = 32767;
            this.TxtMembers.Name = "TxtMembers";
            this.TxtMembers.PasswordChar = '\0';
            this.TxtMembers.PromptText = "회원명 선택";
            this.TxtMembers.ReadOnly = true;
            this.TxtMembers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMembers.SelectedText = "";
            this.TxtMembers.SelectionLength = 0;
            this.TxtMembers.SelectionStart = 0;
            this.TxtMembers.ShortcutsEnabled = true;
            this.TxtMembers.Size = new System.Drawing.Size(147, 23);
            this.TxtMembers.TabIndex = 3;
            this.TxtMembers.UseSelectable = true;
            this.TxtMembers.WaterMark = "회원명 선택";
            this.TxtMembers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMembers.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtRentalIdx
            // 
            // 
            // 
            // 
            this.TxtRentalIdx.CustomButton.Image = null;
            this.TxtRentalIdx.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.TxtRentalIdx.CustomButton.Name = "";
            this.TxtRentalIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRentalIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRentalIdx.CustomButton.TabIndex = 1;
            this.TxtRentalIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRentalIdx.CustomButton.UseSelectable = true;
            this.TxtRentalIdx.CustomButton.Visible = false;
            this.TxtRentalIdx.Lines = new string[0];
            this.TxtRentalIdx.Location = new System.Drawing.Point(109, 52);
            this.TxtRentalIdx.MaxLength = 32767;
            this.TxtRentalIdx.Name = "TxtRentalIdx";
            this.TxtRentalIdx.PasswordChar = '\0';
            this.TxtRentalIdx.ReadOnly = true;
            this.TxtRentalIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRentalIdx.SelectedText = "";
            this.TxtRentalIdx.SelectionLength = 0;
            this.TxtRentalIdx.SelectionStart = 0;
            this.TxtRentalIdx.ShortcutsEnabled = true;
            this.TxtRentalIdx.Size = new System.Drawing.Size(228, 23);
            this.TxtRentalIdx.TabIndex = 1;
            this.TxtRentalIdx.UseSelectable = true;
            this.TxtRentalIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRentalIdx.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.metroLabel2.Location = new System.Drawing.Point(52, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "회원명";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "대출순번";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmBookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookRental";
            this.Text = "대출/반납";
            this.Load += new System.EventHandler(this.FrmBookRental_Load);
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
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtMembers;
        private MetroFramework.Controls.MetroTextBox TxtRentalIdx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView DgvResult;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime Dtprentaldate;
        private MetroFramework.Controls.MetroDateTime Dtpreturndate;
        private System.Windows.Forms.TextBox textnames;
        private System.Windows.Forms.TextBox textmembers;
        private System.Windows.Forms.Button btnserachmember;
        private System.Windows.Forms.Button btnsearhbook;
    }
}