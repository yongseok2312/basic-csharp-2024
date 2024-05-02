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
            Datelabel.Text = DateTime.Now.ToString("T");
            timer1.Interval = 1000; // 1초마다 갱신
            timer1.Start();
        }

        #region 폼로드 이벤트 핸들러 : 로딩창 먼저 띄우기! 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLoading frm = new FrmLoading();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;  // 윈도우 화면 상단에 
            frm.ShowDialog();
            this.Refresh();
        }
        #endregion

        #region 테이블 쇼
        private void Showtable1()
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
                    DataTable dt = ds.Tables["table1"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable1.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        private void Showtable2()
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
                                  FROM [table2]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table2");
                    DataTable dt = ds.Tables["table2"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable2.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        private void Showtable3()
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
                                  FROM [table3]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table3");
                    DataTable dt = ds.Tables["table3"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable3.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }

        private void Showtable4()
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
                                  FROM [table4]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table4");
                    DataTable dt = ds.Tables["table4"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable4.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        private void Showtable5()
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
                                  FROM [table5]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table5");
                    DataTable dt = ds.Tables["table5"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable5.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        private void Showtable6()
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
                                  FROM [table6]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "table6");
                    DataTable dt = ds.Tables["table6"];

                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in dt.Rows)
                    {
                        string menuName = row["menuName"].ToString();
                        string menunum = row["menunum"].ToString();

                        // 텍스트 상자에 추가
                        sb.AppendLine($"{menuName} * {menunum}");

                    }

                    TxtTable6.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }
            }
        }
        #endregion
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            Showtable1();
            Showtable2();
            Showtable3();
            Showtable4();
            Showtable5();
            Showtable6();
        }


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


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToString("T");
        }

        #region '테이블 클릭' 
        private void TxtTable1_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table1"); 
            frm.StartPosition = FormStartPosition.CenterScreen; 
            frm.ShowDialog(); 
        }

        private void TxtTable2_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table2");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void TxtTable3_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table3");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void TxtTable4_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table4");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void TxtTable5_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table5");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void TxtTable6_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder("table6");
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        #endregion

        private void Btnrecord_Click(object sender, EventArgs e)
        {
            FrmRecord frm = new FrmRecord();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}

