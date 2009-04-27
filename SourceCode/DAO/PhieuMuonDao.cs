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
                pm.MPhieu = (int)dr["MPhieu"];
                pm.MDocGia = (int)dr["MDocGia"];
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
                pm.MPhieu = (int)dr["MPhieu"];
                pm.MDocGia = (int)dr["MDocGia"];
                pm.NgayMuon = (DateTime)dr["NgayMuon"];
                pm.SoNgayMuon = (int)dr["SoNgayMuon"];
            }
            dr.Close();
            cn.Close();
            return pm;
        }

        public static DataSet SearchDay(DateTime first, DateTime last)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select p.MPhieu, d.HoTen, p.NgayMuon, p.SoNgayMuon  From PhieuMuon p, Docgia d Where NgayMuon >= ? and NgayMuon <= ? and d.MDocGia = p.MDocGia";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@first", OleDbType.Date);
            cmd.Parameters.Add("@last", OleDbType.Date);
            cmd.Parameters["@first"].Value = first;
            cmd.Parameters["@last"].Value = last;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            dt.Columns.Add("MPhieu", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Hoten", System.Type.GetType("System.String"));
            dt.Columns.Add("NgayMuon", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("SoNgayMuon", System.Type.GetType("System.Int32"));
            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row[0] = (int)dr[0];
                row[1] = dr[1].ToString();
                row[2] = (DateTime)dr[2];
                row[3] = (int)dr[3];
                dt.Rows.Add(row);
            }
            ds.Tables.Add(dt);
            cn.Close();
            return ds;
        }

        public static DataSet Searchnumday(int soNgay)
        {
            DataSet ds = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select p.MPhieu, d.HoTen, p.NgayMuon, p.SoNgayMuon  From PhieuMuon p, Docgia d Where SoNgayMuon = " + soNgay.ToString() + " and d.MDocGia = p.MDocGia";
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(strSQL, cn);
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public static DataSet SearchLate()
        {
            DataSet ds = new DataSet();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select p.MPhieu, d.HoTen, p.NgayMuon, p.SoNgayMuon  From PhieuMuon p, Docgia d Where d.MDocGia = p.MDocGia";
            OleDbDataAdapter da;
            da = new OleDbDataAdapter(strSQL, cn);
            da.Fill(ds);
            cn.Close();
            return ds;
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
            cmd.Parameters["@MDocGia"].Value = pm.MDocGia;
            cmd.Parameters["@NgayMuon"].Value = pm.NgayMuon;
            cmd.Parameters["@SoNgayMuon"].Value = pm.SoNgayMuon;
            
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            pm.MPhieu = (int)cmd.ExecuteScalar();
            cn.Close();
            return pm.MPhieu;
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

            cmd.Parameters["@MDocGia"].Value = pm.MDocGia;
            cmd.Parameters["@NgayMuon"].Value = pm.NgayMuon;
            cmd.Parameters["@SoNgayMuon"].Value = pm.SoNgayMuon;
            cmd.Parameters["@MPhieu"].Value = pm.MPhieu;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
