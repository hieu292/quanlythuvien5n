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

        public static DocGiaDto TimDocgiaTheoPhieu(int mPhieu)
        {
            DocGiaDto docGia = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select d.MDocGia, HoTen, GioiTinh, NgaySinh, CMND, DiaChi, Email, SoDienThoai From DocGia d, PhieuMuon p Where p.MPhieu= ? and p.MDocGia = d.MDocGia ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters["@MPhieu"].Value = mPhieu;
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


        public static DataSet Search(DocGiaDto docgia)
        {
            DataSet docGia = new DataSet();
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select MDocGia, HoTen From DocGia Where";
            if (docgia.HoTen != null)
            {
                strSQL += " HoTen like '%" + docgia.HoTen + "%'";
            }
            else if (docgia.GioiTinh != -1)
            {
                strSQL += " GioiTinh = " + docgia.GioiTinh;
            }
            else if (docgia.CMND != null)
            {
                strSQL += " CMND like '%" + docgia.CMND + "%'";
            }
            else if (docgia.DiaChi != null)
            {
                strSQL += " DiaChi like '%" + docgia.DiaChi + "%'";
            }
            else if (docgia.Email != null)
            {
                strSQL += " Email like '%" + docgia.Email + "%'";
            }
            else if (docgia.SoDienThoai != null)
            {
                strSQL += " SoDienThoai like '%" + docgia.SoDienThoai + "%'";
            }
            else
            {
                strSQL += " NgaySinh = ? ";
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                cmd.Parameters.Add("@ngaysinh", OleDbType.Date);
                cmd.Parameters["@ngaysinh"].Value = docgia.NgaySinh;
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Columns.Add("MDocgia", System.Type.GetType("System.Int32"));
                dt.Columns.Add("Hoten", System.Type.GetType("System.String"));
                while (dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row[0] = (int)dr[0];
                    row[1] = dr[1].ToString();
                    dt.Rows.Add(row);
                }
                docGia.Tables.Add(dt);
                return docGia;
            }
            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(docGia);
            return docGia;
        }
        public static DataSet Timsach(int maDocGia)
        {
            DataSet docGia = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select s.MSach, s.TenSach, s.TacGia From PhieuMuon p, ChiTietPhieuMuon c, Sach s where p.MDocGia = " + maDocGia.ToString() + " and c.MPhieu = p.MPhieu and c.MSach = s.MSach and s.TrangThai = false and p.TrangThai = false";
            OleDbDataAdapter adp = new OleDbDataAdapter(strSQL, cn);
            adp.Fill(docGia);
            return docGia;
        }

        public static int Add(DocGiaDto docGia)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into DocGia(HoTen,GioiTinh,NgaySinh,CMND,DiaChi,Email,SoDienThoai) values (?,?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@HoTen", OleDbType.WChar);
            cmd.Parameters.Add("@GioiTinh", OleDbType.Integer);
            cmd.Parameters.Add("@NgaySinh", OleDbType.Date);
            cmd.Parameters.Add("@CMND", OleDbType.WChar);
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar);
            cmd.Parameters.Add("@Email", OleDbType.WChar);
            cmd.Parameters.Add("@SoDienThoai", OleDbType.WChar);
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
            strSQL = "Update DocGia Set HoTen = ? , GioiTinh = ? , NgaySinh =?, CMND=?, DiaChi=?, Email=?, SoDienThoai=? Where MDocGia = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@HoTen", OleDbType.WChar);
            cmd.Parameters.Add("@GioiTinh", OleDbType.Integer);
            cmd.Parameters.Add("@NgaySinh", OleDbType.Date);
            cmd.Parameters.Add("@CMND", OleDbType.WChar);
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar);
            cmd.Parameters.Add("@Email", OleDbType.WChar);
            cmd.Parameters.Add("@SoDienThoai", OleDbType.WChar);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            
            cmd.Parameters["@HoTen"].Value = docGia.HoTen;
            cmd.Parameters["@GioiTinh"].Value = docGia.GioiTinh;
            cmd.Parameters["@NgaySinh"].Value = docGia.NgaySinh;
            cmd.Parameters["@CMND"].Value = docGia.CMND;
            cmd.Parameters["@DiaChi"].Value = docGia.DiaChi;
            cmd.Parameters["@Email"].Value = docGia.Email;
            cmd.Parameters["@SoDienThoai"].Value = docGia.SoDienThoai;
            cmd.Parameters["@MDocGia"].Value = docGia.MDocGia;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
