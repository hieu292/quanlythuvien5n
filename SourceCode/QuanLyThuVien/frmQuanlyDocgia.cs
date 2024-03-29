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
    public partial class frmQuanlyDocgia : Form
    {
        public int chon = 0;
        public DocGiaDto docgiainfo;
        public frmQuanlyDocgia()
        {
            InitializeComponent();
        }


        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                lbTimkiem.Visible = true;
                lbThongbao.Text = "";
                switch (pos)
                {
                    case 0:
                        lbTimkiem.Text = "";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = false;
                        break;
                    case 1:
                        lbTimkiem.Text = "Tên độc giả";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = true;
                        break;
                    case 2:
                        lbTimkiem.Text = "Giới tính";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = true;
                        txtTenCMND.Visible = false;
                        cmbGioitinh.Items.Clear();
                        cmbGioitinh.Items.Add("Nam");
                        cmbGioitinh.Items.Add("Nữ");
                        cmbGioitinh.SelectedIndex = 0;
                        break;
                    case 3:
                        lbTimkiem.Text = "Ngày sinh";
                        dayNgaysinh.Visible = true;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = false;
                        break;
                    case 4:
                        lbTimkiem.Text = "CMND";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = true;
                        break;
                    case 5:
                        lbTimkiem.Text = "Địa chỉ";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = true;
                        break;
                    case 6:
                        lbTimkiem.Text = "Số ĐT";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = true;                        
                        break;
                    case 7:
                        lbTimkiem.Text = "Email";
                        dayNgaysinh.Visible = false;
                        cmbGioitinh.Visible = false;
                        txtTenCMND.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmQuanlyDocgia_Load(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                btAdd.Visible = btXoa.Visible = btSua.Visible = false;
                btChon.Visible = true;
            }
            cmbTimkiem.SelectedIndex = 0;
            Show();
        }

        void Find()
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                DocGiaDto docgia = new DocGiaDto();
                docgia.HoTen = null;
                docgia.GioiTinh = -1;
                docgia.SoDienThoai = docgia.Email = docgia.DiaChi = docgia.CMND = null;
                lbThongbao.Text = "";
                switch (pos)
                {
                    case 0:
                        lbTimkiem.Text = "";
                        docgia.HoTen ="";
                        break;
                    case 1:
                        lbTimkiem.Text = "Tên độc giả";
                        docgia.HoTen = txtTenCMND.Text;
                        if (docgia.HoTen.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập độc giả cần tìm !!";
                            return;
                        }
                        break;
                    case 2:
                        lbTimkiem.Text = "Giới tính";
                        docgia.GioiTinh = 1 - cmbGioitinh.SelectedIndex;
                        break;
                    case 3:
                        lbTimkiem.Text = "Ngày sinh";
                        docgia.NgaySinh = dayNgaysinh.Value;
                        break;
                    case 4:
                        lbTimkiem.Text = "CMND";
                        docgia.CMND = txtTenCMND.Text;
                        if (docgia.CMND.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập số CMND cần tìm !!";
                            return;
                        }
                        break;
                    case 5:
                        lbTimkiem.Text = "Địa chỉ";
                        docgia.DiaChi = txtTenCMND.Text;
                        if (docgia.DiaChi.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập địa chỉ cần tìm !!";
                            return;
                        }
                        break;
                    case 6:
                        lbTimkiem.Text = "Số ĐT";
                        docgia.SoDienThoai = txtTenCMND.Text;
                        if (docgia.SoDienThoai.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập số điện thoại cần tìm !!";
                            return;
                        }
                        break;
                    case 7:
                        lbTimkiem.Text = "Email";
                        docgia.Email = txtTenCMND.Text;
                        if (docgia.Email.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập email cần tìm !!";
                            return;
                        }
                        break;

                }

                DataSet ds = BUS.DocGiaBus.Search(docgia);
                dtgDanhsach.DataSource = ds.Tables[0];
                dtgDanhsach.Columns[1].Width = 290;
                dtgDanhsach.Columns[0].HeaderText = "Mã độc giả";
                dtgDanhsach.Columns[1].HeaderText = "Họ tên";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmThemSuaDocgia frm = new frmThemSuaDocgia();
            frm.type = 0;
            frm.ShowDialog();
            Find();
            lbThongtinchitiet.Text = "Thông tin độc giả";
        }

        private void btTimkiem_Click_1(object sender, EventArgs e)
        {
            Find();
        }

        private void dtgDanhsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDanhsach.SelectedRows.Count>0)
            {
                int madocgia = (int)dtgDanhsach.SelectedRows[0].Cells[0].Value;
                DocGiaDto docgia = BUS.DocGiaBus.Search(madocgia);
                lbThongtinchitiet.Text = "Tên độc giả: " + docgia.HoTen;
                lbThongtinchitiet.Text += "\nNgày sinh: " + docgia.NgaySinh.ToShortDateString();
                lbThongtinchitiet.Text += "\nGiới tính: " + (docgia.GioiTinh==1?"Nam":"Nữ");
                lbThongtinchitiet.Text += "\nCMND: " + docgia.CMND.ToString();
                lbThongtinchitiet.Text += "\nĐịa chỉ: " + docgia.DiaChi.ToString();
                lbThongtinchitiet.Text += "\nEmail: " + docgia.Email.ToString();
                lbThongtinchitiet.Text += "\nSố điện thoại: " + docgia.SoDienThoai.ToString();
                docgiainfo = docgia;
                DataSet ds = BUS.DocGiaBus.Timsach(madocgia);
                dtgSachmuon.DataSource = ds.Tables[0];
                dtgSachmuon.Columns[0].HeaderText = "Mã sách";
                dtgSachmuon.Columns[1].HeaderText = "Tên sách";
                dtgSachmuon.Columns[2].HeaderText = "Tác giả";
                dtgSachmuon.Columns[1].Width = 160;
                dtgSachmuon.Columns[2].Width = 160;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgDanhsach.SelectedRows.Count > 0)
            {
                int maDocGia = (int)dtgDanhsach.SelectedRows[0].Cells[0].Value;
                frmThemSuaDocgia frm = new frmThemSuaDocgia();
                frm.docgia = docgiainfo;
                frm.type = 1;
                frm.ShowDialog();
                Find();
                lbThongtinchitiet.Text = "Thông tin độc giả";
            }
            else
                MessageBox.Show("Bạn chưa chọn độc giả nào cả !!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgDanhsach.SelectedRows.Count > 0)
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                int maDocGia = (int)dtgDanhsach.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", button) == DialogResult.Yes)
                {
                    BUS.DocGiaBus.Delete(maDocGia);
                    Find();
                    lbThongtinchitiet.Text = "Thông tin độc giả";
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn độc giả nào cả !!");
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (dtgDanhsach.SelectedRows.Count > 0)
            {
                ((frmLapPhieuMuonSach)this.Owner).docgia = docgiainfo;
                this.Close();
            }
            else
                MessageBox.Show("Bạn chưa chọn độc giả nào cả !!");
        }
    }
}