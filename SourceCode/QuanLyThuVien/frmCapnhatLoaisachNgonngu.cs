using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyThuVien
{
    public partial class frmCapnhatLoaisachNgonngu : Form
    {
        public int type;

        public frmCapnhatLoaisachNgonngu()
        {
            InitializeComponent();
            type = 1;
        }

        void Laydanhsach()
        {
            if (type == 0)
            {
                DataSet ds = BUS.LoaiSachBus.GetTable();
                dtgDanhshach.DataSource = ds.Tables[0];

            }
            else if (type == 1)
            {
                DataSet dt = BUS.NgonNguBus.GetTable();
                dtgDanhshach.DataSource = dt.Tables[0];
            }
        }

        private void frmCapnhatLoaisachNgonngu_Load(object sender, EventArgs e)
        {
            try
            {
                if (type == 0)
                {
                    this.Text = lbTitle.Text = "Cập nhật loại sách";
                }
                else if (type == 1)
                {
                    this.Text = lbTitle.Text = "Cập nhật ngôn ngữ";
                }
                Laydanhsach();
                dtgDanhshach.Columns[0].Width = 100;
                dtgDanhshach.Columns[0].ReadOnly = true;
                dtgDanhshach.Columns[1].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dtgDanhshach.DataSource; 
                if (type == 0)
                    BUS.LoaiSachBus.CapNhatBang(dt.DataSet);
                else
                    BUS.NgonNguBus.CapNhatBang(dt.DataSet);
                Laydanhsach();
                dtgDanhshach.Columns[0].Width = 100;
                dtgDanhshach.Columns[0].ReadOnly = true;
                dtgDanhshach.Columns[1].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}