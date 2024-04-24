using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopAp
{
    public partial class FrmBookinfo : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmBookinfo()
        {
            InitializeComponent();
        }

        private void FrmBookinfo_Load(object sender, EventArgs e)
        {
            ReFreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
            
        }

        private void InitInputData()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    conn.Open();
                    var query = @"SELECT Division, Names FROM divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // sqlDataReader = 개발자가 하나씩 처리할 때
                    // sqlDataAdapter, Dataset = 한번에 데이터그리드뷰 등에 뿌릴 때
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();

                    while (reader.Read()) 
                    {
                        //reader[0] = Division 컬럼, reader [1] = Names 컬럼
                        
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }

                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "key";
                    CboDivision.SelectedIndex = -1;
                    
                }
            }
            catch { }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtNumber.Text = TxtAuthor.Text  = string.Empty;
            TxtAuthor.Focus();
            CboDivision.SelectedIndex = -1;
            TxtNames.Text = TxtISBN.Text = string.Empty;
            TdprealeaseDate.Value = DateTime.Now;
            numericUpDown1.Value = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(Valdiation Check), 이름, 패스워드를 넣지 안넣으면
            
            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("저자명을 입력하세요.");
                return;
            }

            // 콤보박스는 SelectedIndex가 -1이 되면 안됨
            if (CboDivision.SelectedIndex < 0)
            {
                MessageBox.Show("구분명을 입력하세요");
                return;
            }

            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("책제목을 입력하세요");
                return;
            }
            // 출판일은 기본적으로 오늘 날짜가 들어감
            // ISBN은 null값이어도 상관없음
            // 책가격은 기본 0

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    conn.Open();
                    var query = "";
                    if (isNew) // Insert이면
                    {
                        query = @"INSERT INTO [bookstbl]
                                               ([Author]
                                               ,[Division]
                                               ,[Names]
                                               ,[ReleaseDate]
                                               ,[ISBN]
                                               ,[Price])
                                         VALUES
                                               (@Author
                                               ,@Division
                                               ,@Names
                                               ,@ReleaseDate
                                               ,@ISBN
                                               ,@Price)";
                    }
                    else
                    {
                        query = @"UPDATE [bookstbl]
                                   SET [Author] = @Author
                                      ,[Division] = @Division
                                      ,[Names] = @Names
                                      ,[ReleaseDate] = @ReleaseDate
                                      ,[ISBN] = @ISBN
                                      ,[Price] = @Price
	                                WHERE bookIdx = @bookIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
  
                    SqlParameter prmAuthor = new SqlParameter("@Author", TxtAuthor.Text);    
                    cmd.Parameters.Add(prmAuthor);  
                    SqlParameter prmDivision = new SqlParameter("@Division", CboDivision.SelectedValue); 
                    cmd.Parameters.Add(prmDivision);    
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    cmd.Parameters.Add(prmNames);
                    SqlParameter prmDate = new SqlParameter("@ReleaseDate", TdprealeaseDate.Value);
                    cmd.Parameters.Add(prmDate);
                    SqlParameter prmISBN = new SqlParameter("@ISBN", TxtISBN.Text);
                    cmd.Parameters.Add(prmISBN);
                    SqlParameter prmPrice = new SqlParameter("@Price", numericUpDown1.Value);
                    cmd.Parameters.Add(prmPrice);
                    if(isNew == false)
                    {
                        SqlParameter prmBookid = new SqlParameter("@bookIdx", TxtNumber.Text);   
                        cmd.Parameters.Add(prmBookid);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {   // this 메시지박스의 부모 창이 누구냐, FrmBookinfo
                        MessageBox.Show( "저장 성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장 성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장 실패", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}","오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            TxtNumber.Text = TxtAuthor.Text  = string.Empty;
            CboDivision.SelectedIndex = -1;
            TxtNames.Text = TxtISBN.Text = string.Empty;
            TdprealeaseDate.Value = DateTime.Now;   
            numericUpDown1.Value = 0;
            ReFreshData();
        }
        private void ReFreshData()

        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();

                var query = @"SELECT b.[bookIdx]
                                      ,b.[Author]
                                      ,b.[Division]
                                      ,d.[Names] AS DivNames
	                                  ,b.[Names]
                                      ,b.[ReleaseDate]
                                      ,b.[ISBN]
                                      ,b.[Price]
                                  FROM [bookstbl] AS b
                                  JOIN divtbl AS d
                                  ON b.Division = d.Division;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookstbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "책순번";
                DgvResult.Columns[1].HeaderText = "저자명";
                DgvResult.Columns[2].HeaderText = "구분코드";
                DgvResult.Columns[3].HeaderText = "구분명";
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "출판일";
                DgvResult.Columns[6].HeaderText = "ISBN";
                DgvResult.Columns[7].HeaderText = "책가격";
                // 각 컬럼 넓이 지정
                DgvResult.Columns[0].Width = 69;
                DgvResult.Columns[1].Width = 145;
                DgvResult.Columns[2].Visible = false;
                DgvResult.Columns[3].Width = 80;
                DgvResult.Columns[4].Width = 160;
                DgvResult.Columns[5].Width = 80;
                DgvResult.Columns[6].Width = 80;
                DgvResult.Columns[7].Width = 80;

            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumber.Text)) // 사용자 아이디 순번이 없으면
            {
                MetroMessageBox.Show(this, "삭제할 책을 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                var query = @"DELETE FROM bookstbl WHERE bookIdx = @bookIdx";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@bookIdx", TxtNumber.Text);
                cmd.Parameters.Add(prmDivision);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("삭제 실패", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            TxtNumber.Text = TxtAuthor.Text = string.Empty;

            ReFreshData();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택 안할시 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtNumber.Text = selData.Cells[0].Value.ToString();
                TxtNumber.ReadOnly = true;
                TxtAuthor.Text = selData.Cells[1].Value.ToString() ;
                TxtNames.Text = selData.Cells[4].Value.ToString() ;
                TdprealeaseDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());
                // 거의 모든 타입에 *.parse(string) 존재
                TxtISBN.Text = selData.Cells[6].Value.ToString();
                numericUpDown1.Value = decimal.Parse(selData.Cells[7].Value.ToString());
                isNew = false; // Update

                CboDivision.SelectedValue = selData.Cells[2].Value; // 구분 코드로 선택해야함
            }
        }

        
        
    }


}
