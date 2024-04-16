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
            FrmModal.ShowDialog(); // 모달창 띄우기

        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "모달창";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.Show();
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
            if(PicNomal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNomal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            { PicNomal.SizeMode = PictureBoxSizeMode.Normal; }
        }
    }

}
