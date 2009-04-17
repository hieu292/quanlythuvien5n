using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class PhieuMuonDao
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From PhieuMuon";
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
            strSQL = "Select * From PhieuMuon";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhieuMuonDto pm = new PhieuMuonDto();
                pm.MaPhieu = (int)dr["MPhieu"];
                pm.MaDocGia = (int)dr["MDocGia"];
                pm.NgayMuon = (DateTime)dr["NgayMuon"];
                pm.SoNgayMuon = (int)dr["SoNgayMuon"];
                ds.Add(pm);
            }
            dr.Close();
            cn.Close();
            return ds;

        }
        public static PhieuMuonDto Search(int MaPh)
        {
            PhieuMuonDto pm = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From PhieuMuon Where MPhieu= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters["@MPhieu"].Value = MaPh;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pm = new PhieuMuonDto();
                pm.MaPhieu = (int)dr["MPhieu"];
                pm.MaDocGia = (int)dr["MDocGia"];
                pm.NgayMuon = (DateTime)dr["NgayMuon"];
                pm.SoNgayMuon = (int)dr["SoNgayMuon"];
            }
            dr.Close();
            cn.Close();
            return pm;
        }
        public static int Add(PhieuMuonDto pm)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into PhieuMuon(MDocGia,NgayMuon,SoNgayMuon) values (?,?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters.Add("@NgayMuon", OleDbType.Date);
            cmd.Parameters.Add("@SoNgayMuon", OleDbType.Integer);
            cmd.Parameters["@MDocGia"].Value = pm.MaDocGia;
            cmd.Parameters["@NgayMuon"].Value = pm.NgayMuon;
            cmd.Parameters["@SoNgayMuon"].Value = pm.SoNgayMuon;
            
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            pm.MaPhieu = (int)cmd.ExecuteScalar();
            cn.Close();
            return pm.MaPhieu;
        }
        public static void Delete(int MaPh)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  PhieuMuon Where MPhieu= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters["@MPhieu"].Value = MaPh;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(PhieuMuonDto pm)
        {
            OleDbConnection cn;

            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Update PhieuMuon Set MDocGia = ? , NgayMuon = ? , SoNgayMuon = ? Where MPhieu = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MDocGia", OleDbType.Integer);
            cmd.Parameters.Add("@NgayMuon", OleDbType.Date);
            cmd.Parameters.Add("@SoNgayMuon", OleDbType.Integer);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);

            cmd.Parameters["@MDocGia"].Value = pm.MaDocGia;
            cmd.Parameters["@NgayMuon"].Value = pm.NgayMuon;
            cmd.Parameters["@SoNgayMuon"].Value = pm.SoNgayMuon;
            cmd.Parameters["@MPhieu"].Value = pm.MaPhieu;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
