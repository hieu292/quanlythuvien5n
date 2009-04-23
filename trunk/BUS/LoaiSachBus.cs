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
    public class LoaiSachBus
    {
        public static DataTable GetTable()
        {
            return LoaiSachDao.GetTable();
        }
        public static IList GetList()
        {
            return LoaiSachDao.GetList();
        }
        public static LoaiSachDto Search(int maLoaiSach)
        {
            return LoaiSachDao.Search(maLoaiSach);
        }
        public static int Add(LoaiSachDto loaiSach)
        {
            return LoaiSachDao.Add(loaiSach);
        }
        public static void Delete(int maLoaiSach)
        {
            LoaiSachDao.Delete(maLoaiSach);
        }
        public static void Update(LoaiSachDto loaiSach)
        {
            LoaiSachDao.Update(loaiSach);
        }
    }
}
