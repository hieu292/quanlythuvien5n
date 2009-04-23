using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietPhieuMuonDto
    {
        #region Atributes
        private int mChiTietPhieu;
        private int mPhieu;
        private int mSach;
        
        #endregion

        #region Properties
        public int MaPhieu
        {
            get { return mPhieu; }
            set { mPhieu = value; }
        }

        public int MaSach
        {
            get { return mSach; }
            set { mSach = value; }
        }

        public int MaChiTietPhieu
        {
            get { return mChiTietPhieu; }
            set { mChiTietPhieu = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
