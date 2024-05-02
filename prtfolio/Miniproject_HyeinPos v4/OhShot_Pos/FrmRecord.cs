using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhShot_Pos
{
    public partial class FrmRecord : Form
    {
        public FrmRecord()
        {
            InitializeComponent();
            InitInputData();
        }
       
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT Num
                                          ,menuName
                                          ,[menuPrice]
                                          ,[menunum]
                                          ,[DATE]
                                      FROM Alltable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Alltable");
                    DgvResult.DataSource = ds.Tables["Alltable"];
                    DgvResult.Columns[0].HeaderText = "순번";
                    DgvResult.Columns[1].HeaderText = "메뉴 이름";
                    DgvResult.Columns[2].HeaderText = "가격";
                    DgvResult.Columns[3].HeaderText = "수량";
                    DgvResult.Columns[4].HeaderText = "날짜";
                    DgvResult.Columns[0].Width = 60;
                    DgvResult.Columns[2].Width = 60;
                    DgvResult.Columns[3].Width = 60;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }

        private void InitInputData()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    conn.Open();
                    var query = @"select distinct menuName,
	                                        menuName
                                        from Alltable";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();

                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }

                    Cbomenuname.DataSource = new BindingSource(temp, null);
                    Cbomenuname.DisplayMember = "Value";
                    Cbomenuname.ValueMember = "key";
                    Cbomenuname.SelectedIndex = -1;

                }
            }
            catch { }
        }

        private void FrmRecord_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var seldata = DgvResult.Rows[e.RowIndex];
                TxtNum.Text = seldata.Cells[0].Value.ToString();
                Txtprice.Text = seldata.Cells[2].Value.ToString();
                Txtmenunum.Text = seldata.Cells[3].Value.ToString();
                Cbomenuname.SelectedValue = seldata.Cells[1].Value;
                Startdate.Text = seldata.Cells[4].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("정말 취소 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                var query = @"DELETE FROM Alltable WHERE NUM = @NUM"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmdiv = new SqlParameter("@NUM",TxtNum.Text); 
                cmd.Parameters.Add(prmdiv);

                var result = cmd.ExecuteNonQuery();
                if(result>0)
                {
                    MessageBox.Show("결제 취소되었습니다", "취소", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
    }
}
