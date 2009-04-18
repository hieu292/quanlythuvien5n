using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class DocGiaDao
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From DocGia";
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
            strSQL = "Select * From DocGia";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DocGiaDto docGia = new DocGiaDto();
                docGia.MDocGia = (int)dr["MDocGia"];
                docGia.HoTen = (String)dr["HoTen"];
                docGia.GioiTinh = (int)dr["GioiTinh"];
                docGia.NgaySinh = (DateTime)dr["NgaySinh"];
                docGia.CMND = (String)dr["CMND"];
                docGia.DiaChi = (String)dr["DiaChi"];
                docGia.Email = (String)dr["Email"];
                docGia.SoDienThoai = (String)dr["SoDienThoai"];
                ds.Add(docGia);
            }
            dr.Close();
            cn.Close();
            return ds;

        }
        public static DocGiaDto Search(int maDocGia)
        {
            DocGiaDto docGia = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From DocGia Where MDocGia= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters["@MDocGia"].Value = maDocGia;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                docGia = new DocGiaDto();
                docGia.MDocGia = (int)dr["MDocGia"];
                docGia.HoTen = (String)dr["HoTen"];
                docGia.GioiTinh = (int)dr["GioiTinh"];
                docGia.NgaySinh = (DateTime)dr["NgaySinh"];
                docGia.CMND = (String)dr["CMND"];
                docGia.DiaChi = (String)dr["DiaChi"];
                docGia.Email = (String)dr["Email"];
                docGia.SoDienThoai = (String)dr["SoDienThoai"];                
            }
            dr.Close();
            cn.Close();
            return docGia;
        }
        public static int Add(DocGiaDto docGia)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into DocGia(MDocGia,HoTen,GioiTinh,NgaySinh,CMND,DiaChi,Email,SoDienThoai) values (?,?,?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters.Add("@HoTen", OleDbType.WChar);
            cmd.Parameters.Add("@GioiTinh", OleDbType.Integer);
            cmd.Parameters.Add("@NgaySinh", OleDbType.Date);
            cmd.Parameters.Add("@CMND", OleDbType.WChar);
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar);
            cmd.Parameters.Add("@Email", OleDbType.WChar);
            cmd.Parameters.Add("@SoDienThoai", OleDbType.WChar);
            cmd.Parameters["@MDocGia"].Value = docGia.MDocGia;
            cmd.Parameters["@HoTen"].Value = docGia.HoTen;
            cmd.Parameters["@GioiTinh"].Value = docGia.GioiTinh;
            cmd.Parameters["@NgaySinh"].Value = docGia.NgaySinh;
            cmd.Parameters["@CMND"].Value = docGia.CMND;
            cmd.Parameters["@DiaChi"].Value = docGia.DiaChi;
            cmd.Parameters["@Email"].Value = docGia.Email;
            cmd.Parameters["@SoDienThoai"].Value = docGia.SoDienThoai;

            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            docGia.MDocGia = (int)cmd.ExecuteScalar();
            cn.Close();
            return docGia.MDocGia;
        }
        public static void Delete(int maDocGia)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  DocGia Where MDocGia = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters["@MDocGia"].Value = maDocGia;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(DocGiaDto docGia)
        {
            OleDbConnection cn;

            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update Sach Set MDocGia = ? , HoTen = ? , GioiTinh = ? , NgaySinh =?, CMND=?, DiaChi=?, Email=?, SoDienThoai=? Where MDocGia = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters.Add("@HoTen", OleDbType.WChar);
            cmd.Parameters.Add("@GioiTinh", OleDbType.Integer);
            cmd.Parameters.Add("@NgaySinh", OleDbType.Date);
            cmd.Parameters.Add("@CMND", OleDbType.WChar);
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar);
            cmd.Parameters.Add("@Email", OleDbType.WChar);
            cmd.Parameters.Add("@SoDienThoai", OleDbType.WChar);

            cmd.Parameters["@MDocGia"].Value = docGia.MDocGia;
            cmd.Parameters["@HoTen"].Value = docGia.HoTen;
            cmd.Parameters["@GioiTinh"].Value = docGia.GioiTinh;
            cmd.Parameters["@NgaySinh"].Value = docGia.NgaySinh;
            cmd.Parameters["@CMND"].Value = docGia.CMND;
            cmd.Parameters["@DiaChi"].Value = docGia.DiaChi;
            cmd.Parameters["@Email"].Value = docGia.Email;
            cmd.Parameters["@SoDienThoai"].Value = docGia.SoDienThoai;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
