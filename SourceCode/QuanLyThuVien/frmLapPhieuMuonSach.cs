using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Collections;
namespace QuanLyThuVien
{
    public partial class frmLapPhieuMuonSach : Form
    {
        public DataSet sachlist = null;
        public int mPhieu;
        public int type = 0;
        public bool trangThai = false;
        public DateTime ngaymuon;
        public int songay;
        public DocGiaDto docgia = null;
        public frmLapPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Find();
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
                lbLoaitimkiem.Visible = true;
                lbThongbao.Text = "";
                switch (pos)
                {
                    case 0:
                        lbLoaitimkiem.Text = "";
                        sach.TenSach = "";
                        break;
                    case 1:
                        lbLoaitimkiem.Text = "Tên sách";
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

                }
                DataSet ds = BUS.SachBus.Timsach(sach, sach2);
                DataTable dt = new DataTable();
                dt.Columns.Add("Chọn", System.Type.GetType("System.Boolean"));
                dt.Columns.Add("Mã sách", System.Type.GetType("System.Int16"));
                dt.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow rows = dt.NewRow();
                    rows[0] = false;
                    rows[1] = row[0];
                    rows[2] = row[1];
                    dt.Rows.Add(rows);
                }
                dtgDanhmucsach.Columns.Clear();
                dtgDanhmucsach.DataSource = dt;
                dtgDanhmucsach.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanlyDocgia frm = new frmQuanlyDocgia();
            frm.chon = 1;
            frm.Owner = this;
            frm.ShowDialog();
            if (docgia != null)
            {
                txtHoten.Text = docgia.HoTen;
                txtNgaysinh.Text = docgia.NgaySinh.ToShortDateString();
                txtSoDT.Text = docgia.SoDienThoai.ToString();
                txtCMND.Text = docgia.CMND;
                txtDiachi.Text = docgia.DiaChi;
                txtEmail.Text = docgia.Email;
                txtGioitinh.Text = docgia.GioiTinh == 1 ? "Nam" : "Nữ";
            }
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

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dtgDanhmucsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                DataTable dt = (DataTable)dtgSachchon.DataSource;
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Chọn", System.Type.GetType("System.Boolean"));
                    dt.Columns.Add("Mã sách", System.Type.GetType("System.Int16"));
                    dt.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                }
                if ((bool)dtgDanhmucsach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    DataRow row = ((DataTable)dtgDanhmucsach.DataSource).Rows[e.RowIndex];
                    //dtgSachchon.Columns.Clear();
                    DataRow rowdes = dt.NewRow();
                    rowdes[0] = row[0];
                    rowdes[1] = row[1];
                    rowdes[2] = row[2];
                    dt.Rows.Add(rowdes);
                    dtgSachchon.DataSource = dt;
                }
                else
                {
                    int maSach = int.Parse(dtgDanhmucsach.Rows[e.RowIndex].Cells[1].Value.ToString());
                    for (int count = dt.Rows.Count-1; count>=0; count--)
                    {
                        if (int.Parse(dt.Rows[count][1].ToString()) == maSach)
                            dt.Rows.RemoveAt(count);
                    }
                    dtgSachchon.DataSource = dt;

                }

                dtgSachchon.Columns[2].Width = 200;
        }

        private void dtgDanhmucsach_CurrentCellChanged(object sender, EventArgs e)
        {
            //dtgDanhmucsach.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dtgDanhmucsach_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgDanhmucsach.IsCurrentCellDirty)
            {
                dtgDanhmucsach.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }  
        }

        private void dtgSachchon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataTable dt = (DataTable)dtgSachchon.DataSource;
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Chọn", System.Type.GetType("System.Boolean"));
                    dt.Columns.Add("Mã sách", System.Type.GetType("System.Int16"));
                    dt.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                }
                dt.Rows.RemoveAt(e.RowIndex);
                dtgSachchon.DataSource = dt;
                dtgSachchon.Columns[2].Width = 200;
            }
       
        }

        private void dtgSachchon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgSachchon.IsCurrentCellDirty)
            {
                dtgSachchon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            try
            {
                if (docgia == null)
                {
                    MessageBox.Show("Bạn chưa chọn độc giả !!");
                    return;
                }
                if ((DataTable)dtgSachchon.DataSource == null)
                {
                    MessageBox.Show("Bạn chưa chọn sách mượn !!");
                    return;
                }
                if (((DataTable)dtgSachchon.DataSource).Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn sách mượn !!");
                    return;
                }
                PhieuMuonDto phieu = new PhieuMuonDto();
                int count;
                phieu.MDocGia = docgia.MDocGia;
                phieu.NgayMuon = dayNgaymuon.Value;
                phieu.SoNgayMuon = (int)numSongaymuon.Value;
                phieu.TrangThai = trangThai;
                if (sachlist != null) 
                for (count = 0; count < sachlist.Tables[0].Rows.Count; count++ )
                    if (trangThai == false)
                    {
                        BUS.SachBus.UpdateTrangThai((int)sachlist.Tables[0].Rows[count][0], true);
                    }
                if (type == 0)
                {
                    int maphieu = BUS.PhieuMuonBus.Add(phieu);
                    DataTable dt = (DataTable)dtgSachchon.DataSource;
                    ChiTietPhieuMuonDto chitiet = new ChiTietPhieuMuonDto();
                    chitiet.MaPhieu = maphieu;
                    for (count = 0; count < dt.Rows.Count; count++)
                    {
                        chitiet.MaSach = int.Parse(dt.Rows[count][1].ToString());
                        BUS.ChiTietPhieuMuonBus.Add(chitiet);
                        BUS.SachBus.UpdateTrangThai(chitiet.MaSach, false);
                    }
                    MessageBox.Show("Lập phiếu thành công");
                    this.Close();
                }
                else
                {
                    BUS.PhieuMuonBus.Delete(mPhieu);
                    int maphieu = BUS.PhieuMuonBus.Add(phieu);
                    DataTable dt = (DataTable)dtgSachchon.DataSource;
                    ChiTietPhieuMuonDto chitiet = new ChiTietPhieuMuonDto();
                    chitiet.MaPhieu = maphieu;
                    for (count = 0; count < dt.Rows.Count; count++)
                    {
                        chitiet.MaSach = int.Parse(dt.Rows[count][1].ToString());
                        BUS.ChiTietPhieuMuonBus.Add(chitiet);
                        if (trangThai == false)
                            BUS.SachBus.UpdateTrangThai(chitiet.MaSach, false);
                    }
                    MessageBox.Show("Sửa phiếu thành công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLapPhieuMuonSach_Load(object sender, EventArgs e)
        {
            cmbTimkiem.SelectedIndex = 0;
            if (type == 1)
            {
                docgia =  BUS.DocGiaBus.TimDocgiaTheoPhieu(mPhieu);
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt.Columns.Add("Chọn", System.Type.GetType("System.Boolean"));
                dt.Columns.Add("Mã sách", System.Type.GetType("System.Int16"));
                dt.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                for (int count = 0; count < sachlist.Tables[0].Rows.Count; count++)
                {
                    DataRow rowdes = dt.NewRow();
                    rowdes[0] = true;
                    rowdes[1] = (int)sachlist.Tables[0].Rows[count][0];
                    rowdes[2] = sachlist.Tables[0].Rows[count][1].ToString();
                    dt.Rows.Add(rowdes);

                }

                if (docgia != null)
                {
                    txtHoten.Text = docgia.HoTen;
                    txtNgaysinh.Text = docgia.NgaySinh.ToShortDateString();
                    txtSoDT.Text = docgia.SoDienThoai.ToString();
                    txtCMND.Text = docgia.CMND;
                    txtDiachi.Text = docgia.DiaChi;
                    txtEmail.Text = docgia.Email;
                    txtGioitinh.Text = docgia.GioiTinh == 1 ? "Nam" : "Nữ";
                }
                dtgSachchon.DataSource = dt;
                dtgSachchon.Columns[2].Width = 200;
                dayNgaymuon.Value = ngaymuon;
                numSongaymuon.Value = (int)songay;
                lbTitle.Text = "Sửa phiếu mượn sách";
            }
        }
    }
}