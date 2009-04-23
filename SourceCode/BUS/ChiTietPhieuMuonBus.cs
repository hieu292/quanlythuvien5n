using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChiTietPhieuMuonBus
    {
        public static DataTable GetTable()
        {
            return ChiTietPhieuMuonDao.GetTable();
        }
        public static IList GetList()
        {
            return ChiTietPhieuMuonDao.GetList();
        }
        public static ChiTietPhieuMuonDto Search(int MaCT)
        {
            return ChiTietPhieuMuonDao.Search(MaCT);
        }
        public static int Add(ChiTietPhieuMuonDto ctpm)
        {
            return ChiTietPhieuMuonDao.Add(ctpm);
        }
        public static void Delete(int MaCT)
        {
            ChiTietPhieuMuonDao.Delete(MaCT);
        }
        public static void Update(ChiTietPhieuMuonDto ctpm)
        {
            ChiTietPhieuMuonDao.Update(ctpm);
        }

        public static int Count(int MPhieu)
        {
            return ChiTietPhieuMuonDao.Count(MPhieu);
        }
    }
}
