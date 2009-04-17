using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    class DataProvider
    {
        public static OleDbConnection ConnectionData()
        {
            string cnStr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = KhachSan.mdb";
            OleDbConnection cn = new OleDbConnection(cnStr);
            cn.Open();
            return cn;
        }
    }
}
