using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAO
{
    public class ChiTietPhieuMuonDao
    {   
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From ChiTietPhieuMuon";
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
            strSQL = "Select * From ChiTietPhieuMuon";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChiTietPhieuMuonDto ctpm = new ChiTietPhieuMuonDto();
                ctpm.MaChiTietPhieu= (int)dr["MChiTietPhieu"];
                ctpm.MaPhieu = (int)dr["MPhieu"];
                ctpm.MaSach = (int)dr["MSach"];
                ds.Add(ctpm);
            }

            dr.Close();
            cn.Close();
            return ds;
        
        }
        public static ChiTietPhieuMuonDto Search(int MaCT)
        {
            ChiTietPhieuMuonDto ctpm = null;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From ChiTietPhieuMuon Where MChiTietPhieu= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MChiTietPhieu", OleDbType.Integer);
            cmd.Parameters["@MChiTietPhieu"].Value = MaCT;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ctpm = new ChiTietPhieuMuonDto();
                ctpm.MaChiTietPhieu = (int)dr["MChiTietPhieu"];
                ctpm.MaPhieu = (int)dr["MPhieu"];
                ctpm.MaSach = (int)dr["MSach"];
               
            }
            dr.Close();
            cn.Close();
            return ctpm;
        }



        public static int Add(ChiTietPhieuMuonDto ctpm)
        {
           OleDbConnection cn;
            cn = DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Insert into ChiTietPhieuMuon(MSach,MPhieu) values (?,?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters["@MSach"].Value = ctpm.MaSach;
            cmd.Parameters["@MPhieu"].Value = ctpm.MaPhieu;
            cmd.ExecuteNonQuery();
            strSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(strSQL, cn);
            ctpm.MaChiTietPhieu= (int)cmd.ExecuteScalar();
            cn.Close();
            return ctpm.MaChiTietPhieu;

        }
        public static void Delete(int MaCT)
        {
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete From  ChiTietPhieuMuon Where MChiTietPhieu= ? ";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MChiTietPhieu", OleDbType.Integer);
            cmd.Parameters["@MChiTietPhieu"].Value = MaCT;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Update(ChiTietPhieuMuonDto ctpm)
        {
            OleDbConnection cn;

            cn =DataProvider.ConnectionData();

            string strSQL;
            strSQL = "Update ChiTietPhieuMuon Set MSach = ? , MPhieu = ?  Where MChiTietPhieu = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MSach", OleDbType.Integer);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters.Add("@MChiTietPhieu", OleDbType.Integer);
            cmd.Parameters["@MSach"].Value = ctpm.MaSach;
            cmd.Parameters["@MPhieu"].Value = ctpm.MaPhieu;
            cmd.Parameters["@MChiTietPhieu"].Value =ctpm.MaChiTietPhieu ;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int Count(int mPhieu)
        {
            int count = 0;
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "SELECT count(*) FROM ChiTietPhieuMuon AS c, Sach AS s WHERE s.MSach=c.MSach And s.TrangThai=False And MPhieu=?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MPhieu", OleDbType.Integer);
            cmd.Parameters["@MPhieu"].Value = mPhieu;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count = (int)dr[0];
            }

            dr.Close();
            cn.Close();
            return count;
        }
        
    }
}
