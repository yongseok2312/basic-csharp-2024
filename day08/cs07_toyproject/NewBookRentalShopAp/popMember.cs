using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NewBookRentalShopAp
{
    public partial class popMember : MetroForm
    {
        public popMember()
        {
            InitializeComponent();
        }

        private void popMember_Load(object sender, EventArgs e)
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

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvResult.SelectedRows == null)
            {
                MessageBox.Show("회원을 선택하세요");
                return;
            }

            var selData = DgvResult.SelectedRows[0];
            // MessageBox.Show(selData.Cells[0].Value.ToString() + selData.Cells[1].Value.ToString());
            Helper.Common.SelMemberIdx = selData.Cells[0].Value.ToString();
            Helper.Common.SelMemberName = selData.Cells[1].Value.ToString();

            this.DialogResult = DialogResult.Yes; // DialogResult 발생시킴
            this.Close();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
