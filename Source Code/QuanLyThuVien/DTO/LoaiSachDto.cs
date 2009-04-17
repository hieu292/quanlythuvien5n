using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiSachDto
    {
        #region Atributes
        private int mLoaiSach;
        private String tenLoaiSach;        
        #endregion

        #region Properties

        public int MLoaiSach
        {
            set { mLoaiSach = value; }
            get { return mLoaiSach; }
        }
        public String TenLoaiSach
        {
            set { tenLoaiSach = value; }
            get { return tenLoaiSach; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
