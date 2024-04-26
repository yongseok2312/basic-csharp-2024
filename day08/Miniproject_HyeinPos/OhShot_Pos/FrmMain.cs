using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace OhShot_Pos
{

    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
            TxtDate.Text = DateTime.Now.ToString("T");
        }

        #region 폼로드 이벤트 핸들러 : 로딩창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLoading frm = new FrmLoading();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();
            
            
        }
        #endregion

        /*private void Showtable1()
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
        }*/
        #region '매출통계' 버튼 클릭 이벤트 핸들러 
        private void BtnStat_Click(object sender, EventArgs e)
        {
            FrmStat stat = new FrmStat();
            stat.StartPosition = FormStartPosition.CenterScreen;
            stat.Show();
        }
        #endregion

        #region '포스기 종료' 버튼 클릭 이벤트 핸들러
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region '테이블 클릭' 
        private void TxtTable1_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder(); 
            frm.StartPosition = FormStartPosition.CenterScreen; 
            frm.Show(); 
        }
        #endregion
    }
}

