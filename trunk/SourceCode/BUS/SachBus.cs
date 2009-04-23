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
        public static DataSet Search(int maSach)
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
        public static DataSet Search(SachDto sach, SachDto sach2)
        {
            return SachDao.Search(sach, sach2);
        }
        public static DataSet Timsach(SachDto sach, SachDto sach2)
        {
            return SachDao.Timsach(sach, sach2);
        }

        public static DataSet Timsachtheophieu(int mPhieu)
        {
            return SachDao.Timsachtheophieu(mPhieu);
        }
        public static void UpdateTrangThai(int maSach, bool trangthai)
        {
            SachDao.UpdateTrangThai(maSach, trangthai);
        }
    }
}
