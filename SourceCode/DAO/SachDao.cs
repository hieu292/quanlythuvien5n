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
        public static DataSet Search(int maSach)
        {
            DataSet sach = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select TenSach, TacGia, TrangThai, SoTrang, TenLoaiSach, TenNgonNgu, LoaiSach, NgonNgu From Sach, NgonNgu, LoaiSach Where MSach= " + maSach.ToString() + " and Sach.LoaiSach = LoaiSach.MLoaiSach and Sach.NgonNgu = NgonNgu.MNgonNgu";
            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(sach);
            cn.Close();
            return sach;
        }

        public static DataSet Search(SachDto sach, SachDto sach2)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            DataSet ds = new DataSet(); ;
            string strSQL;
            strSQL = "Select MSach, TenSach From Sach Where";
            if (sach.TenSach != null)
            {
                strSQL += " TenSach like '%" + sach.TenSach + "%'";
            }
            else if (sach.LoaiSach != -1)
            {
                strSQL += " LoaiSach = " + sach.LoaiSach;
            }
            else if (sach.TacGia != null)
            {
                strSQL += " TacGia like '%" + sach.TacGia + "%'";
            }
            else if (sach.SoTrang != -1)
            {
                strSQL += " SoTrang >= " + sach.SoTrang + " and SoTrang <= " + sach2.SoTrang;
            }
            else if (sach.NgonNgu != -1)
            {
                strSQL += " NgonNgu = " + sach.NgonNgu;
            }
            else
            {
                strSQL += " TrangThai = " + sach.TrangThai.ToString();
            }
            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(ds);
            cn.Close();
            return ds;
        }

        public static DataSet Timsach(SachDto sach, SachDto sach2)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            DataSet ds = new DataSet(); ;
            string strSQL;
            strSQL = "Select MSach, TenSach From Sach Where";
            if (sach.TenSach != null)
            {
                strSQL += " TenSach like '%" + sach.TenSach + "%'";
            }
            else if (sach.LoaiSach != -1)
            {
                strSQL += " LoaiSach = " + sach.LoaiSach;
            }
            else if (sach.TacGia != null)
            {
                strSQL += " TacGia like '%" + sach.TacGia + "%'";
            }
            else if (sach.SoTrang != -1)
            {
                strSQL += " SoTrang >= " + sach.SoTrang + " and SoTrang <= " + sach2.SoTrang;
            }
            else
            {
                strSQL += " NgonNgu = " + sach.NgonNgu;
            }
            strSQL += " and TrangThai = true";

            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(ds);
            cn.Close();
            return ds;
        }

        public static DataSet Timsachtheophieu(int mPhieu)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            DataSet ds = new DataSet(); ;
            string strSQL;
            strSQL = "Select s.MSach, s.TenSach, s.TrangThai From Sach s, ChiTietPhieuMuon c Where c.MPhieu = " + mPhieu.ToString() + " and c.MSach = s.MSach";
            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(ds);
            cn.Close();
            return ds;
        }



        public static int Add(SachDto sach)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into Sach(TenSach,LoaiSach,TacGia,TrangThai,SoTrang,NgonNgu) values (?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@TenSach", OleDbType.WChar);
            cmd.Parameters.Add("@LoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TacGia", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Boolean);
            cmd.Parameters.Add("@SoTrang", OleDbType.Integer);
            cmd.Parameters.Add("@NgonNgu", OleDbType.Integer);
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
            strSQL = "Update Sach Set TenSach = ? , LoaiSach = ? , TacGia =?, TrangThai=?, SoTrang=?, NgonNgu=? Where MSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@TenSach", OleDbType.WChar);
            cmd.Parameters.Add("@LoaiSach", OleDbType.Integer);
            cmd.Parameters.Add("@TacGia", OleDbType.WChar);
            cmd.Parameters.Add("@TrangThai", OleDbType.Boolean);
            cmd.Parameters.Add("@SoTrang", OleDbType.Integer);
            cmd.Parameters.Add("@NgonNgu", OleDbType.Integer);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);

            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@LoaiSach"].Value = sach.LoaiSach;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@TrangThai"].Value = sach.TrangThai;
            cmd.Parameters["@SoTrang"].Value = sach.SoTrang;
            cmd.Parameters["@NgonNgu"].Value = sach.NgonNgu;
            cmd.Parameters["@MSach"].Value = sach.MSach;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void UpdateTrangThai(int maSach, bool trangthai)
        {
            OleDbConnection cn;

            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update Sach Set TrangThai=? Where MSach = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@TrangThai", OleDbType.Boolean);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);

            cmd.Parameters["@TrangThai"].Value = trangthai;
            cmd.Parameters["@MSach"].Value = maSach;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
