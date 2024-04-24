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
    public partial class FrmBookDivision : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmBookDivision()
        {
            InitializeComponent();
        }

        private void FrmBookDivision_Load(object sender, EventArgs e)
        {
            ReFreshData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            Txtcode.Text = TxtNames.Text  = string.Empty;
            Txtcode.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(Valdiation Check), 이름, 패스워드를 넣지 안넣으면
            
            if (string.IsNullOrEmpty(Txtcode.Text))
            {
                MessageBox.Show("코드를 입력하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("장르를 입력하세요");
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
                        query = @"INSERT INTO divtbl
                                             (Division
                                                ,Names)
                                                VALUES
                                                (@Division
                                                ,@Names)";
                    }
                    else
                    {
                        query = @"UPDATE divtbl
                                    SET
                                    Names = @Names
                                   WHERE Division = @Division";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
  
                    SqlParameter prmDivision = new SqlParameter("@Division", Txtcode.Text);
                    cmd.Parameters.Add(prmDivision);
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    // Command에 Parameter를 연결해줘야 함!
                    cmd.Parameters.Add(prmNames);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {   // this 메시지박스의 부모 창이 누구냐, FrmBookDivision
                        ShowCustomMessageBox("저장 성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            Txtcode.Text = TxtNames.Text = string.Empty;
            ReFreshData();
        }
        private void ReFreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();

                var query = @"SELECT Division
                                    ,Names
                                FROM divtbl";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "구분코드";
                DgvResult.Columns[1].HeaderText = "구분명";

            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcode.Text)) // 사용자 아이디 순번이 없으면
            {
                MetroMessageBox.Show(this, "삭제할 책을 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                var query = @"DELETE FROM divtbl WHERE Division = @Division";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@Division", Txtcode.Text);
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
            Txtcode.Text = TxtNames.Text = string.Empty;

            ReFreshData();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택 안할시 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                Txtcode.Text = selData.Cells[0].Value.ToString();
                Txtcode.ReadOnly = true;
                TxtNames.Text = selData.Cells[1].Value.ToString() ;

                isNew = false; // Update
            }
        }

        private void ShowCustomMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            // 현재 폼을 부모로 설정하여 MetroMessageBox를 사용하여 메시지 박스 표시
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, message, caption, buttons, icon);

            // 생성된 메시지 박스를 중앙에 배치
            CenterMessageBox();
        }

        private void CenterMessageBox()
        {
            Form messageBoxForm = Application.OpenForms[Application.OpenForms.Count - 1]; // 마지막으로 열린 폼이 메시지 박스 폼

            // 부모 폼의 중앙에 메시지 박스 위치 설정
            int x = (this.Width - messageBoxForm.Width) / 2 + this.Location.X;
            int y = (this.Height - messageBoxForm.Height) / 2 + this.Location.Y;
            messageBoxForm.Location = new Point(x, y);
        }

    }


}
