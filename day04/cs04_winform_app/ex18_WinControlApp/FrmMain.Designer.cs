namespace ex18_WinControlApp
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
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFont = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            prgDummy = new ProgressBar();
            trB1 = new TrackBar();
            groupBox3 = new GroupBox();
            button1 = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddchild = new Button();
            btnaddroot = new Button();
            lsv = new ListView();
            trv = new TreeView();
            groupBox5 = new GroupBox();
            btnload = new Button();
            PicNomal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            GrbEditor = new GroupBox();
            btnfilesave = new Button();
            btnfileload = new Button();
            RtxEditor = new RichTextBox();
            groupBox6 = new GroupBox();
            stop = new Button();
            thread = new Button();
            nothread = new Button();
            prgpr = new ProgressBar();
            textBox1 = new TextBox();
            bgwprogress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trB1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNomal).BeginInit();
            GrbEditor.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFont);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("돋움", 9F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("돋움", 9F);
            TxtSampleText.Location = new Point(17, 68);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(362, 21);
            TxtSampleText.TabIndex = 2;
            TxtSampleText.Text = "Hello, C#!";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("돋움", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(295, 35);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(60, 16);
            ChkItalic.TabIndex = 1;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("돋움", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(222, 35);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 16);
            ChkBold.TabIndex = 1;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFont
            // 
            CboFont.Font = new Font("돋움", 9F);
            CboFont.FormattingEnabled = true;
            CboFont.Location = new Point(78, 33);
            CboFont.Name = "CboFont";
            CboFont.Size = new Size(121, 20);
            CboFont.TabIndex = 1;
            CboFont.SelectedIndexChanged += CboFont_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("돋움", 9F);
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(37, 12);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(prgDummy);
            groupBox2.Controls.Add(trB1);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // prgDummy
            // 
            prgDummy.Location = new Point(18, 62);
            prgDummy.Maximum = 20;
            prgDummy.Name = "prgDummy";
            prgDummy.Size = new Size(362, 23);
            prgDummy.TabIndex = 1;
            // 
            // trB1
            // 
            trB1.Location = new Point(6, 22);
            trB1.Maximum = 20;
            trB1.Name = "trB1";
            trB1.Size = new Size(383, 45);
            trB1.TabIndex = 0;
            trB1.Scroll += trB1_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(12, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 78);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스창";
            // 
            // button1
            // 
            button1.Location = new Point(303, 27);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(204, 27);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(86, 32);
            BtnMsgBox.TabIndex = 3;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(105, 27);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(86, 32);
            BtnModaless.TabIndex = 3;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(6, 27);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(86, 32);
            BtnModal.TabIndex = 3;
            BtnModal.Text = "modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddchild);
            groupBox4.Controls.Add(btnaddroot);
            groupBox4.Controls.Add(lsv);
            groupBox4.Controls.Add(trv);
            groupBox4.Location = new Point(11, 335);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(396, 182);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddchild
            // 
            BtnAddchild.Location = new Point(205, 147);
            BtnAddchild.Name = "BtnAddchild";
            BtnAddchild.Size = new Size(75, 23);
            BtnAddchild.TabIndex = 2;
            BtnAddchild.Text = "자식추가";
            BtnAddchild.UseVisualStyleBackColor = true;
            BtnAddchild.Click += BtnAddchild_Click;
            // 
            // btnaddroot
            // 
            btnaddroot.Location = new Point(19, 147);
            btnaddroot.Name = "btnaddroot";
            btnaddroot.Size = new Size(75, 23);
            btnaddroot.TabIndex = 2;
            btnaddroot.Text = "루트추가";
            btnaddroot.UseVisualStyleBackColor = true;
            btnaddroot.Click += btnaddroot_Click;
            // 
            // lsv
            // 
            lsv.Location = new Point(205, 22);
            lsv.Name = "lsv";
            lsv.Size = new Size(165, 119);
            lsv.TabIndex = 1;
            lsv.UseCompatibleStateImageBehavior = false;
            lsv.View = View.Details;
            // 
            // trv
            // 
            trv.Location = new Point(19, 22);
            trv.Name = "trv";
            trv.Size = new Size(165, 119);
            trv.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnload);
            groupBox5.Controls.Add(PicNomal);
            groupBox5.Location = new Point(418, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(338, 242);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽쳐박스";
            // 
            // btnload
            // 
            btnload.Location = new Point(267, 210);
            btnload.Name = "btnload";
            btnload.Size = new Size(65, 22);
            btnload.TabIndex = 1;
            btnload.Text = "로드";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // PicNomal
            // 
            PicNomal.BackColor = SystemColors.AppWorkspace;
            PicNomal.Location = new Point(4, 22);
            PicNomal.Name = "PicNomal";
            PicNomal.Size = new Size(332, 182);
            PicNomal.TabIndex = 0;
            PicNomal.TabStop = false;
            PicNomal.Click += PicNomal_Click;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // GrbEditor
            // 
            GrbEditor.Controls.Add(btnfilesave);
            GrbEditor.Controls.Add(btnfileload);
            GrbEditor.Controls.Add(RtxEditor);
            GrbEditor.Location = new Point(770, 12);
            GrbEditor.Name = "GrbEditor";
            GrbEditor.Size = new Size(377, 503);
            GrbEditor.TabIndex = 5;
            GrbEditor.TabStop = false;
            // 
            // btnfilesave
            // 
            btnfilesave.Location = new Point(289, 374);
            btnfilesave.Name = "btnfilesave";
            btnfilesave.Size = new Size(83, 35);
            btnfilesave.TabIndex = 1;
            btnfilesave.Text = "파일세이브";
            btnfilesave.UseVisualStyleBackColor = true;
            btnfilesave.Click += btnfilesave_Click;
            // 
            // btnfileload
            // 
            btnfileload.Location = new Point(196, 374);
            btnfileload.Name = "btnfileload";
            btnfileload.Size = new Size(83, 35);
            btnfileload.TabIndex = 1;
            btnfileload.Text = "파일로드";
            btnfileload.UseVisualStyleBackColor = true;
            btnfileload.Click += btnfileload_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.Location = new Point(5, 19);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(367, 349);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(stop);
            groupBox6.Controls.Add(thread);
            groupBox6.Controls.Add(nothread);
            groupBox6.Controls.Add(prgpr);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Location = new Point(418, 260);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(338, 257);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드워커";
            // 
            // stop
            // 
            stop.Location = new Point(266, 218);
            stop.Name = "stop";
            stop.Size = new Size(59, 33);
            stop.TabIndex = 2;
            stop.Text = "중지";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // thread
            // 
            thread.Location = new Point(194, 218);
            thread.Name = "thread";
            thread.Size = new Size(59, 33);
            thread.TabIndex = 2;
            thread.Text = "스레드";
            thread.UseVisualStyleBackColor = true;
            thread.Click += thread_Click;
            // 
            // nothread
            // 
            nothread.Location = new Point(122, 218);
            nothread.Name = "nothread";
            nothread.Size = new Size(59, 33);
            nothread.TabIndex = 2;
            nothread.Text = "노스레드";
            nothread.UseVisualStyleBackColor = true;
            nothread.Click += nothread_Click;
            // 
            // prgpr
            // 
            prgpr.Location = new Point(6, 188);
            prgpr.Name = "prgpr";
            prgpr.Size = new Size(323, 24);
            prgpr.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 160);
            textBox1.TabIndex = 0;
            // 
            // bgwprogress
            // 
            bgwprogress.DoWork += backgroundWorker1_DoWork;
            bgwprogress.ProgressChanged += backgroundWorker1_ProgressChanged;
            bgwprogress.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 527);
            Controls.Add(groupBox6);
            Controls.Add(GrbEditor);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trB1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNomal).EndInit();
            GrbEditor.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ChkBold;
        private ComboBox CboFont;
        private Label label1;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private GroupBox groupBox2;
        private ProgressBar prgDummy;
        private TrackBar trB1;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button button1;
        private GroupBox groupBox4;
        private Button BtnAddchild;
        private Button btnaddroot;
        private ListView lsv;
        private TreeView trv;
        private GroupBox groupBox5;
        private PictureBox PicNomal;
        private Button btnload;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEditor;
        private RichTextBox RtxEditor;
        private Button btnfilesave;
        private Button btnfileload;
        private GroupBox groupBox6;
        private ProgressBar prgpr;
        private TextBox textBox1;
        private Button stop;
        private Button thread;
        private Button nothread;
        private System.ComponentModel.BackgroundWorker bgwprogress;
    }
}
