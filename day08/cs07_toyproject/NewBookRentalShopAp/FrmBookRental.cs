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
    public partial class FrmBookRental : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmBookRental()
        {
            InitializeComponent();
        }

        private void FrmBookRental_Load(object sender, EventArgs e)
        {
            ReFreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
            
        }

        private void InitInputData()
        {
            try
            {
     
                    
     
            }
            catch { }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtRentalIdx.Text = TxtMembers.Text  = string.Empty;
            textmembers.Text = textnames.Text = TxtNames.Text = string.Empty;   
            TxtMembers.Focus();
            Dtprentaldate.Value = Dtpreturndate.Value =  DateTime.Now;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(Valdiation Check), 이름, 패스워드를 넣지 안넣으면
            
            if (string.IsNullOrEmpty(TxtMembers.Text))
            {
                MessageBox.Show("회원명을 선택하세요.");
                return;
            }


            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("책을 선택하세요");
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
                        query = @"INSERT INTO [rentaltbl]
                                               ([memberIdx]
                                               ,[bookIdx]
                                               ,[rentalDate]
                                               ,[returnDate])
                                         VALUES
                                               (@memberIdx
                                               ,@bookIdx
                                               ,@rentalDate
                                               ,@returnDate)";
                    }
                    else
                    {
                        query = @"UPDATE [rentaltbl]
                                       SET [memberIdx] = @memberIdx
                                          ,[bookIdx] = @bookIdx
                                          ,[rentalDate] = @rentalDate
                                          ,[returnDate] = @returnDate
                                     WHERE rentalIdx = @rentalIdx ";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
  
                    SqlParameter prmmemberIdx = new SqlParameter("@memberIdx", textmembers.Text);    
                    cmd.Parameters.Add(prmmemberIdx);  
                    SqlParameter prmNames = new SqlParameter("@bookIdx", textnames.Text);
                    cmd.Parameters.Add(prmNames);
                    SqlParameter prmrentalDate = new SqlParameter("@rentalDate", Dtprentaldate.Text);
                    cmd.Parameters.Add(prmrentalDate);
                    var returnDate = ""; // 반납 날짜 때문에 추가 처리
                    if(Dtpreturndate.Value <= Dtprentaldate.Value) { returnDate = ""; }
                    else{ returnDate = Dtpreturndate.Value.ToString("yyyy-MM-dd"); }
                    SqlParameter prmReturnDate = new SqlParameter("@returnDate", Dtpreturndate.Text);
                    cmd.Parameters.Add(prmReturnDate);


                    if (isNew == false)
                    {
                        SqlParameter prmrentalIdx = new SqlParameter("@rentalIdx", TxtRentalIdx.Text);   
                        cmd.Parameters.Add(prmrentalIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {   // this 메시지박스의 부모 창이 누구냐, FrmBookRental
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

            TxtRentalIdx.Text = TxtMembers.Text  = string.Empty;
            Dtprentaldate.Value = DateTime.Now;   
            ReFreshData();
        }
        private void ReFreshData()

        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();

                var query = @"SELECT r.rentalIdx
                                              ,r.memberIdx
	                                          ,m.Names AS memNames
                                              ,r.bookIdx
	                                          ,b.Names AS booknames
                                              ,r.rentalDate
                                              ,r.returnDate
                                          FROM rentaltbl AS r
                                          JOIN membertbl AS m
                                          ON r.memberIdx = m.memberIdx
                                          JOIN bookstbl AS b
                                          ON r.bookIdx = b.bookIdx
                                        ;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "rentaltbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "대출순번";
                DgvResult.Columns[1].HeaderText = "회원번호";
                DgvResult.Columns[2].HeaderText = "회원명";
                DgvResult.Columns[3].HeaderText = "책번호";
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "대출일";
                DgvResult.Columns[6].HeaderText = "반납일";
                DgvResult.Columns[0].Width = 80;
                DgvResult.Columns[1].Visible = false;
                DgvResult.Columns[2].Width = 70;
                DgvResult.Columns[3].Visible = false;
                DgvResult.Columns[4].Width = 160;
                DgvResult.Columns[5].Width = 130;
                DgvResult.Columns[6].Width = 130;

            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택 안할시 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtRentalIdx.Text = selData.Cells[0].Value.ToString();
                TxtRentalIdx.ReadOnly = true;
                TxtMembers.Text = selData.Cells[2].Value.ToString() ;
                TxtNames.Text = selData.Cells[4].Value.ToString() ;
                textnames.Text = selData.Cells[3].Value.ToString();
                textmembers.Text = selData.Cells[1].Value.ToString();
                Dtprentaldate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());
                Dtpreturndate.Value = !string.IsNullOrEmpty(selData.Cells[6].Value.ToString())?
                    DateTime.Parse(selData.Cells[6].Value.ToString()) : 
                    DateTime.Parse("1800-01-01");
                // 거의 모든 타입에 *.parse(string) 존재
                isNew = false; // Update

            }
        }

        private void btnserachmember_Click(object sender, EventArgs e)
        {
            popMember popup = new popMember();
            popup.StartPosition = FormStartPosition.CenterParent;
           if( popup.ShowDialog() == DialogResult.Yes)
            {
                textmembers.Text = Helper.Common.SelMemberIdx;
                TxtMembers.Text = Helper.Common.SelMemberName;
                
            }    
        }

        private void btnsearhbook_Click(object sender, EventArgs e)
        {
            popBook popup = new popBook();
            popup.StartPosition = FormStartPosition.CenterParent;
            if (popup.ShowDialog() == DialogResult.Yes)
            {
                textnames.Text = Helper.Common.SelBookIdx;
                TxtNames.Text = Helper.Common.SelBookName;

            }
        }
    }


}
