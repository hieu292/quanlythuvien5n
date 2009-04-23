using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class LoaiSachDao
    {
        public static DataSet GetTable()
        {
            DataSet dt = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From LoaiSach";
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(strSQL, cn);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public static IList GetList()
        {
            ArrayList ds = new ArrayList();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From LoaiSach";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiSachDto loaiSach = new LoaiSachDto();
                loaiSach.MLoaiSach = (int)dr["MLoaiSach"];
                loaiSach.TenLoaiSach = (String)dr["TenLoaiSach"];                
                ds.Add(loaiSach);
            }
            dr.Close();
            cn.Close();
            return ds;

        }
        public static LoaiSachDto Search(int maLoaiSach)
        {
            LoaiSachDto loaiSach = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From LoaiSach Where MLoaiSach= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MLoaiSach", OleDbType.Integer);
            cmd.Parameters["@MLoaiSach"].Value = maLoaiSach;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loaiSach = new LoaiSachDto();
                loaiSach.MLoaiSach = (int)dr["MLoaiSach"];
                loaiSach.TenLoaiSach = (String)dr["TenLoaiSach"];                
            }
            dr.Close();
            cn.Close();
            return loaiSach;
        }
        public static int Add(LoaiSachDto loaiSach)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into LoaiSach(MLoaiSach,TenLoaiSach) values (?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MLoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TenLoaiSach", OleDbType.WChar);
            cmd.Parameters["@MLoaiSach"].Value = loaiSach.MLoaiSach;
            cmd.Parameters["@TenLoaiSach"].Value = loaiSach.TenLoaiSach;
            
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            loaiSach.MLoaiSach = (int)cmd.ExecuteScalar();
            cn.Close();
            return loaiSach.MLoaiSach;
        }
        public static void Delete(int maLoaiSach)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  LoaiSach Where MLoaiSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MLoaiSach", OleDbType.Integer);
            cmd.Parameters["@MLoaiSach"].Value = maLoaiSach;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(LoaiSachDto loaiSach)
        {
            OleDbConnection cn;

            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update LoaiSach Set MLoaiSach = ? , TenLoaiSach = ? Where MLoaiSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MLoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TenLoaiSach", OleDbType.WChar);
            
            cmd.Parameters["@MLoaiSach"].Value = loaiSach.MLoaiSach;
            cmd.Parameters["@TenLoaiSach"].Value = loaiSach.TenLoaiSach;
            
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CapNhatBang(DataSet ds)
        {
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select * From LoaiSach";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            da.Update(ds.Tables[0]);
            //B5: Dong ket noi CSDL
            cn.Close();
        }
    }
}
