using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO; 

namespace BUS
{
    public class SachBus
    {
        public static DataTable GetTable()
        {
            return SachDao.GetTable(); 
        }
        public static IList GetList()
        {
            return SachDao.GetList();
        }
        public static SachDto Search(int maSach)
        {
            return SachDao.Search(maSach);
        }
        public static int Add(SachDto sach)
        {
            return SachDao.Add(sach);
        }
        public static void Delete(int maSach)
        {
            SachDao.Delete(maSach);
        }
        public static void Update(SachDto sach)
        {
            SachDao.Update(sach);
        }
    }
}
