using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class SachDao
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From Sach";
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
            strSQL = "Select * From Sach";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SachDto sach = new SachDto();                
                sach.MSach = (int)dr["MSach"];
                sach.TenSach = (String)dr["TenSach"];
                sach.LoaiSach = (int)dr["LoaiSach"];
                sach.TacGia = (String)dr["TacGia"];
                sach.TrangThai = (bool)dr["TrangThai"];
                sach.SoTrang = (int)dr["SoTrang"];
                sach.NgonNgu = (int)dr["NgonNgu"];
                ds.Add(sach);
            }
            dr.Close();
            cn.Close();
            return ds;

        }
        public static SachDto Search(int maSach)
        {
            SachDto sach = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From Sach Where MSach= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters["@MSach"].Value = maSach;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sach = new SachDto();
                sach.MSach = (int)dr["MSach"];
                sach.TenSach = (String)dr["TenSach"];
                sach.LoaiSach = (int)dr["LoaiSach"];
                sach.TacGia = (String)dr["TacGia"];
                sach.TrangThai = (bool)dr["TrangThai"];
                sach.SoTrang = (int)dr["SoTrang"];
                sach.NgonNgu = (int)dr["NgonNgu"];
            }
            dr.Close();
            cn.Close();
            return sach;
        }
        public static int Add(SachDto sach)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into Sach(MSach,TenSach,LoaiSach,TacGia,TrangThai,SoTrang,NgonNgu) values (?,?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters.Add("@TenSach", OleDbType.WChar);
            cmd.Parameters.Add("@LoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TacGia", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Boolean);
            cmd.Parameters.Add("@SoTrang", OleDbType.Integer);
            cmd.Parameters.Add("@NgonNgu", OleDbType.Integer);
            cmd.Parameters["@MSach"].Value = sach.MSach;
            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@LoaiSach"].Value = sach.LoaiSach;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@TrangThai"].Value = sach.TrangThai;
            cmd.Parameters["@SoTrang"].Value = sach.SoTrang;
            cmd.Parameters["@NgonNgu"].Value = sach.NgonNgu;

            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            sach.MSach = (int)cmd.ExecuteScalar();
            cn.Close();
            return sach.MSach;
        }
        public static void Delete(int maSach)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  Sach Where MSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters["@MSach"].Value = maSach;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(SachDto sach)
        {
            OleDbConnection cn;

            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update Sach Set MSach = ? , TenSach = ? , LoaiSach = ? , TacGia =?, TrangThai=?, SoTrang=?, NgonNgu=? Where MSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters.Add("@TenSach", OleDbType.WChar);
            cmd.Parameters.Add("@LoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TacGia", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Boolean);
            cmd.Parameters.Add("@SoTrang", OleDbType.Integer);
            cmd.Parameters.Add("@NgonNgu", OleDbType.Integer);

            cmd.Parameters["@MSach"].Value = sach.MSach;
            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@LoaiSach"].Value = sach.LoaiSach;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@TrangThai"].Value = sach.TrangThai;
            cmd.Parameters["@SoTrang"].Value = sach.SoTrang;
            cmd.Parameters["@NgonNgu"].Value = sach.NgonNgu;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
