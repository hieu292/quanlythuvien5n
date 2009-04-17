using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DocGiaDto
    {
        #region Attributes
        private int mDocGia;
        private String hoTen;
        private int gioiTinh;
        private DateTime ngaySinh;
        private String cMND;        
        private String diaChi;
        private String email;
        private String soDienThoai;
        #endregion

        #region Properties
        public int MDocGia
        {
            get { return mDocGia; }
            set { mDocGia = value; }
        }
        public String HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public String CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }
       
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        #endregion

        #region Methods
        public static bool CheckValidatedEmail(String eMail)
        {
            int apos = eMail.IndexOf("@");
            int dotpos = eMail.LastIndexOf(".");
            if (apos < 1 || dotpos - apos < 2)
                return false;
            return true;
        }
        #endregion
    }
}
