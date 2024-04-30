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
        string menuName = string.Empty;
        private SqlConnection conn = null;
        private SqlTransaction transaction = null;

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
            TransactionStart();
            
            RefreshData();
        }
        #region "트랜잭션"
        private void TransactionStart()
        {
            conn = new SqlConnection(Helper.Common.connString);
            conn.Open();
            transaction = conn.BeginTransaction();
        }

        private void CommitTransaction()
        {
            transaction.Commit();
            conn.Close();
        }
        private void RollbackTransaction()
        {
            transaction.Rollback();
            conn.Close();
        }
        #endregion
                        
        private void RefreshData() // 초기 데이터
        {
            string query = @"SELECT [menuName], [menuPrice], [menunum] FROM [table1]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            decimal totalMenuPrice = CalculateTotalPrice();
            totalPrice.Text = totalMenuPrice.ToString("C");

        } 

        #region 버튼 클릭 이벤트 핸들러 
        // 돌아가기
        private void BackBtn_Click(object sender, EventArgs e) 
        {
            RollbackTransaction();
            this.Dispose();
        }
        // 결제하기
        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            CommitTransaction();
            this.Dispose();
        }
        // 주문하기
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            CommitTransaction();
            MessageBox.Show("주문이 완료되었습니다.");
            this.Dispose();
        }
        // 항목제거
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
        // 취소
        private void AllCancelBtn_Click(object sender, EventArgs e)
        {
            Alldelete();
            RefreshData();
        }
        // 수량감소
        private void Btnminusnum_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string menuName = selectedRow.Cells["menuName"].Value.ToString(); // 메뉴 이름 가져오기
                string menuNum = selectedRow.Cells["menunum"].Value.ToString(); // 메뉴 이름 가져오기
                MinuNum(menuName);
                if(menuNum == "1") { DeleteMenu(menuName);}
                RefreshData();
            }
            else
            {
                MessageBox.Show("삭제할 품목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private bool CheckIfMenuExists(string menuName) // 동일한 메뉴이름이 확인
        {
            string query = "SELECT COUNT(*) FROM [table1] WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn,transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        private void IncreaseMenuQuantity(string menuName)
        {
            string query = "UPDATE [table1] SET [menunum] = [menunum] + 1 WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }

        private void AddNewMenu(string menuName, int menuPrice, int menuQuantity)
        {
            string query = @"INSERT INTO [table1] ([menuName], [menuPrice], [menunum]) VALUES (@menuName, @menuPrice, @menuQuantity)";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.Parameters.AddWithValue("@menuPrice", menuPrice);
            cmd.Parameters.AddWithValue("@menuQuantity", menuQuantity);
            cmd.ExecuteNonQuery();
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalMenuPrice = 0;
            string query = @"SELECT SUM([menuPrice] * [menunum]) AS TotalMenuPrice FROM table1";

            // SqlCommand 객체 생성 시 트랜잭션을 전달
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                totalMenuPrice = Convert.ToDecimal(result);
            }

            return totalMenuPrice;
        }

        private void Alldelete()
        {
                string query = @"DELETE FROM [table1]";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.ExecuteNonQuery();
        }
        
        private void DeleteMenu(string menuName)
        {
            string query = @"DELETE FROM [table1] WHERE [menuName] = @menuName ";
            SqlCommand cmd = new SqlCommand(query, conn,transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }

        private void MinuNum(string menuName)
        {
            string query = "UPDATE [table1] SET [menunum] = [menunum] - 1 WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }


        #region "메뉴"
        private void BtnSalmonRice_Click(object sender, EventArgs e)
        {
            bool isSalmonExists = CheckIfMenuExists("연어덮밥");
            if (isSalmonExists)
            {
                IncreaseMenuQuantity("연어덮밥");
            }
            else
            {
                AddNewMenu("연어덮밥", 15000, 1); // 메뉴명, 가격, 수량
            }
            RefreshData();
        }
        private void BtnNuddle_Click(object sender, EventArgs e)
        {
            bool isRamenExists = CheckIfMenuExists("라면");
            if (isRamenExists)
            {
                // '라면' 메뉴가 이미 테이블에 존재하면 수량을 증가시킴
                IncreaseMenuQuantity("라면");
            }
            else
            {
                // '라면' 메뉴가 테이블에 없으면 새로 추가
                AddNewMenu( "라면", 2000, 1); // 메뉴명, 가격, 수량
            }
            RefreshData();
        }

        private void Btncoffee_Click(object sender, EventArgs e)
        {
            bool isCoffeeExists = CheckIfMenuExists("커피");
            if (isCoffeeExists)
            {
                IncreaseMenuQuantity( "커피");
            }
            else
            {
                AddNewMenu( "커피", 3000, 1); 
            }
            RefreshData();
        }

        private void BtnEggRice_Click(object sender, EventArgs e)
        {
            bool isEggRiceExists = CheckIfMenuExists("계란볶음밥");
            if (isEggRiceExists)
            {
                IncreaseMenuQuantity( "계란볶음밥");
            }
            else
            {
                AddNewMenu("계란볶음밥", 6500, 1); 
            }
            RefreshData();
        }
        #endregion
    }
}
