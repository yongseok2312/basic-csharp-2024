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
    public partial class popBook : MetroForm
    {
        public popBook()
        {
            InitializeComponent();
        }

        private void popBook_Load(object sender, EventArgs e)
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

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvResult.SelectedRows == null)
            {
                MessageBox.Show("회원을 선택하세요");
                return;
            }

            var selData = DgvResult.SelectedRows[0];
            // MessageBox.Show(selData.Cells[0].Value.ToString() + selData.Cells[1].Value.ToString());
            Helper.Common.SelBookIdx = selData.Cells[0].Value.ToString();
            Helper.Common.SelBookName = selData.Cells[4].Value.ToString();

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
