using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class DataAccessDao
    {
        public static DataTable DataQuery(String strSql)
        {
            // Tạo đối tượng kết nối
            OleDbConnection myConn = DataProvider.ConnectionData();                        
            // Tạo đối tượng DataAdapter, DataTable và thực thi câu truy vấn, kết quả thực thi được đổ vào DataTable
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(strSql, myConn);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);            
            // Đóng kết nối CSDL
            myConn.Close();
            return dt;
        }
    }
}
