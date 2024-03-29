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
    public partial class frmNhansach : Form
    {
        public DataSet sachlist;
        public int mPhieu;
        public frmNhansach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanlydanhsachphieumuon frm = new frmQuanlydanhsachphieumuon();
            frm.type = 1;
            frm.Owner = this;
            sachlist = null;
            frm.ShowDialog();
            if (sachlist != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Chọn", System.Type.GetType("System.Boolean"));
                dt.Columns.Add("Mã sách", System.Type.GetType("System.Int16"));
                dt.Columns.Add("Tên sách", System.Type.GetType("System.String"));
                for (int count = 0; count < sachlist.Tables[0].Rows.Count; count++)
                    if ((bool)sachlist.Tables[0].Rows[count][2] == false)
                    {
                        DataRow rowdes = dt.NewRow();
                        rowdes[0] = false;
                        rowdes[1] = (int)sachlist.Tables[0].Rows[count][0];
                        rowdes[2] = sachlist.Tables[0].Rows[count][1].ToString();
                        dt.Rows.Add(rowdes);
                    }
                PhieuMuonDto phieu = BUS.PhieuMuonBus.Search(mPhieu);
                DocGiaDto docgia = BUS.DocGiaBus.Search(phieu.MDocGia);
                txtMadocgia.Text = phieu.MDocGia.ToString();
                txtHoTen.Text = docgia.HoTen;
                txtNgaymuon.Text = phieu.NgayMuon.ToShortDateString();
                txtSongay.Text = phieu.SoNgayMuon.ToString();
                dtgSach.DataSource = dt;
                dtgSach.Columns[2].Width = 220;
            }
        }

        private void btTrasach_Click(object sender, EventArgs e)
        {
            try
            {
                if ((DataTable)dtgSach.DataSource == null)
                {

                    return;
                }

                if (((DataTable)dtgSach.DataSource).Rows.Count == 0)
                {

                    return;
                }
                DataTable dt = (DataTable)dtgSach.DataSource;
                int numcheck = 0;
                for (int count = 0; count < dt.Rows.Count; count++)
                    if ((bool)dt.Rows[count][0] == true)
                    {
                        BUS.SachBus.UpdateTrangThai(int.Parse(dt.Rows[count][1].ToString()), true);
                        numcheck++;
                    }
                if (numcheck == sachlist.Tables[0].Rows.Count)
                {
                    BUS.PhieuMuonBus.UpdateTrangThai(mPhieu, true);
                }
                MessageBox.Show("Nhận sách trả thành công !!");
                dtgSach.Columns.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}