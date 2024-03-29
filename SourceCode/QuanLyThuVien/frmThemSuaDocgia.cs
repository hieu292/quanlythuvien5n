using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyThuVien
{
    public partial class frmThemSuaDocgia : Form
    {
        public int type = 0;
        public DocGiaDto docgia = new DocGiaDto();
        public frmThemSuaDocgia()
        {
            InitializeComponent();
        }

        private void frmThemSuaDocgia_Load(object sender, EventArgs e)
        {
            cmbGioitinh.SelectedIndex = 0;
            if (type == 0)
            {
                lbTitle.Text = "Thêm độc giả";
            }
            else
            {
                lbTitle.Text = "Sửa độc giả";
                txtHoten.Text = docgia.HoTen;
                txtCMND.Text = docgia.CMND;
                txtEmail.Text = docgia.Email;
                txtSoDT.Text = docgia.SoDienThoai;
                txtDiachi.Text = docgia.DiaChi;
                if (docgia.GioiTinh == 0)
                    cmbGioitinh.SelectedIndex = 1;
                else
                    cmbGioitinh.SelectedIndex = 0;
                dayNgaysinh.Value = docgia.NgaySinh;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count;
            docgia.HoTen = txtHoten.Text;
            if (docgia.HoTen.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên độc giả !!");
                return;
            }
            docgia.CMND = txtCMND.Text;
            for (count = 0; count < docgia.CMND.Length; count++ )
                if (docgia.CMND[count] > '9' || docgia.CMND[count] < '0')
                {
                    MessageBox.Show("CMND chỉ được nhập số !!");
                    return;
                }
            docgia.Email = txtEmail.Text;
            if ((!(docgia.Email.IndexOf('@') > 0) && docgia.Email.Length > 0) || (docgia.Email.Length > 0 && docgia.Email.Length < 3))
            {
                MessageBox.Show("Email không hợp lệ !!");
                return;
            }
            docgia.SoDienThoai = txtSoDT.Text;
            for (count = 0; count < docgia.SoDienThoai.Length; count++)
                if (docgia.SoDienThoai[count] > '9' || docgia.SoDienThoai[count] < '0')
                {
                    MessageBox.Show("Số điện thoại chỉ được nhập số !!");
                    return;
                }
            docgia.DiaChi = txtDiachi.Text;
            if (cmbGioitinh.SelectedIndex == 1)
                docgia.GioiTinh = 0;
            else
                docgia.GioiTinh = 1;
            docgia.NgaySinh = dayNgaysinh.Value;
            if (docgia.NgaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được sau ngày hiện tại !!");
                return;
            }
            if (type == 0)
            {
                BUS.DocGiaBus.Add(docgia);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                BUS.DocGiaBus.Update(docgia);
                MessageBox.Show("Sửa thành công");
            }
        }
    }
}