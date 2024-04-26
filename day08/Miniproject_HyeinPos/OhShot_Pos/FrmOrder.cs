using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhShot_Pos
{
    public partial class FrmOrder : Form
    {
        
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            tableNum.Text = string.Empty;
            tableNum.Text = "Table 1";
            nowDateTIme.Text = DateTime.Now.ToString("T");
            totalPrice.Text = string.Empty;
            
            RefreshData();
        }
                        
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                      [menuName]
                                      ,[menuPrice]
                                      ,[menunum]
                                  FROM [table1]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table1");
                    dataGridView1.DataSource = ds.Tables["table1"];
                    dataGridView1.Columns[0].HeaderText = "메뉴";
                    dataGridView1.Columns[1].HeaderText = "가격";
                    dataGridView1.Columns[2].HeaderText = "수량";

                    
                    decimal totalMenuPrice = sumprice(conn);
                    totalPrice.Text = totalMenuPrice.ToString("C");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            
        }


        #region '주문하기' 버튼 클릭 이벤트 핸들러 
        private void OrderBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region '품목제거' 버튼 클릭 이벤트 핸들러 
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string menuName = selectedRow.Cells["menuName"].Value.ToString(); // 메뉴 이름 가져오기
                DeleteMenu(menuName);
                RefreshData();
            }
            else
            {
                MessageBox.Show("삭제할 품목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region '단품취소' 버튼 클릭 이벤트 핸들러
        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region '전체취소' 버튼 클릭 이벤트 핸들러
        private void AllCancelBtn_Click(object sender, EventArgs e)
        {
            Alldelete();
            RefreshData();
        }


        #endregion


        private bool CheckIfMenuExists(SqlConnection conn, string menuName) // 동일한 메뉴이름이 확인
        {
            string query = "SELECT COUNT(*) FROM [table1] WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@menuName", menuName);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        private void IncreaseMenuQuantity(SqlConnection conn, string menuName) // 수량 증가
        {
            string query = "UPDATE [table1] SET [menunum] = [menunum] + 1 WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@menuName", menuName);

            cmd.ExecuteNonQuery();
        }

        private void AddNewMenu(SqlConnection conn, string menuName, int menuPrice, int menuQuantity) // 메뉴 추가
        {
            string query = @"INSERT INTO [table1] ([menuName], [menuPrice], [menunum]) VALUES (@menuName, @menuPrice, @menuQuantity)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.Parameters.AddWithValue("@menuPrice", menuPrice);
            cmd.Parameters.AddWithValue("@menuQuantity", menuQuantity);

            cmd.ExecuteNonQuery();
        }
        #region "메뉴"
        private void BtnSalmonRice_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                bool isRamenExists = CheckIfMenuExists(conn, "연어덮밥");
                if (isRamenExists)
                {
                    // '라면' 메뉴가 이미 테이블에 존재하면 수량을 증가시킴
                    IncreaseMenuQuantity(conn, "연어덮밥");
                }
                else
                {
                    // '라면' 메뉴가 테이블에 없으면 새로 추가
                    AddNewMenu(conn, "연어덮밥", 15000, 1); // 메뉴명, 가격, 수량
                }
                RefreshData();

            }
        }
        private void BtnNuddle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                bool isRamenExists = CheckIfMenuExists(conn, "라면");
                if (isRamenExists)
                {
                    // '라면' 메뉴가 이미 테이블에 존재하면 수량을 증가시킴
                    IncreaseMenuQuantity(conn, "라면");
                }
                else
                {
                    // '라면' 메뉴가 테이블에 없으면 새로 추가
                    AddNewMenu(conn, "라면", 2000, 1); // 메뉴명, 가격, 수량
                }
                RefreshData();

            }
        }

        private void Btncoffee_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                bool isRamenExists = CheckIfMenuExists(conn, "커피");
                if (isRamenExists)
                {
                    // '라면' 메뉴가 이미 테이블에 존재하면 수량을 증가시킴
                    IncreaseMenuQuantity(conn, "커피");
                }
                else
                {
                    // '라면' 메뉴가 테이블에 없으면 새로 추가
                    AddNewMenu(conn, "커피", 3000, 1); // 메뉴명, 가격, 수량
                }
                RefreshData();

            }
        }

        private void BtnEggRice_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                bool isRamenExists = CheckIfMenuExists(conn, "계란볶음밥");
                if (isRamenExists)
                {
                    // '라면' 메뉴가 이미 테이블에 존재하면 수량을 증가시킴
                    IncreaseMenuQuantity(conn, "계란볶음밥");
                }
                else
                {
                    // '라면' 메뉴가 테이블에 없으면 새로 추가
                    AddNewMenu(conn, "계란볶음밥", 6500, 1); // 메뉴명, 가격, 수량
                }
                RefreshData();

            }

            
        }
        #endregion

        private int sumprice(SqlConnection conn)
        {
            int totalMenuPrice = 0;
            string query = @"SELECT SUM([menuPrice]) AS TotalMenuPrice FROM table1";
            SqlCommand cmd = new SqlCommand(query, conn);
            object result = cmd.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out totalMenuPrice))
            {
                return totalMenuPrice;
            }
            else
            {
                return 0;
            }

        }

        private void Alldelete()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                try
                {
                    conn.Open();
                    string query = @"DELETE
                                  FROM [table1]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table1");
                    dataGridView1.DataSource = ds.Tables["table1"];
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        
        private void DeleteMenu(string menuName)
        {
            using(SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                string query = @"Delete FROM [table1] WHERE [menuName] = @menuName ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@menuName", menuName);
                cmd.ExecuteNonQuery();

            }
        }
    }


}
