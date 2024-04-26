using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhShot_Pos.Helper
{
    public class Common
    {
        public static readonly string connString = "Data Source=localhost;" +
                                           "Initial Catalog=pos;" +
                                           "Persist Security Info=True;" +
                                           "User ID=sa;Encrypt=False;" +
                                           "Password=mssql_p@ss";
    }
}
