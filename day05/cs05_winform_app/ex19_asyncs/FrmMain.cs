namespace ex19_asyncs
{
    public partial class FrmMain : Form
    {

        #region "생성자, 초기화 영역"
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region "이벤트 핸들러 영역"
        // 이벤트 핸들러. 복사할 원본파일 선택
        private void btngetsource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                txtsource.Text = ofd.FileName;
            }
        }

        // 이벤트 핸들러. 붙여넣기할 타겟 파일 지정
        private void btngetsettarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                target.Text = ofd.FileName;
            }
        }

        // 이벤트 핸들러. 동기화 복사 처리
        private void btnsynccopy_Click(object sender, EventArgs e)
        {
            long result = CopySync(txtsource.Text,target.Text);
        }

        // 이벤트 핸들러. 비동기 복사 진행
        private async void btnasyncopy_Click(object sender, EventArgs e)
        {
            long result = await CopyAsync(txtsource.Text, target.Text);
        }
        
        // 버튼 클릭 이벤트 핸들러. 복사 취소 처리
        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI반응 테스트 완료!");
        }
        #endregion

        #region "사용자 메서드"

        long CopySync(string srcPath, string destPath)
        {
            // 버튼 사용 비활성화
            btnsynccopy.Enabled = false;
            btnasyncopy.Enabled = false;

            long totalCopied = 0;
            // file은 open()하면 반드시 close()해야함. using을 쓰면 close() C#이 알아서 해줌
            // 파일 입출력
            using (FileStream fromstream = new FileStream(srcPath, FileMode.Open)) 
            {   // 원래 존재하는 파일을 여니까 filemode.open
                using (FileStream toStream = new FileStream(destPath, FileMode.Create))
                {   // 존재하지 않는 파일을 만드니까 filemode.create
                    // 1MByte 버퍼를 생성
                    byte[] buffer = new byte[1024 * 1024]; // 1024(byte)
                    // fromStream에 들어온 파일을 1MB씩 잘라서 버퍼에 담은다음
                    // toStream에 1MB씩 붙여넣음
                    int nRead = 0;
                    while((nRead = fromstream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead; // 전체 복사 사이즈를 계속 증가

                        // 프로그레스바에 진행사항을 표시
                        prgcopy.Value = (int)((double)(totalCopied / fromstream.Length) * 100);
                    }
                }
            }
            btnsynccopy.Enabled = btnasyncopy.Enabled = true;
            return totalCopied;
        }

        // 비동기처리시 async, await 키워드가 가장 중요 
        // async는 '나는 비동기 메서드야' 라고 정의
        // await는 '나는 비동기 메서드가 끝날때 까지 기다릴께'라고 정의 
        // 비동기를 처리하는 메서드 명이 ...Ayuc로 끝남 
        // async는 메서드 리턴값에 작성, 리턴값은 Task<리턴값>
        async Task<long> CopyAsync(string srcPath, string destPath)
        {
            // 버튼 사용 비활성화
            btnsynccopy.Enabled = false;
            btnasyncopy.Enabled = false;

            long totalCopied = 0;
            using (FileStream fromstream = new FileStream(srcPath, FileMode.Open))
            {  
                using (FileStream toStream = new FileStream(destPath, FileMode.Create))
                {   
                    byte[] buffer = new byte[1024 * 1024]; // 1024(byte)  // 테스트시 10으로 변경 
                    int nRead = 0;
                    while ((nRead =await fromstream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead; 

                        
                        prgcopy.Value = (int)((double)(totalCopied / fromstream.Length) * 100);
                    }
                }
            }
            btnsynccopy.Enabled = btnasyncopy.Enabled = true;
            return totalCopied;
        }
    }

        #endregion
    
}
