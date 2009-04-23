using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO; 

namespace BUS
{
    public class NgonNguBus
    {
        public static DataTable GetTable()
        {
            return NgonNguDao.GetTable();
        }
        public static IList GetList()
        {
            return NgonNguDao.GetList();
        }
        public static NgonNguDto Search(int MaNn)
        {
            return NgonNguDao.Search(MaNn);
        }
        public static int Add(NgonNguDto nn)
        {
            return NgonNguDao.Add(nn);
        }
        public static void Delete(int MaNn)
        {
            NgonNguDao.Delete(MaNn);
        }
        public static void Update(NgonNguDto nn)
        {
            NgonNguDao.Update(nn);
        }
    }
}
