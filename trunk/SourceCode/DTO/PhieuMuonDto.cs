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
        private bool trangThai;
        #endregion

        #region Properties
        public int MPhieu
        {
            get { return mPhieu; }
            set { mPhieu = value; }
        }

        public int MDocGia
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
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
