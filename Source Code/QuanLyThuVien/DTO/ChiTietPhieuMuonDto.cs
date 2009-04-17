using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietPhieuMuonDto
    {
        #region Atributes
        private int mPhieu;
        private int mSach;
        private DateTime ngayTra;
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

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
