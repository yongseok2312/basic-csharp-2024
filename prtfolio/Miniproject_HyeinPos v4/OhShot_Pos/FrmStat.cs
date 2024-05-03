using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhShot_Pos
{
    public partial class FrmStat : Form
    {
        public FrmStat()
        {
            InitializeComponent();
            InitInputData();

            monthCalendar1.MaxDate = DateTime.Now;
            monthCalendar2.MaxDate = DateTime.Now;
            monthCalendar2.MinDate = monthCalendar1.SelectionStart;
        }

        private void InitInputData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    conn.Open();
                    var query = @"SELECT DISTINCT menuName FROM Alltable";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new List<string>();

                    while (reader.Read())
                    {
                        temp.Add(reader["menuName"].ToString());
                    }

                    CboMenu.DataSource = temp;
                    CboMenu.SelectedIndex = 0;
                }
            }
            catch{}

            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                decimal totalprice = 0;
                var query = @"SELECT SUM(menuprice*menunum) AS 'sumtable' FROM Alltable" ;
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["sumtable"] != DBNull.Value)
                    {
                        totalprice = Convert.ToDecimal(reader["sumtable"]);
                    }
                }
                total.Text = totalprice.ToString("C", CultureInfo.CurrentCulture); // CultureInfo.CurrentCulture 통화 형식
            }
        }

        private void CboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                decimal sumtable = 0;
                decimal summenu = 0;
                string selectedItem = CboMenu.SelectedItem.ToString();
                var query = @"SELECT SUM(menuprice*menunum) AS 'sumtable', SUM(menunum) AS 'summenu' FROM Alltable WHERE menuName = @selectedItem";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@selectedItem", selectedItem);
                object result = cmd.ExecuteScalar();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["sumtable"] != DBNull.Value)
                    {
                        sumtable = Convert.ToDecimal(reader["sumtable"]);
                    }
                    if (reader["summenu"] != DBNull.Value)
                    {
                        summenu = Convert.ToDecimal(reader["summenu"]);
                    }
                }
                Sumprice1.Text = sumtable.ToString("C", CultureInfo.CurrentCulture); // CultureInfo.CurrentCulture 통화 형식
                Summenu1.Text = summenu.ToString(CultureInfo.CurrentCulture) + "개";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.MinDate = monthCalendar1.SelectionStart;
            Datechage();
        }

        private void Datechage()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();
                decimal sumtable = 0;
                decimal summenu = 0;
                var query = @"SELECT SUM(menuprice * menunum) AS 'sumtable', SUM(menunum) AS 'summenu' FROM Alltable WHERE [DATE] BETWEEN @startDate AND @endDate";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", monthCalendar1.SelectionStart.ToString());
                cmd.Parameters.AddWithValue("@endDate", monthCalendar2.SelectionStart.ToString());
              
                object result = cmd.ExecuteScalar(); // ExecuteScalar 메서드 사용
                if (result != DBNull.Value && result != null)
                {
                    // ExecuteScalar로부터 값을 가져온 후에는 변환이 필요합니다.
                    sumtable = Convert.ToDecimal(result);
                    summenu = Convert.ToDecimal(result); // 이 부분을 수정해야 합니다.
                }
                label1.Text = sumtable.ToString("C", CultureInfo.CurrentCulture); // CultureInfo.CurrentCulture 통화 형식
                label8.Text = summenu.ToString(CultureInfo.CurrentCulture) + "개";
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Datechage();
        }
    }


}
