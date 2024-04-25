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

namespace project2
{

    public partial class FromMain : MetroForm
    {
        private int p =20000; // 가격값을 얻는 변수
        public FromMain()
        {
            InitializeComponent();
        }

        public static readonly string connString = "Data Source=localhost;" +
                                           "Initial Catalog=menu;" +
                                           "Persist Security Info=True;" +
                                           "User ID=sa;Encrypt=False;" +
                                           "Password=mssql_p@ss";
        private void FromMain_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData() // 기초 데이터
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT [메뉴 번호]
                                          ,[메뉴이름]
                                          ,[종류]
                                          ,[밥,면]
                                          ,[가격]
                                          FROM menu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "menu");

                    DgvResult.DataSource = ds.Tables["menu"];
                    DgvResult.ReadOnly = true;
                    DgvResult.Columns[0].Visible = false;
                    DgvResult.Columns[1].HeaderText = "메뉴 이름";
                    DgvResult.Columns[2].HeaderText = "종류";
                    DgvResult.Columns[3].Visible = false;
                    DgvResult.Columns[4].HeaderText = "가격";

                    DgvResult.Columns[1].Width = 90;
                    DgvResult.Columns[2].Width = 55;
                    DgvResult.Columns[4].Width = 90;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 가져오기 오류: {ex.Message}");
                }

            }
        }
        #region "종류"

        private void ChkKorean_CheckedChanged(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }
        private void ChkChina_CheckedChanged(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }

        private void ChkWestern_CheckedChanged(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }
        private void ChkJapan_CheckedChanged(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }

        #endregion

        private void modify()
        {
            bool showrice = Rbtnrice.Checked;
            bool showNuddle = RbtnNuddle.Checked;

            if(DgvResult.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                string filterExpression = "";
                if (showrice)
                {
                    filterExpression = "[밥,면] = '밥'";
                }
                else if (showNuddle)
                {
                    filterExpression = "[밥,면] = '면'";
                }
                else
                {
                    filterExpression = "";
                }
                dv.RowFilter = filterExpression;
                DgvResult.DataSource = dv.ToTable();
            }
        } // 밥, 면 설정 함수

        #region "밥,면"
        private void Rbtnrice_Click(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }

        private void RbtnNuddle_Click(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }

        private void Rbtnnomal_Click(object sender, EventArgs e)
        {
            FilterMenu();
            modify();
            price(p);
        }
        #endregion
        private void FilterMenu()
        {
            bool showKorean = ChkKorean.Checked;
            bool showJapanese = ChkJapan.Checked;
            bool showChina = ChkChina.Checked;
            bool showWestern = ChkWestern.Checked;

            try
            {
                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT [메뉴 번호], 메뉴이름, 종류, [밥,면], 가격 FROM menu";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "menu");

                    DataView dv = ds.Tables["menu"].DefaultView;
                    string filterExpression = "";


                    if (showKorean && showJapanese && showChina && showWestern)
                    {
                        filterExpression = "종류 IN ('한식','일식','중식','양식')";
                    }
                    else if (showKorean && showJapanese && showChina)
                    {
                        filterExpression = "종류 IN ('한식','일식','중식')";
                    }
                    else if (showKorean && showJapanese && showWestern)
                    {
                        filterExpression = "종류 IN ('한식','일식','양식')";
                    }
                    else if (showJapanese && showChina && showWestern)
                    {
                        filterExpression = "종류 IN ('일식','중식','양식')";
                    }
                    else if (showKorean && showJapanese)
                    {
                        filterExpression = "종류 IN ('한식', '일식')";
                    }
                    else if (showJapanese && showChina)
                    {
                        filterExpression = "종류 IN ('일식','중식')";
                    }
                    else if (showChina && showWestern)
                    {
                        filterExpression = "종류 IN ('중식','양식')";
                    }
                    else if (showJapanese && showWestern)
                    {
                        filterExpression = "종류 IN('일식','양식')";

                    }
                    else if (showKorean && showChina)
                    {
                        filterExpression = "종류 IN('한식','중식')";

                    }
                    else if (showKorean && showWestern)
                    {
                        filterExpression = "종류 IN ('한식','양식')";
                    }
                    else if (showKorean)
                    {
                        filterExpression = "종류 = '한식'";
                    }
                    else if (showJapanese)
                    {
                        filterExpression = "종류 = '일식'";
                    }
                    else if (showChina)
                    {
                        filterExpression = "종류 = '중식'";
                    }
                    else if (showWestern)
                    {
                        filterExpression = "종류 = '양식'";
                    }
                    dv.RowFilter = filterExpression;

                    DgvResult.DataSource = dv.ToTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터베이스 연동 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // 메뉴 종류 체크박스 설정 함수


        private void price(int maxPrice)
        {
            try
            {   
                if (DgvResult.DataSource is DataTable dt)
                {
                    DataView dv = dt.DefaultView;
                    string filterExpression = $"가격 <= {maxPrice}";
                    dv.RowFilter = filterExpression;
                    DataTable filteredTable = dv.ToTable();
  
                }
                else
                {
                    MessageBox.Show("유효한 데이터 소스가 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // 가격 설정 함수

        private void Btnstart_Click(object sender, EventArgs e)
        {
            if (DgvResult != null && DgvResult.Rows.Count > 0 && DgvResult.DataSource is DataTable dt)
            {
                // DataTable에서 랜덤하게 하나의 행(메뉴) 선택
                Random random = new Random();
                int randomIndex = random.Next(0, dt.Rows.Count); // 0부터 메뉴 개수 - 1까지 랜덤 인덱스 생성

                DataRow randomMenu = dt.Rows[randomIndex];
                string menuName = randomMenu["메뉴이름"].ToString();
                string menuCategory = randomMenu["종류"].ToString();
                decimal menuPrice = Convert.ToDecimal(randomMenu["가격"]);

                metroTextBox1.Text = ("오늘의 음식은: "+menuName +Environment.NewLine+"예상 가격은 :" + menuPrice+"원");
               


            }
            else
            {
                MessageBox.Show("메뉴 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // random

        private void PriceBar_Scroll(object sender, EventArgs e)
        {
            modify();
            FilterMenu();
            p = PriceBar.Value;
            TxtPrice.Text = p.ToString();
            price(p);
        }// 스크롤 바

        
    } }
            
        
    


        
