using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhieuMuonDto
    {
        #region Atributes
        private int mPhieu;
        private int mDocGia;
        private DateTime ngayMuon;
        private int soNgayMuon;
        #endregion

        #region Properties
        public int MaPhieu
        {
            get { return mPhieu; }
            set { mPhieu = value; }
        }

        public int MaDocGia
        {
            get { return mDocGia; }
            set { mDocGia = value; }
        }

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

        public int SoNgayMuon
        {
            get { return soNgayMuon; }
            set { soNgayMuon = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
