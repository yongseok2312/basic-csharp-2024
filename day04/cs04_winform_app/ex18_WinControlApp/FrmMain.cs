using System.ComponentModel;
using System.Threading; // 스레드 클래스 사용등록

namespace ex18_WinControlApp
{
    public partial class FrmMain : Form
    {
        Random rand = new Random(); // 노드 트리뷰 랜덤값


        public FrmMain()
        {
            InitializeComponent(); // 디자이너에서 정의한 화면 구성 초기화

            lsv.Columns.Add("이름");
            lsv.Columns.Add("깊이");

            GrbEditor.Text = "텍스트 에디터";

        }

        // 글자체, 볼드, 이탤릭으로 변경하는 메서드
        void ChangeFont()
        {
            if (CboFont.SelectedIndex == 0) // 아무것도 선택 안됨
                return;

            FontStyle style = FontStyle.Regular; // 일반 글자(노멀)로 초기화
            if (ChkBold.Checked) style |= FontStyle.Bold;

            if (ChkItalic.Checked) style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFont.SelectedItem, 12, style);
        }

        void TreeToList()
        {
            lsv.Items.Clear();
            foreach (TreeNode node in trv.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            lsv.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode subnode in node.Nodes)
            {
                TreeToList(subnode);
            }
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 현재 OS내에 설치된 폰트를 가져옴
            foreach (var font in Fonts)
            {
                CboFont.Items.Add(font.Name);
            }
        }

        // trackbar scroll event handeller
        private void trB1_Scroll(object sender, EventArgs e)
        {
            prgDummy.Value = trB1.Value; // 트랙바 포인터를 옮기면 프로그레스바 값도 같이변경
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form FrmModal = new Form();
            FrmModal.Text = "모달창";
            FrmModal.Width = 300;
            FrmModal.Height = 100;
            FrmModal.BackColor = Color.Yellow;
            FrmModal.StartPosition = FormStartPosition.CenterParent;
            FrmModal.ShowDialog(); // 모달창 띄우기

        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "모달창";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.StartPosition = FormStartPosition.Manual;
            FrmModaless.Location = new Point(this.Location.X + (this.Width - FrmModaless.Width) / 2, this.Location.Y + (this.Height - FrmModaless.Height) / 2);
            FrmModaless.Show(this);
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtSampleText.Text, "메시지 박스", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("좋아요?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("네 좋아요~");

            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("너무 싫어요");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnaddroot_Click(object sender, EventArgs e)
        {
            trv.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnAddchild_Click(object sender, EventArgs e)
        {
            if (trv.SelectedNode == null) // 부모노드를 선택하지 않으면
            {
                MessageBox.Show("선택한 노드가 없음", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trv.SelectedNode.Nodes.Add(rand.Next().ToString());
            trv.SelectedNode.Expand();
            TreeToList(); // 리스뷰를 다시 그림
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            var res = DlgOpenImage.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                //MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNomal.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }
        }

        private void PicNomal_Click(object sender, EventArgs e)
        {
            if (PicNomal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNomal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            { PicNomal.SizeMode = PictureBoxSizeMode.Normal; }
        }

        // 텍스트 파일 로드 이벤트 핸들러
        private void btnfileload_Click(object sender, EventArgs e)
        {
            // OpenFileDialog 컨트롤을 디자인에서 구성하지 않고 생성하는 방법
            OpenFileDialog diaog = new OpenFileDialog();
            diaog.Multiselect = false;  // 여러개 파일 선택금지
            diaog.Filter = "Text Files(*.txt;*.cs;*.py)|*.txt;*.cs;*.py";
            if (diaog.ShowDialog() == DialogResult.OK)
            {
                // utf-8이 깨짐, EUC-KR(window 949), UTF-8 Bom은 한글 문제가 없음
                RtxEditor.LoadFile(diaog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // 텍스트 파일 저장 이벤트 핸들러
        private void btnfilesave_Click(object sender, EventArgs e)
        {
            SaveFileDialog diaog = new SaveFileDialog();
            diaog.Filter = "RichText Files(*.rtf)|*.rtf";
            if (diaog.ShowDialog(this) == DialogResult.OK)
            {
                RtxEditor.SaveFile(diaog.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }

        private void nothread_Click(object sender, EventArgs e)
        {
            // 프로그레스바 설정
            var maxValue = 100;
            var currValue = 0;
            prgpr.Minimum = 0;
            prgpr.Maximum = maxValue;
            prgpr.Value = 0; // 0으로 초기화

            thread.Enabled = false;
            nothread.Enabled = false;
            stop.Enabled = true;

            for (var i = 0; i <= maxValue; i++)
            {
                currValue = i;
                prgpr.Value = currValue;
                textBox1.AppendText($"현재진행 : {currValue}\r\n");
                Thread.Sleep(500);

            }
            thread.Enabled = nothread.Enabled = true;
            stop.Enabled = false;
        }

        private void thread_Click(object sender, EventArgs e)
        {
            var maxValue = 100;
            prgpr.Minimum = 0;
            prgpr.Maximum = maxValue;
            prgpr.Value = 0;

            thread.Enabled = false;
            nothread.Enabled = false;
            stop.Enabled = true;

            bgwprogress.WorkerReportsProgress = true;   // 진행사항 리포트 활성화
            bgwprogress.WorkerSupportsCancellation = true;  // 백그라운드 워커 취소
            bgwprogress.RunWorkerAsync(null);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            bgwprogress.CancelAsync(); // 비동기로 취소 실행!
        }

        #region '백그라운드 워커'
        private void DoRealWork(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var maxValue = 100;
            double currValue = 0; // 실수형으로 설정
            for (var i = 0;i <= maxValue;i++)
            {
                if (worker.CancellationPending) // 중간에 취소할건지 물어보는 것
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    currValue = i;
                    Thread.Sleep(500);

                    // 아래를 실행하면, BgwProgress_ProgressChanged 이벤트핸들러의
                    // ProgressChangedEventArgs내의 ProgressPercentage 속성에 값이 들어감
                    worker.ReportProgress((int)((currValue / maxValue) * 100));
                }
            }
        }
        // 일을 진행
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DoRealWork((BackgroundWorker)sender, e);
            e.Result = null;
        }

        // 진행상태 바뀌는 것 표시
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            prgpr.Value = e.ProgressPercentage;
            textBox1.AppendText($"진행률 : {prgpr.Value}%\r\n");
        }

        // 진행이 완료되면 그 이후 처리
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                textBox1.AppendText("작업이 취소되었습니다.\r\n");
            }
            else
            {
                textBox1.AppendText("작업이 완료되었습니다.\r\n");
            }

            nothread.Enabled = thread.Enabled = true;
            stop.Enabled = false;
        }
        #endregion
    }

}
