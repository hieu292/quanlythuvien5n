using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class NgonNguDao
    {
        public static DataSet GetTable()
        {
            DataSet ds = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From NgonNgu";
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(strSQL, cn);
            da.Fill(ds);
            cn.Close();
            return ds;
        }
        public static IList GetList()
        {
            ArrayList ds = new ArrayList();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From NgonNgu";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NgonNguDto nn = new NgonNguDto();
                nn.MaNgonNgu = (int)dr["MNgonNgu"];
                nn.TenNgonNgu = (String)dr["TenNgonNgu"];
                ds.Add(nn);
            }
            dr.Close();
            cn.Close();
            return ds;

        }
        public static NgonNguDto Search(int MaNn)
        {
            NgonNguDto nn = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From NgonNgu Where MNgonNgu= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MNgonNgu", OleDbType.Integer);
            cmd.Parameters["@MNgonNgu"].Value = MaNn;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nn = new NgonNguDto();
                nn.MaNgonNgu = (int)dr["MNgonNgu"];
                nn.TenNgonNgu = (String)dr["TenNgonNgu"];

            }
            dr.Close();
            cn.Close();
            return nn;
        }
        public static int Add(NgonNguDto nn)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into NgonNgu(TenNgonNgu) values (?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@TenNgonNgu", OleDbType.WChar);
            cmd.Parameters["@TenNgonNgu"].Value = nn.TenNgonNgu;
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            nn.MaNgonNgu = (int)cmd.ExecuteScalar();
            cn.Close();
            return nn.MaNgonNgu;
        }
        public static void Delete(int MaNn)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  NgonNgu Where MNgonNgu = ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MNgonNgu", OleDbType.Integer);
            cmd.Parameters["@MNgonNgu"].Value = MaNn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(NgonNguDto nn)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update NgonNgu Set TenNgonNgu = ? Where MNgonNgu = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@TenNgonNgu", OleDbType.WChar);
            cmd.Parameters.Add("@MNgonNgu", OleDbType.Integer);


            cmd.Parameters["@TenNgonNgu"].Value = nn.TenNgonNgu;
            cmd.Parameters["@MNgonNgu"].Value = nn.MaNgonNgu;

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CapNhatBang(DataSet ds)
        {
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select * From NgonNgu";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            da.Update(ds.Tables[0]);
            //B5: Dong ket noi CSDL
            cn.Close();
        }
    }
}
