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
        }

        public static void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT [Num]
                                          ,[menuName]
                                          ,[menuPrice]
                                          ,[menunum]
                                          ,[DATE]
                                      FROM @[Alltable]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Alltable");
                    DgvResult.DataSource = ds.Tables["Alltable"];
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
           
    }
}
