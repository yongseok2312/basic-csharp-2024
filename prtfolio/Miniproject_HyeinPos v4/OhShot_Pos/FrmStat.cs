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

namespace OhShot_Pos
{
    public partial class FrmStat : Form
    {
        public FrmStat()
        {
            InitializeComponent();
            InitInputData();

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

                    CboMenu.DataSource = new BindingSource(temp, null);
                    CboMenu.DisplayMember = "Value";
                    CboMenu.ValueMember = "key";
                    CboMenu.SelectedIndex = -1;

                }
            }
            catch { }
        }
    }


}
