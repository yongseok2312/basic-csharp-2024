namespace OhShot_Pos
{
    partial class FrmRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.Cbomenuname = new System.Windows.Forms.ComboBox();
            this.Txtprice = new System.Windows.Forms.TextBox();
            this.Txtmenunum = new System.Windows.Forms.TextBox();
            this.Startdate = new System.Windows.Forms.DateTimePicker();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "순번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "메뉴 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "수량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "기간";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(650, 89);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.ReadOnly = true;
            this.TxtNum.Size = new System.Drawing.Size(144, 21);
            this.TxtNum.TabIndex = 6;
            // 
            // Cbomenuname
            // 
            this.Cbomenuname.FormattingEnabled = true;
            this.Cbomenuname.Location = new System.Drawing.Point(649, 137);
            this.Cbomenuname.Name = "Cbomenuname";
            this.Cbomenuname.Size = new System.Drawing.Size(144, 20);
            this.Cbomenuname.TabIndex = 7;
            // 
            // Txtprice
            // 
            this.Txtprice.Location = new System.Drawing.Point(649, 185);
            this.Txtprice.Name = "Txtprice";
            this.Txtprice.ReadOnly = true;
            this.Txtprice.Size = new System.Drawing.Size(144, 21);
            this.Txtprice.TabIndex = 8;
            // 
            // Txtmenunum
            // 
            this.Txtmenunum.Location = new System.Drawing.Point(649, 233);
            this.Txtmenunum.Name = "Txtmenunum";
            this.Txtmenunum.ReadOnly = true;
            this.Txtmenunum.Size = new System.Drawing.Size(144, 21);
            this.Txtmenunum.TabIndex = 8;
            // 
            // Startdate
            // 
            this.Startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Startdate.Location = new System.Drawing.Point(650, 280);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(143, 21);
            this.Startdate.TabIndex = 9;
            this.Startdate.Value = new System.DateTime(2024, 5, 2, 0, 0, 0, 0);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(651, 329);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(144, 67);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "결제 취소";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvResult
            // 
            this.DgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(3, 17);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.ReadOnly = true;
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(520, 358);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvResult);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "리스트";
            // 
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 410);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.Startdate);
            this.Controls.Add(this.Txtmenunum);
            this.Controls.Add(this.Txtprice);
            this.Controls.Add(this.Cbomenuname);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRecord";
            this.Text = "결제목록";
            this.Activated += new System.EventHandler(this.FrmRecord_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.ComboBox Cbomenuname;
        private System.Windows.Forms.TextBox Txtprice;
        private System.Windows.Forms.TextBox Txtmenunum;
        private System.Windows.Forms.DateTimePicker Startdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}