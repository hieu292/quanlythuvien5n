using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BUS;
using DTO;

namespace QuanLyThuVien
{
    public partial class frmThemSuaSach : Form
    {
        public int type;
        public int mSach;
        public String tenSach;
        public int loaiSach;
        public String tacGia;
        public bool trangThai; //true: chưa cho mượn, false: đang cho mượn
        public int soTrang;
        public int ngonNgu;
        public frmThemSuaSach()
        {
            InitializeComponent();
            trangThai = true;
        }

        void Layloaisach()
        {
            IList list = BUS.LoaiSachBus.GetList();
            cmbLoaisach.Items.Clear();
            for (int count = 0; count < list.Count; count++)
            {
                cmbLoaisach.Items.Add(list[count]);
            }
            cmbLoaisach.DisplayMember = "tenLoaiSach";
            cmbLoaisach.ValueMember = "mLoaiSach";
        }

        void Layngonngu()
        {
            IList list = BUS.NgonNguBus.GetList();
            cmbNgonngu.Items.Clear();
            for (int count = 0; count < list.Count; count++)
            {
                cmbNgonngu.Items.Add(list[count]);
            }
            cmbNgonngu.DisplayMember = "tenNgonNgu";
            cmbNgonngu.ValueMember = "mNgonNgu";
        }

        private void frmThemSuaSach_Load(object sender, EventArgs e)
        {
            Layloaisach();
            Layngonngu();
            cmbNgonngu.SelectedIndex = 0;
            cmbLoaisach.SelectedIndex = 0;
            if (type == 0)
            {
                lbTitle.Text = "Thêm thông tin sách";
            }
            else
            {
                lbTitle.Text = "Sửa thông tin sách";
                txtTensach.Text = tenSach;
                int count;
                for (count = 0; count < cmbLoaisach.Items.Count; count++)
                    if (((LoaiSachDto)cmbLoaisach.Items[count]).MLoaiSach == loaiSach)
                        break;
                cmbLoaisach.SelectedIndex = count;
                numSotrang.Value = soTrang;
                //trangThai = trangThai;
                for (count = 0; count < cmbNgonngu.Items.Count; count++)
                    if (((NgonNguDto)cmbNgonngu.Items[count]).MaNgonNgu == ngonNgu)
                        break;
                cmbNgonngu.SelectedIndex = count;
                txtTacgia.Text = tacGia;

            }
        }

        private void btCapnhatloaisach_Click(object sender, EventArgs e)
        {
            frmCapnhatLoaisachNgonngu frm = new frmCapnhatLoaisachNgonngu();
            frm.type = 0;
            frm.ShowDialog();
            Layloaisach();
        }

        private void btCapnhatngonngu_Click(object sender, EventArgs e)
        {
            frmCapnhatLoaisachNgonngu frm = new frmCapnhatLoaisachNgonngu();
            frm.type = 1;
            frm.ShowDialog();
            Layngonngu();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            try
            {
                SachDto sach = new SachDto();
                sach.TenSach = txtTensach.Text;
                if (sach.TenSach.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên sách !!");
                    return;
                }
                sach.LoaiSach = ((LoaiSachDto)cmbLoaisach.SelectedItem).MLoaiSach;
                sach.SoTrang = (int)numSotrang.Value;
                sach.TrangThai = trangThai;
                sach.NgonNgu = ((NgonNguDto)cmbNgonngu.SelectedItem).MaNgonNgu;
                sach.TacGia = txtTacgia.Text;
                sach.MSach = mSach;
                if (type == 0)
                {
                    BUS.SachBus.Add(sach);
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    BUS.SachBus.Update(sach);
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}