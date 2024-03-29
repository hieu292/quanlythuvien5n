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
    public partial class frmQuanlydanhsachphieumuon : Form
    {
        public int type = 0;
        public DataSet sachlist ;
        public int mPhieu = -1;
        public frmQuanlydanhsachphieumuon()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanlydanhsachphieumuon_Load(object sender, EventArgs e)
        {
            cmbTimkiem.SelectedIndex = 0;
            if (type == 1)
            {
                btChon.Visible = true;
                btThem.Visible = btXoa.Visible = btSua.Visible = false;
            }
            dayNgaycuoi.Value = DateTime.Now.AddDays(2);
            dayNgaydau.Value = DateTime.Now.AddDays(-2);
            Show();
        }

        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                lbTimkiem.Visible = true;
                switch (pos)
                {
                    case 0:
                        lbTimkiem.Text = "";
                        dayNgaydau.Visible = false;
                        dayNgaycuoi.Visible = false;
                        lbNgaymuon.Visible = false;
                        numNgaymuon.Visible = false;
                        break;
                    case 1:
                        lbTimkiem.Text = "Từ ngày";
                        dayNgaydau.Visible = true;
                        dayNgaycuoi.Visible = true;
                        lbNgaymuon.Visible = true;
                        numNgaymuon.Visible = false;
                        break;
                    case 2:
                        lbTimkiem.Text = "Số ngày mượn";
                        dayNgaydau.Visible = false;
                        dayNgaycuoi.Visible = false;
                        lbNgaymuon.Visible = false;
                        numNgaymuon.Visible = true;
                        break;
                    case 3:
                        lbTimkiem.Visible = false;
                        dayNgaydau.Visible = false;
                        dayNgaycuoi.Visible = false;
                        lbNgaymuon.Visible = false;
                        numNgaymuon.Visible = false;
                        break;

                }
            }
            catch (Exception ex)
            {

            }
        }

        void Show()
        {
            try
            {
                int pos = cmbTimkiem.SelectedIndex;
                DataSet ds;
                switch (pos)
                {
                    case 0:
                        ds = BUS.PhieuMuonBus.SearchAll();
                        dtgPhieu.DataSource = ds.Tables[0];
                        break;
                    case 1:
                        ds = BUS.PhieuMuonBus.SearchDay(dayNgaydau.Value, dayNgaycuoi.Value);
                        dtgPhieu.DataSource = ds.Tables[0];
                        break;
                    case 2:
                        ds = BUS.PhieuMuonBus.Searchnumday((int)numNgaymuon.Value);
                        dtgPhieu.DataSource = ds.Tables[0];
                        break;
                    case 3:
                        ds = BUS.PhieuMuonBus.SearchLate();
                        DataTable dt = ds.Tables[0];
                        for (int count = dt.Rows.Count - 1; count >= 0; count--)
                        {
                            TimeSpan khoangcach = DateTime.Now - (DateTime)dt.Rows[count][2];
                            if (khoangcach.Days <= (int)dt.Rows[count][3])
                            {
                                dt.Rows.RemoveAt(count);
                            }

                        }
                        dtgPhieu.DataSource = dt;
                        break;

                }

                dtgPhieu.Columns[0].HeaderText = "Mã phiếu";
                dtgPhieu.Columns[1].HeaderText = "Họ tên";
                dtgPhieu.Columns[2].HeaderText = "Ngày mượn";
                dtgPhieu.Columns[3].HeaderText = "Số ngày";
                dtgPhieu.Columns[4].HeaderText = "Phiếu trả đủ sách";

            }
            catch (Exception ex)
            {

            }

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLapPhieuMuonSach frm = new frmLapPhieuMuonSach();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgPhieu.SelectedRows.Count > 0)
            {
                mPhieu = (int)dtgPhieu.SelectedRows[0].Cells[0].Value;
                sachlist = BUS.SachBus.Timsachtheophieu(mPhieu);
                dtgSach.DataSource = sachlist.Tables[0];
                dtgSach.Columns[0].Width = 100;
                dtgSach.Columns[1].Width = 270;
                dtgSach.Columns[0].HeaderText = "Mã sách";
                dtgSach.Columns[1].HeaderText = "Tên sách";
                dtgSach.Columns.RemoveAt(2);
                //dtgSach.Columns[2].HeaderText = "Chưa mượn";

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dtgPhieu.SelectedRows.Count > 0)
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", button) == DialogResult.Yes)
                {
                    for (int count = 0; count < sachlist.Tables[0].Rows.Count; count++)
                    {
                        int mSach = (int)sachlist.Tables[0].Rows[count][0];
                        BUS.SachBus.UpdateTrangThai(mSach, true);
                    }
                    BUS.PhieuMuonBus.Delete(mPhieu);

                }
                Show();
            }
            else 
            {
                MessageBox.Show("Bạn chưa chọn phiếu nào cả !!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dtgPhieu.SelectedRows.Count > 0)
            {
                frmLapPhieuMuonSach frm = new frmLapPhieuMuonSach();
                frm.sachlist = sachlist;
                frm.mPhieu = mPhieu;
                frm.type = 1;
                frm.ngaymuon = (DateTime) dtgPhieu.SelectedRows[0].Cells[2].Value;
                frm.songay = (int) dtgPhieu.SelectedRows[0].Cells[3].Value;
                frm.trangThai = (bool)dtgPhieu.SelectedRows[0].Cells[4].Value;
                frm.ShowDialog();
                Show();
            }
            else 
            {
                MessageBox.Show("Bạn chưa chọn phiếu nào cả !!");
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (dtgPhieu.SelectedRows.Count > 0)
            {
                frmNhansach frm = (frmNhansach)this.Owner;
                frm.sachlist = this.sachlist;
                frm.mPhieu = this.mPhieu;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phiếu nào cả !!");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}