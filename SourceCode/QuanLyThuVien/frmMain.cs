using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
/*
            if (e.X >= 0 && e.X < 250 && e.Y >= 250 && e.Y <= 400 )
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;

                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (e.X >= 275 && e.X < 450 && e.Y >= 225 && e.Y <= 375)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;

                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            if (e.X >= 700 && e.X < 800 && e.Y >= 175 && e.Y <= 600)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;

                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }*/

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void quanlydocgia(object sender, EventArgs e)
        {
            frmQuanlyDocgia frm = new frmQuanlyDocgia();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanlysach_Click(object sender, EventArgs e)
        {
            frmQuanlysach frm = new frmQuanlysach();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnulapphieumuonsach_Click(object sender, EventArgs e)
        {
            frmLapPhieuMuonSach frm = new frmLapPhieuMuonSach();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnutrasach_Click(object sender, EventArgs e)
        {
            frmNhansach frm = new frmNhansach();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuquanlyphieumuon_Click(object sender, EventArgs e)
        {
            frmQuanlydanhsachphieumuon frm = new frmQuanlydanhsachphieumuon();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanlyphieumuon_Click_1(object sender, EventArgs e)
        {
            frmQuanlydanhsachphieumuon frm = new frmQuanlydanhsachphieumuon();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }


    }
}