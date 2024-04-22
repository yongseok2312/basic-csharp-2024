namespace NewBookRentalShopAp
{
    partial class FrmLoginUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtUserIdx = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserId = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvResult);
            this.panel1.Location = new System.Drawing.Point(37, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 366);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(376, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 366);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUserId);
            this.groupBox1.Controls.Add(this.TxtUserIdx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인사용자 입력항목";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "사용자 번호";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "사용자 아이디";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "패스워드";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtUserIdx
            // 
            // 
            // 
            // 
            this.TxtUserIdx.CustomButton.Image = null;
            this.TxtUserIdx.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtUserIdx.CustomButton.Name = "";
            this.TxtUserIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserIdx.CustomButton.TabIndex = 1;
            this.TxtUserIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserIdx.CustomButton.UseSelectable = true;
            this.TxtUserIdx.CustomButton.Visible = false;
            this.TxtUserIdx.Lines = new string[0];
            this.TxtUserIdx.Location = new System.Drawing.Point(127, 38);
            this.TxtUserIdx.MaxLength = 32767;
            this.TxtUserIdx.Name = "TxtUserIdx";
            this.TxtUserIdx.PasswordChar = '\0';
            this.TxtUserIdx.PromptText = "사용자 번호 입력";
            this.TxtUserIdx.ReadOnly = true;
            this.TxtUserIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserIdx.SelectedText = "";
            this.TxtUserIdx.SelectionLength = 0;
            this.TxtUserIdx.SelectionStart = 0;
            this.TxtUserIdx.ShortcutsEnabled = true;
            this.TxtUserIdx.Size = new System.Drawing.Size(217, 23);
            this.TxtUserIdx.TabIndex = 3;
            this.TxtUserIdx.UseSelectable = true;
            this.TxtUserIdx.WaterMark = "사용자 번호 입력";
            this.TxtUserIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserIdx.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtUserId
            // 
            // 
            // 
            // 
            this.TxtUserId.CustomButton.Image = null;
            this.TxtUserId.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtUserId.CustomButton.Name = "";
            this.TxtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserId.CustomButton.TabIndex = 1;
            this.TxtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserId.CustomButton.UseSelectable = true;
            this.TxtUserId.CustomButton.Visible = false;
            this.TxtUserId.Lines = new string[0];
            this.TxtUserId.Location = new System.Drawing.Point(127, 72);
            this.TxtUserId.MaxLength = 32767;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.PasswordChar = '\0';
            this.TxtUserId.PromptText = "사용자 아이디 입력";
            this.TxtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserId.SelectedText = "";
            this.TxtUserId.SelectionLength = 0;
            this.TxtUserId.SelectionStart = 0;
            this.TxtUserId.ShortcutsEnabled = true;
            this.TxtUserId.Size = new System.Drawing.Size(217, 23);
            this.TxtUserId.TabIndex = 4;
            this.TxtUserId.UseSelectable = true;
            this.TxtUserId.WaterMark = "사용자 아이디 입력";
            this.TxtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserId.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(127, 106);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.PromptText = "패스워드 입력";
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(217, 23);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMark = "패스워드 입력";
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(127, 144);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(66, 32);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(203, 144);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(66, 32);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(279, 144);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(66, 32);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(332, 366);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // FrmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLoginUser";
            this.Text = "로그인 사용자";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTextBox TxtUserId;
        private MetroFramework.Controls.MetroTextBox TxtUserIdx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView DgvResult;
    }
}