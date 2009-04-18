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
    public class DocGiaBus
    {
        public static DataTable GetTable()
        {
            return DocGiaDao.GetTable();
        }
        public static IList GetList()
        {
            return DocGiaDao.GetList();
        }
        public static DocGiaDto Search(int maDocGia)
        {
            return DocGiaDao.Search(maDocGia);
        }
        public static int Add(DocGiaDto docGia)
        {
            return DocGiaDao.Add(docGia);
        }
        public static void Delete(int maDocGia)
        {
            DocGiaDao.Delete(maDocGia);
        }
        public static void Update(DocGiaDto docGia)
        {
            DocGiaDao.Update(docGia);
        }
    }
}
