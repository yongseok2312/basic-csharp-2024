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
    public partial class FrmLoginUser : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        string connString = "Data Source=localhost;" +
                                     "Initial Catalog=BookRentalShop2024;" +
                                     "Persist Security Info=True;" +
                                     "User ID=sa;Encrypt=False;" +
                                     "Password=mssql_p@ss";
        public FrmLoginUser()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            ReFreshData();
            /*using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT useridx
                                ,userid
                                ,[password]
                                ,lastLoginDataTime
                                FROM usertbl";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "usertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "사용자 순번";
                DgvResult.Columns[1].HeaderText = "사용자 아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막 로그인 날짜";

            }*/
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            TxtUserIdx.Focus();
            TxtUserIdx.ReadOnly = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5hash = MD5.Create();
            // 입력검증(Valdiation Check), 이름, 패스워드를 넣지 안넣으면
            
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("사용자 아이디를 입력하세요");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    var query = "";
                    if (isNew) // Insert이면
                    {
                        query = @"INSERT INTO usertbl
                                         (
                                          userid
                                          ,[password]
                                          )
                                            VALUES
                                            (
                                            @userid
                                            ,@password
                                             )";
                    }
                    else
                    {
                        query = @"UPDATE usertbl
                             SET userid = @userid
                                  ,[password] = @password
                            WHERE useridx = @useridx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isNew == false)
                    {
                        SqlParameter prmUserIdx = new SqlParameter("@useridx", TxtUserIdx.Text);
                        cmd.Parameters.Add(prmUserIdx);
                    }
                    SqlParameter prmUserId = new SqlParameter("@userid", TxtUserId.Text);
                    SqlParameter prmPassword = new SqlParameter("@password", GetMd5Hash(md5hash,TxtPassword.Text));
                    // Command에 Parameter를 연결해줘야 함!
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmPassword);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {   // this 메시지박스의 부모 창이 누구냐, FrmLoginuser
                        MetroMessageBox.Show(this, "저장 성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            ReFreshData();
        }
        private void ReFreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT useridx
                                ,userid
                                ,[password]
                                ,lastLoginDataTime
                                FROM usertbl";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "usertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "사용자 순번";
                DgvResult.Columns[1].HeaderText = "사용자 아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막 로그인 날짜";

            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserIdx.Text)) // 사용자 아이디 순번이 없으면
            {
                MetroMessageBox.Show(this, "삭제할 사용자를 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var query = @"DELETE FROM usertbl WHERE useridx = @useridx";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@useridx", TxtUserIdx.Text);
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제 성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("삭제 실패", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;

            ReFreshData();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택 안할시 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtUserIdx.Text = selData.Cells[0].Value.ToString();
                TxtUserIdx.ReadOnly = true;
                TxtUserId.Text = selData.Cells[1].Value.ToString() ;
                TxtPassword.Text = selData.Cells[2].Value.ToString() ;

                isNew = false; // Update
            }
        }

        // MD5 해시 알고리즘 암호화
        string GetMd5Hash(MD5 md5hash, string input)
        {
            // 입력문자열을 byte배열로 변환한 뒤 MD5 해시 처리
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i< data.Length; i++)
            {
                builder.Append(data[i].ToString("X2")); // 16진수 문자로 각 글자를 전부 변환
            }

            return builder.ToString();
        }
    }


}
