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
            set { values = mSach; }
            get { return mSach; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
