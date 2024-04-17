namespace ex19_asyncs
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            prgcopy = new ProgressBar();
            btncancel = new Button();
            btnasyncopy = new Button();
            btnsynccopy = new Button();
            btngetsettarget = new Button();
            btngetsource = new Button();
            target = new TextBox();
            txtsource = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(prgcopy);
            groupBox1.Controls.Add(btncancel);
            groupBox1.Controls.Add(btnasyncopy);
            groupBox1.Controls.Add(btnsynccopy);
            groupBox1.Controls.Add(btngetsettarget);
            groupBox1.Controls.Add(btngetsource);
            groupBox1.Controls.Add(target);
            groupBox1.Controls.Add(txtsource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // prgcopy
            // 
            prgcopy.Location = new Point(30, 148);
            prgcopy.Name = "prgcopy";
            prgcopy.Size = new Size(293, 23);
            prgcopy.TabIndex = 9;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(248, 100);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(103, 30);
            btncancel.TabIndex = 8;
            btncancel.Text = "취소";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnasyncopy
            // 
            btnasyncopy.Location = new Point(127, 100);
            btnasyncopy.Name = "btnasyncopy";
            btnasyncopy.Size = new Size(103, 30);
            btnasyncopy.TabIndex = 7;
            btnasyncopy.Text = "비동기화 복사";
            btnasyncopy.UseVisualStyleBackColor = true;
            btnasyncopy.Click += btnasyncopy_Click;
            // 
            // btnsynccopy
            // 
            btnsynccopy.Location = new Point(6, 100);
            btnsynccopy.Name = "btnsynccopy";
            btnsynccopy.Size = new Size(103, 30);
            btnsynccopy.TabIndex = 6;
            btnsynccopy.Text = "동기화 복사";
            btnsynccopy.UseVisualStyleBackColor = true;
            btnsynccopy.Click += btnsynccopy_Click;
            // 
            // btngetsettarget
            // 
            btngetsettarget.Location = new Point(292, 66);
            btngetsettarget.Name = "btngetsettarget";
            btngetsettarget.Size = new Size(50, 23);
            btngetsettarget.TabIndex = 5;
            btngetsettarget.Text = "...";
            btngetsettarget.UseVisualStyleBackColor = true;
            btngetsettarget.Click += btngetsettarget_Click;
            // 
            // btngetsource
            // 
            btngetsource.Location = new Point(292, 28);
            btngetsource.Name = "btngetsource";
            btngetsource.Size = new Size(50, 23);
            btngetsource.TabIndex = 4;
            btngetsource.Text = "...";
            btngetsource.UseVisualStyleBackColor = true;
            btngetsource.Click += btngetsource_Click;
            // 
            // target
            // 
            target.Location = new Point(50, 66);
            target.Name = "target";
            target.ReadOnly = true;
            target.Size = new Size(236, 23);
            target.TabIndex = 3;
            // 
            // txtsource
            // 
            txtsource.Location = new Point(50, 35);
            txtsource.Name = "txtsource";
            txtsource.ReadOnly = true;
            txtsource.Size = new Size(236, 23);
            txtsource.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "타겟 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "소스 :";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 222);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "비동기 파일 복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btncancel;
        private Button btnasyncopy;
        private Button btnsynccopy;
        private Button btngetsettarget;
        private Button btngetsource;
        private TextBox target;
        private TextBox txtsource;
        private Label label2;
        private Label label1;
        private ProgressBar prgcopy;
    }
}
