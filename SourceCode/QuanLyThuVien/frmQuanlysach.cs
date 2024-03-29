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
    public partial class frmQuanlysach : Form
    {
        SachDto sachinfo = new SachDto();

        public frmQuanlysach()
        {
            InitializeComponent();
        }

        void Layloaisach()
        {
            IList list = BUS.LoaiSachBus.GetList();
            cmbLoaisachNgonngu.Items.Clear();
            cmbLoaisachNgonngu.Text = "";
            for (int count = 0; count < list.Count; count++)
            {
                cmbLoaisachNgonngu.Items.Add(list[count]);
            }
            cmbLoaisachNgonngu.DisplayMember = "tenLoaiSach";
            cmbLoaisachNgonngu.ValueMember = "mLoaiSach";
        }

        void Layngonngu()
        {
            IList list = BUS.NgonNguBus.GetList();
            cmbLoaisachNgonngu.Items.Clear();
            cmbLoaisachNgonngu.Text = "";
            for (int count = 0; count < list.Count; count++)
            {
                cmbLoaisachNgonngu.Items.Add(list[count]);
            }
            cmbLoaisachNgonngu.DisplayMember = "tenNgonNgu";
            cmbLoaisachNgonngu.ValueMember = "mNgonNgu";
        }
        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                lbLoaitimkiem.Visible = true;
                btTimkiem.Enabled = true;
                lbThongbao.Text = "";
                switch (pos)
                {
                    case 0:
                        lbLoaitimkiem.Text = "";
                        txtTensachTacgia.Visible = false;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = false;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        break;
                    case 1:
                        lbLoaitimkiem.Text = "Tên sách";
                        txtTensachTacgia.Visible = true;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = false;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        break;
                    case 2:
                        lbLoaitimkiem.Text = "Loại sách";
                        txtTensachTacgia.Visible = false;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = true;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        Layloaisach();
                        cmbLoaisachNgonngu.SelectedIndex = 0;
                        break;
                    case 3:
                        lbLoaitimkiem.Text = "Tác giả";
                        txtTensachTacgia.Visible = true;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = false;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        break;
                    case 4:
                        lbLoaitimkiem.Text = "Số trang";
                        txtTensachTacgia.Visible = false;
                        numSotrangdau.Visible = true;
                        cmbLoaisachNgonngu.Visible = false;
                        numSotrangsau.Visible = true;
                        lbSotrang.Visible = true;
                        break;
                    case 5:
                        lbLoaitimkiem.Text = "Ngôn ngữ";
                        txtTensachTacgia.Visible = false;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = true;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        Layngonngu();
                        cmbLoaisachNgonngu.SelectedIndex = 0;
                        break;
                    case 6:
                        lbLoaitimkiem.Text = "Tình trạng";
                        txtTensachTacgia.Visible = false;
                        numSotrangdau.Visible = false;
                        cmbLoaisachNgonngu.Visible = true;
                        numSotrangsau.Visible = false;
                        lbSotrang.Visible = false;
                        cmbLoaisachNgonngu.Items.Clear();
                        cmbLoaisachNgonngu.Items.Add("Đã mượn");
                        cmbLoaisachNgonngu.Items.Add("Chưa mượn");
                        cmbLoaisachNgonngu.SelectedIndex = 0;
                        break;

                }
            }
            catch (Exception ex)
            {

            }
        }

        void Find()
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                SachDto sach = new SachDto();
                SachDto sach2 = new SachDto();
                sach.TenSach = null;
                sach.LoaiSach = -1;
                sach.SoTrang = -1;
                sach.TrangThai = true;
                sach.NgonNgu = -1;
                sach.TacGia = null;
                lbThongbao.Text = "";
                //lbLoaitimkiem.Visible = true;
                switch (pos)
                {
                    case 0:
                        sach.TenSach = "";
                        break;
                    case 1:
                        sach.TenSach = txtTensachTacgia.Text;
                        if (sach.TenSach.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập tên sách cần tìm !!";
                            return;
                        }
                        break;
                    case 2:
                        lbLoaitimkiem.Text = "Loại sách";
                        sach.LoaiSach = ((LoaiSachDto)cmbLoaisachNgonngu.SelectedItem).MLoaiSach;
                        break;
                    case 3:
                        lbLoaitimkiem.Text = "Tác giả";
                        sach.TacGia = txtTensachTacgia.Text;
                        if (sach.TacGia.ToString().Length == 0)
                        {
                            lbThongbao.Text = "Bạn chưa nhập tác giả cần tìm !!";
                            return;
                        }
                        break;
                    case 4:
                        lbLoaitimkiem.Text = "Số trang";
                        sach.SoTrang = (int)numSotrangdau.Value;
                        sach2.SoTrang = (int)numSotrangsau.Value;
                        break;
                    case 5:
                        lbLoaitimkiem.Text = "Ngôn ngữ";
                        sach.NgonNgu = ((NgonNguDto)cmbLoaisachNgonngu.SelectedItem).MaNgonNgu;
                        break;
                    case 6:
                        if (cmbLoaisachNgonngu.SelectedIndex == 0)
                            sach.TrangThai = false;
                        else
                            sach.TrangThai = true;

                        break;

                }
                DataSet ds = BUS.SachBus.Search(sach, sach2);
                dtgDanhmucsach.DataSource = ds.Tables[0];
                dtgDanhmucsach.Columns[1].Width += 250;
                dtgDanhmucsach.Columns[0].HeaderText = "Mã sách";
                dtgDanhmucsach.Columns[1].HeaderText = "Tên sách";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            Find();
        }

        void Show()
        {
            int sach = (int)dtgDanhmucsach.SelectedRows[0].Cells[0].Value ;
            DataSet ds = BUS.SachBus.Search(sach);
            lbThongtinchitiet.Text = "Tên sách: " + ds.Tables[0].Rows[0][0].ToString();
            lbThongtinchitiet.Text += "\nTác giả: " + ds.Tables[0].Rows[0][1].ToString();
            lbThongtinchitiet.Text += "\nTrạng thái: " + ((bool)ds.Tables[0].Rows[0][2]?"Chưa mượn":"Đã mượn");
            lbThongtinchitiet.Text += "\nSố trang: " + ds.Tables[0].Rows[0][3].ToString();
            lbThongtinchitiet.Text += "\nLoại sách: " + ds.Tables[0].Rows[0][4].ToString();
            lbThongtinchitiet.Text += "\nNgôn ngữ: " + ds.Tables[0].Rows[0][5].ToString();
            sachinfo.MSach = sach;
            sachinfo.TenSach = ds.Tables[0].Rows[0][0].ToString();
            sachinfo.TacGia = ds.Tables[0].Rows[0][1].ToString();
            sachinfo.TrangThai = (bool)ds.Tables[0].Rows[0][2];
            sachinfo.SoTrang = (int)ds.Tables[0].Rows[0][3];
            sachinfo.LoaiSach = (int)ds.Tables[0].Rows[0][6];
            sachinfo.NgonNgu = (int)ds.Tables[0].Rows[0][7];

        }

        private void dtgDanhmucsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDanhmucsach.SelectedRows.Count > 0)
            {
                Show();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemSuaSach frm = new frmThemSuaSach();
            frm.type = 0;
            frm.ShowDialog();
            Find();
            lbThongtinchitiet.Text = "Thông tin chi tiết";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgDanhmucsach.SelectedRows.Count > 0)
            {
                frmThemSuaSach frm = new frmThemSuaSach();
                frm.type = 1;
                frm.mSach = sachinfo.MSach;
                frm.tenSach = sachinfo.TenSach;
                frm.tacGia = sachinfo.TacGia;
                frm.trangThai = sachinfo.TrangThai;
                frm.soTrang = sachinfo.SoTrang;
                frm.ngonNgu = sachinfo.NgonNgu;
                frm.loaiSach = sachinfo.LoaiSach;
                frm.ShowDialog();
                Find();
                lbThongtinchitiet.Text = "Thông tin chi tiết";
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách cần sửa thông tin!!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgDanhmucsach.SelectedRows.Count > 0)
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                int msach = (int)dtgDanhmucsach.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", button) == DialogResult.Yes)
                {

                    BUS.SachBus.Delete(msach);
                    Find();
                    lbThongtinchitiet.Text = "Thông tin chi tiết";
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách cần xóa !!");
            }
        }

        private void frmQuanlysach_Load(object sender, EventArgs e)
        {
            cmbTimkiem.SelectedIndex = 0;
        }
    }
}