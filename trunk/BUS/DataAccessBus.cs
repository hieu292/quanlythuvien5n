using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class DataAccessBus
    {
        public static DataTable DataQuery(String strSql)
        {
            return DataAccessDao.DataQuery(strSql);
        }
    }
}
