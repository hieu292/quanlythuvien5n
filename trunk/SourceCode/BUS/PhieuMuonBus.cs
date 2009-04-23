using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO; 

namespace BUS
{
    public class PhieuMuonBus
    {
        public static DataTable GetTable()
        {
            return PhieuMuonDao.GetTable();
        }
        public static IList GetList()
        {
            return PhieuMuonDao.GetList();

        }
        public static PhieuMuonDto Search(int MaPh)
        {
            return PhieuMuonDao.Search(MaPh);
        }

        public static DataSet SearchDay(DateTime first, DateTime last)
        {
            return PhieuMuonDao.SearchDay(first, last);
        }

        public static DataSet Searchnumday(int songay)
        {
            return PhieuMuonDao.Searchnumday(songay);
        }
        public static DataSet SearchLate()
        {
            return PhieuMuonDao.SearchLate();
        }
        public static int Add(PhieuMuonDto pm)
        {
            return PhieuMuonDao.Add(pm);
        }
        public static void Delete(int MaPh)
        {
            PhieuMuonDao.Delete(MaPh);
        }
        public static void Update(PhieuMuonDto pm)
        {
            PhieuMuonDao.Update(pm);
        }
    }
}
