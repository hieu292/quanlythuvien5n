namespace QuanLyThuVien
{
    partial class frmQuanlysach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlysach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.PictureBox();
            this.btXoa = new System.Windows.Forms.PictureBox();
            this.btThem = new System.Windows.Forms.PictureBox();
            this.lbThongtinchitiet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDanhmucsach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSotrang = new System.Windows.Forms.Label();
            this.numSotrangsau = new System.Windows.Forms.NumericUpDown();
            this.btTimkiem = new System.Windows.Forms.PictureBox();
            this.numSotrangdau = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaisachNgonngu = new System.Windows.Forms.ComboBox();
            this.txtTensachTacgia = new System.Windows.Forms.TextBox();
            this.lbLoaitimkiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimkiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhmucsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSotrangsau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSotrangdau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(242, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sách\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbThongbao);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.lbThongtinchitiet);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 447);
            this.panel2.TabIndex = 1;
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThongbao.Location = new System.Drawing.Point(25, 111);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(0, 13);
            this.lbThongbao.TabIndex = 39;
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(613, 385);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(55, 59);
            this.btSua.TabIndex = 10;
            this.btSua.TabStop = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(534, 385);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(55, 59);
            this.btXoa.TabIndex = 9;
            this.btXoa.TabStop = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(449, 385);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(55, 59);
            this.btThem.TabIndex = 8;
            this.btThem.TabStop = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbThongtinchitiet
            // 
            this.lbThongtinchitiet.AutoSize = true;
            this.lbThongtinchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinchitiet.ForeColor = System.Drawing.Color.Blue;
            this.lbThongtinchitiet.Location = new System.Drawing.Point(423, 149);
            this.lbThongtinchitiet.Name = "lbThongtinchitiet";
            this.lbThongtinchitiet.Size = new System.Drawing.Size(163, 20);
            this.lbThongtinchitiet.TabIndex = 2;
            this.lbThongtinchitiet.Text = "Thông tin chi tiết sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgDanhmucsach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sách";
            // 
            // dtgDanhmucsach
            // 
            this.dtgDanhmucsach.AllowUserToAddRows = false;
            this.dtgDanhmucsach.AllowUserToDeleteRows = false;
            this.dtgDanhmucsach.AllowUserToResizeColumns = false;
            this.dtgDanhmucsach.AllowUserToResizeRows = false;
            this.dtgDanhmucsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhmucsach.Location = new System.Drawing.Point(9, 24);
            this.dtgDanhmucsach.Name = "dtgDanhmucsach";
            this.dtgDanhmucsach.ReadOnly = true;
            this.dtgDanhmucsach.Size = new System.Drawing.Size(370, 261);
            this.dtgDanhmucsach.TabIndex = 0;
            this.dtgDanhmucsach.SelectionChanged += new System.EventHandler(this.dtgDanhmucsach_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSotrang);
            this.groupBox1.Controls.Add(this.numSotrangsau);
            this.groupBox1.Controls.Add(this.btTimkiem);
            this.groupBox1.Controls.Add(this.numSotrangdau);
            this.groupBox1.Controls.Add(this.cmbLoaisachNgonngu);
            this.groupBox1.Controls.Add(this.txtTensachTacgia);
            this.groupBox1.Controls.Add(this.lbLoaitimkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin sách";
            // 
            // lbSotrang
            // 
            this.lbSotrang.AutoSize = true;
            this.lbSotrang.ForeColor = System.Drawing.Color.Black;
            this.lbSotrang.Location = new System.Drawing.Point(218, 64);
            this.lbSotrang.Name = "lbSotrang";
            this.lbSotrang.Size = new System.Drawing.Size(35, 17);
            this.lbSotrang.TabIndex = 9;
            this.lbSotrang.Text = "đến";
            this.lbSotrang.Visible = false;
            // 
            // numSotrangsau
            // 
            this.numSotrangsau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSotrangsau.Location = new System.Drawing.Point(272, 61);
            this.numSotrangsau.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numSotrangsau.Name = "numSotrangsau";
            this.numSotrangsau.Size = new System.Drawing.Size(72, 23);
            this.numSotrangsau.TabIndex = 8;
            this.numSotrangsau.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSotrangsau.Visible = false;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.Location = new System.Drawing.Point(494, 29);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(55, 46);
            this.btTimkiem.TabIndex = 7;
            this.btTimkiem.TabStop = false;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // numSotrangdau
            // 
            this.numSotrangdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSotrangdau.Location = new System.Drawing.Point(124, 61);
            this.numSotrangdau.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numSotrangdau.Name = "numSotrangdau";
            this.numSotrangdau.Size = new System.Drawing.Size(72, 23);
            this.numSotrangdau.TabIndex = 6;
            this.numSotrangdau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSotrangdau.Visible = false;
            // 
            // cmbLoaisachNgonngu
            // 
            this.cmbLoaisachNgonngu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaisachNgonngu.FormattingEnabled = true;
            this.cmbLoaisachNgonngu.Location = new System.Drawing.Point(125, 61);
            this.cmbLoaisachNgonngu.Name = "cmbLoaisachNgonngu";
            this.cmbLoaisachNgonngu.Size = new System.Drawing.Size(114, 24);
            this.cmbLoaisachNgonngu.TabIndex = 5;
            this.cmbLoaisachNgonngu.Visible = false;
            // 
            // txtTensachTacgia
            // 
            this.txtTensachTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensachTacgia.Location = new System.Drawing.Point(125, 61);
            this.txtTensachTacgia.Name = "txtTensachTacgia";
            this.txtTensachTacgia.Size = new System.Drawing.Size(219, 23);
            this.txtTensachTacgia.TabIndex = 4;
            this.txtTensachTacgia.Visible = false;
            // 
            // lbLoaitimkiem
            // 
            this.lbLoaitimkiem.AutoSize = true;
            this.lbLoaitimkiem.ForeColor = System.Drawing.Color.Black;
            this.lbLoaitimkiem.Location = new System.Drawing.Point(13, 64);
            this.lbLoaitimkiem.Name = "lbLoaitimkiem";
            this.lbLoaitimkiem.Size = new System.Drawing.Size(75, 17);
            this.lbLoaitimkiem.TabIndex = 3;
            this.lbLoaitimkiem.Text = "Tên sách";
            this.lbLoaitimkiem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo";
            // 
            // cmbTimkiem
            // 
            this.cmbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimkiem.FormattingEnabled = true;
            this.cmbTimkiem.Items.AddRange(new object[] {
            "Tất cả",
            "Tên sách",
            "Loại sách",
            "Tác giả",
            "Số trang",
            "Ngôn ngữ",
            "Tình trạng"});
            this.cmbTimkiem.Location = new System.Drawing.Point(124, 29);
            this.cmbTimkiem.Name = "cmbTimkiem";
            this.cmbTimkiem.Size = new System.Drawing.Size(220, 24);
            this.cmbTimkiem.TabIndex = 1;
            this.cmbTimkiem.SelectedIndexChanged += new System.EventHandler(this.cmbTimkiem_SelectedIndexChanged);
            // 
            // frmQuanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(742, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanlysach";
            this.Text = "Quan ly sach";
            this.Load += new System.EventHandler(this.frmQuanlysach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhmucsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSotrangsau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSotrangdau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTimkiem;
        private System.Windows.Forms.NumericUpDown numSotrangdau;
        private System.Windows.Forms.ComboBox cmbLoaisachNgonngu;
        private System.Windows.Forms.Label lbLoaitimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbThongtinchitiet;
        private System.Windows.Forms.PictureBox btTimkiem;
        private System.Windows.Forms.PictureBox btSua;
        private System.Windows.Forms.PictureBox btXoa;
        private System.Windows.Forms.PictureBox btThem;
        private System.Windows.Forms.DataGridView dtgDanhmucsach;
        private System.Windows.Forms.Label lbSotrang;
        private System.Windows.Forms.NumericUpDown numSotrangsau;
        private System.Windows.Forms.TextBox txtTensachTacgia;
        private System.Windows.Forms.Label lbThongbao;
    }
}