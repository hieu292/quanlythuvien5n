using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SachDto
    {
        #region Atributes
        private int mSach;
        private String tenSach;
        private int loaiSach;
        private String tacGia;
        private bool trangThai; //true: chưa cho mượn, false: đang cho mượn
        private int soTrang;
        private int ngonNgu;
        #endregion

        #region Properties
        
        public int MSach
        {
            set { mSach = value; }
            get { return mSach; }
        }
        public String TenSach
        {
            set { tenSach = value; }
            get { return tenSach; }
        }

        public int LoaiSach
        {
            set { loaiSach = value; }
            get { return loaiSach; }
        }
        public String TacGia
        {
            set { tacGia = value; }
            get { return tacGia; }
        }
        public bool TrangThai
        {
            set { trangThai = value; }
            get { return trangThai; }
        }
        public int SoTrang
        {
            set { soTrang = value; }
            get { return soTrang; }
        }
        public int NgonNgu
        {
            set { ngonNgu = value; }
            get { return ngonNgu; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
