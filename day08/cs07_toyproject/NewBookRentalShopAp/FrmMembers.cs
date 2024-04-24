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
    public partial class FrmMembers : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            ReFreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
            
        }

        private void InitInputData()
        {
            /*var temp = new Dictionary<string, string>();
              temp.Add("A", "A");
              temp.Add("B", "B");
              temp.Add("C", "C");
              temp.Add("D", "D");

              CboLevels.DataSource = new BindingSource(temp, null);
              CboLevels.DisplayMember = "Value";
              CboLevels.ValueMember = "key";
              CboLevels.SelectedIndex = -1;*/
            try
             {

                 using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                 {
                     conn.Open();
                     var query = @"select distinct Levels,
	                                        Levels
                                        from membertbl";
                     SqlCommand cmd = new SqlCommand(query, conn);
                     SqlDataReader reader = cmd.ExecuteReader();
                     var temp = new Dictionary<string, string>();

                     while (reader.Read()) 
                     {
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }

                    CboLevels.DataSource = new BindingSource(temp,null);
                     CboLevels.DisplayMember = "Value";
                     CboLevels.ValueMember = "key";
                     CboLevels.SelectedIndex = -1;

                 }
             }
             catch { }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtMemberidx.Text = TxtNames.Text  = string.Empty;
            TxtNames.Focus();
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("회원명을 입력하세요.");
                return;
            }

            // 콤보박스는 SelectedIndex가 -1이 되면 안됨
            if (CboLevels.SelectedIndex < 0)
            {
                MessageBox.Show("등급을 입력하세요");
                return;
            }

            if (string.IsNullOrEmpty(TxtAddr.Text))
            {
                MessageBox.Show("주소을 입력하세요");
                return;
            }
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("이메일을 입력하세요");
                return;
            }
            if (string.IsNullOrEmpty(TxtBobile.Text))
            {
                MessageBox.Show("전화번호를 입력하세요");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    conn.Open();
                    var query = "";
                    if (isNew) // Insert이면
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                                       ([Names]
                                                       ,[Levels]
                                                       ,[Addr]
                                                       ,[Mobile]
                                                       ,[Email])
                                                 VALUES
                                                       (@Names
                                                       ,@Levels
                                                       ,@Addr
                                                       ,@Mobile
                                                       ,@Email)";
                    }
                    else
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                               SET [Names] = @Names
                                                  ,[Levels] = @Levels
                                                  ,[Addr] = @Addr
                                                  ,[Mobile] = @Mobile
                                                  ,[Email] = @Email
                                             WHERE memberIdx = @memberIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
  
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);    
                    cmd.Parameters.Add(prmNames);  
                    SqlParameter prmLevels = new SqlParameter("@Levels", CboLevels.SelectedValue); 
                    cmd.Parameters.Add(prmLevels);    
                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtAddr.Text);
                    cmd.Parameters.Add(prmAddr);
                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtBobile.Text);
                    cmd.Parameters.Add(prmMobile);
                    SqlParameter prmEmail = new SqlParameter("@Email", TxtEmail.Text);
                    cmd.Parameters.Add(prmEmail);
                    if(isNew == false)
                    {
                        SqlParameter prmBookid = new SqlParameter("@bookIdx", TxtMemberidx.Text);   
                        cmd.Parameters.Add(prmBookid);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {   // this 메시지박스의 부모 창이 누구냐, FrmMembers
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

            TxtMemberidx.Text = TxtNames.Text  = string.Empty;
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            
            ReFreshData();
        }
        private void ReFreshData()

        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();

                var query = @"SELECT [memberIdx]
                                          ,[Names]
                                          ,[Levels]
                                          ,[Addr]
                                          ,[Mobile]
                                          ,[Email]
                                      FROM [membertbl];";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "membertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "회원순번";
                DgvResult.Columns[1].HeaderText = "회원명";
                DgvResult.Columns[2].HeaderText = "등급";
                DgvResult.Columns[3].HeaderText = "주소";
                DgvResult.Columns[4].HeaderText = "전화번호";
                DgvResult.Columns[5].HeaderText = "Email";
                
                // 각 컬럼 넓이 지정
                DgvResult.Columns[0].Width = 100;
                DgvResult.Columns[1].Width = 100;
                DgvResult.Columns[2].Width = 60;
                DgvResult.Columns[3].Width = 140;
                DgvResult.Columns[4].Width = 135;
                DgvResult.Columns[5].Width = 135;
                

            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMemberidx.Text)) // 사용자 아이디 순번이 없으면
            {
                MetroMessageBox.Show(this, "삭제할 회원을 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                var query = @"DELETE FROM membertbl WHERE memberIdx = @memberIdx";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@memberIdx", TxtMemberidx.Text);
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
            TxtMemberidx.Text = TxtNames.Text = string.Empty;

            ReFreshData();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택 안할시 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtMemberidx.Text = selData.Cells[0].Value.ToString();
                TxtMemberidx.ReadOnly = true;
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevels.SelectedValue = selData.Cells[2].Value;
                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtBobile.Text = selData.Cells[4].Value.ToString();
                // 거의 모든 타입에 *.parse(string) 존재
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                isNew = false; // Update

                
            }
        }

    }


}
