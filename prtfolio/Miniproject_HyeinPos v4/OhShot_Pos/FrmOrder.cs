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
        private SqlConnection conn = null;
        private SqlTransaction transaction = null;
        private string tableName;
        public FrmOrder(string tableName)
        {
            InitializeComponent();
            this.tableName = tableName; // 전달받은 테이블 정보를 저장
            string formattedTableName = char.ToUpper(tableName[0]) + tableName.Substring(1);
            tableNum.Text = formattedTableName;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // 연결 초기화 및 연결 열기
            conn = new SqlConnection(Helper.Common.connString);
            conn.Open();
            TransactionStart();
            
            //tableNum.Text = "Table 1";
            nowDateTIme.Text = DateTime.Now.ToString("T");
            totalPrice.Text = string.Empty; 
            timer1.Interval = 1000; // 1초마다 갱신
            timer1.Start();

            RefreshData(tableName);
        }

        #region "트랜잭션"
        private void TransactionStart()
        {
            if (transaction != null)
            {
                transaction.Dispose();
            }

            // 연결이 열려 있을 때만 트랜잭션 시작
            if (conn.State == ConnectionState.Open)
            {
                transaction = conn.BeginTransaction();
            }
            else
            {
                MessageBox.Show("데이터베이스 연결에 문제가 있습니다.");
            }
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

        #region 뷰
        private void RefreshData(string tableName)
        {
            try
            {
                string query = $"SELECT [menuName], [menuPrice], [menunum] FROM [{tableName}]";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "table1");
                dataGridView1.DataSource = ds.Tables["table1"];
                dataGridView1.Columns[0].HeaderText = "메뉴";
                dataGridView1.Columns[1].HeaderText = "가격";
                dataGridView1.Columns[2].HeaderText = "수량";

                decimal totalMenuPrice = CalculateTotalPrice(tableName);
                totalPrice.Text = totalMenuPrice.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
            }
        }
        #endregion

        #region 버튼 클릭 이벤트 핸들러 
        private void BackBtn_Click(object sender, EventArgs e)
        {
            RollbackTransaction();
            this.Dispose();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("결제를 하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CommitTransaction();
                MessageBox.Show("결제가 완료되었습니다.");
                SqlConnection conn = new SqlConnection(Helper.Common.connString);
                conn.Open();
                string selectQuery = $"SELECT [menuName], [menuPrice], [menunum] FROM [{tableName}]";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, $"{tableName}");
                string insertQuery = @"INSERT INTO [Alltable]
                                ([menuName], [menuPrice], [menunum], [DATE])
                               VALUES (@menuName, @menuPrice, @menunum, @DATE)";
                foreach (DataRow row in dataSet.Tables[$"{tableName}"].Rows)
                {
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@menuName", row["menuName"]);
                    insertCmd.Parameters.AddWithValue("@menuPrice", row["menuPrice"]);
                    insertCmd.Parameters.AddWithValue("@menunum", row["menunum"]);
                    insertCmd.Parameters.AddWithValue("@DATE", DateTime.Now.ToString("g"));
                    insertCmd.ExecuteNonQuery();
                }
                SqlConnection last = new SqlConnection(Helper.Common.connString);
                last.Open();
                string query = $"DELETE FROM {tableName}";
                SqlCommand deletequery = new SqlCommand(query, conn);
                deletequery.ExecuteNonQuery();
            }
            this.Dispose();
            
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            CommitTransaction();
            MessageBox.Show("주문이 완료되었습니다.");
            this.Dispose();
            
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string menuName = selectedRow.Cells["menuName"].Value.ToString();
                DeleteMenu(menuName, tableName);
                RefreshData(tableName);

            }
            else
            {
                MessageBox.Show("삭제할 품목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AllCancelBtn_Click(object sender, EventArgs e)
        {
            Alldelete(tableName);
            RefreshData(tableName);

        }

        private void Btnminusnum_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string menuName = selectedRow.Cells["menuName"].Value.ToString();
                string menuNum = selectedRow.Cells["menunum"].Value.ToString();
                MinuNum(menuName,tableName);
                if (menuNum == "1") { DeleteMenu(menuName, tableName); }
                RefreshData(tableName);

            }
            else
            {
                MessageBox.Show("삭제할 품목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 상품 추가 제거 함수
        private bool CheckIfMenuExists(string menuName, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM [{tableName}] WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void IncreaseMenuQuantity(string menuName, string tableName)
        {
            string query = $"UPDATE [{tableName}] SET [menunum] = [menunum] + 1 WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }

        private void AddNewMenu(string menuName, int menuPrice, int menuQuantity,string tableName)
        {
            string query = $"INSERT INTO [{tableName}] ([menuName], [menuPrice], [menunum]) VALUES (@menuName, @menuPrice, @menuQuantity)";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.Parameters.AddWithValue("@menuPrice", menuPrice);
            cmd.Parameters.AddWithValue("@menuQuantity", menuQuantity);
            cmd.ExecuteNonQuery();
        }

        private decimal CalculateTotalPrice(string tableName)
        {
            decimal totalMenuPrice = 0;
            string query = $"SELECT SUM([menuPrice] * [menunum]) AS TotalMenuPrice FROM [{tableName}]";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                totalMenuPrice = Convert.ToDecimal(result);
            }

            return totalMenuPrice;
        }

        private void Alldelete(string tableName)
        {
            string query = $"DELETE FROM [{tableName}]";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.ExecuteNonQuery();
        }

        private void DeleteMenu(string menuName,string tableName)
        {
            string query = $"DELETE FROM [{tableName}] WHERE [menuName] = @menuName ";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }

        private void MinuNum(string menuName,string tableName)
        {
            
            string query = $"UPDATE [{tableName}] SET [menunum] = [menunum] - 1 WHERE [menuName] = @menuName";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@menuName", menuName);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region 메뉴 버튼
        private void BtnSalmonRice_Click(object sender, EventArgs e)
        {
            bool isSalmonExists = CheckIfMenuExists("연어덮밥",tableName);
            if (isSalmonExists)
            {
                IncreaseMenuQuantity("연어덮밥",tableName);
            }
            else
            {
                AddNewMenu("연어덮밥", 15000, 1,tableName);
            }
            RefreshData(tableName);

        }

        private void BtnNuddle_Click(object sender, EventArgs e)
        {
            bool isRamenExists = CheckIfMenuExists("라면",tableName);
            if (isRamenExists)
            {
                IncreaseMenuQuantity("라면", tableName);
            }
            else
            {
                AddNewMenu("라면", 2000, 1,tableName);
            }
            RefreshData(tableName);

        }

        private void Btncoffee_Click(object sender, EventArgs e)
        {
            bool isCoffeeExists = CheckIfMenuExists("커피", tableName);
            if (isCoffeeExists)
            {
                IncreaseMenuQuantity("커피",tableName);
            }
            else
            {
                AddNewMenu("커피", 3000, 1, tableName);
            }
            RefreshData(tableName);

        }

        private void BtnEggRice_Click(object sender, EventArgs e)
        {
            bool isEggRiceExists = CheckIfMenuExists("계란볶음밥", tableName);
            if (isEggRiceExists)
            {
                IncreaseMenuQuantity("계란볶음밥",tableName);
            }
            else
            {
                AddNewMenu("계란볶음밥", 6500, 1, tableName);
            }
            RefreshData(tableName);

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowDateTIme.Text = DateTime.Now.ToString("T");
        }

        
    }
}