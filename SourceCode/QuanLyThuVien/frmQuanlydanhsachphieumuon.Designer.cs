namespace QuanLyThuVien
{
    partial class frmQuanlydanhsachphieumuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlydanhsachphieumuon));
            this.btSua = new System.Windows.Forms.PictureBox();
            this.btXoa = new System.Windows.Forms.PictureBox();
            this.numNgaymuon = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPhieu = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.PictureBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimkiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dayNgaydau = new System.Windows.Forms.DateTimePicker();
            this.dayNgaycuoi = new System.Windows.Forms.DateTimePicker();
            this.lbNgaymuon = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btChon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgaymuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThem)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTim)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(661, 418);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(55, 59);
            this.btSua.TabIndex = 10;
            this.btSua.TabStop = false;
            this.btSua.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btXoa
            // 
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(571, 418);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(55, 59);
            this.btXoa.TabIndex = 9;
            this.btXoa.TabStop = false;
            this.btXoa.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // numNgaymuon
            // 
            this.numNgaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNgaymuon.Location = new System.Drawing.Point(124, 61);
            this.numNgaymuon.Name = "numNgaymuon";
            this.numNgaymuon.Size = new System.Drawing.Size(72, 23);
            this.numNgaymuon.TabIndex = 6;
            this.numNgaymuon.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numNgaymuon.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPhieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu mượn";
            // 
            // dtgPhieu
            // 
            this.dtgPhieu.AllowUserToAddRows = false;
            this.dtgPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieu.Location = new System.Drawing.Point(9, 24);
            this.dtgPhieu.Name = "dtgPhieu";
            this.dtgPhieu.ReadOnly = true;
            this.dtgPhieu.Size = new System.Drawing.Size(429, 302);
            this.dtgPhieu.TabIndex = 0;
            this.dtgPhieu.SelectionChanged += new System.EventHandler(this.dtgPhieu_SelectionChanged);
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(483, 418);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(55, 59);
            this.btThem.TabIndex = 8;
            this.btThem.TabStop = false;
            this.btThem.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.ForeColor = System.Drawing.Color.Black;
            this.lbTimkiem.Location = new System.Drawing.Point(13, 64);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(67, 17);
            this.lbTimkiem.TabIndex = 3;
            this.lbTimkiem.Text = "Từ ngày";
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
            "Ngày mượn",
            "Số ngày mượn",
            "Phiếu quá hạn"});
            this.cmbTimkiem.Location = new System.Drawing.Point(124, 29);
            this.cmbTimkiem.Name = "cmbTimkiem";
            this.cmbTimkiem.Size = new System.Drawing.Size(220, 24);
            this.cmbTimkiem.TabIndex = 1;
            this.cmbTimkiem.SelectedIndexChanged += new System.EventHandler(this.cmbTimkiem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(262, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu mượn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 45);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dayNgaydau);
            this.groupBox1.Controls.Add(this.dayNgaycuoi);
            this.groupBox1.Controls.Add(this.lbNgaymuon);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.numNgaymuon);
            this.groupBox1.Controls.Add(this.lbTimkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin phiếu";
            // 
            // dayNgaydau
            // 
            this.dayNgaydau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNgaydau.Location = new System.Drawing.Point(124, 61);
            this.dayNgaydau.Name = "dayNgaydau";
            this.dayNgaydau.Size = new System.Drawing.Size(169, 23);
            this.dayNgaydau.TabIndex = 10;
            this.dayNgaydau.Value = new System.DateTime(2009, 4, 22, 0, 0, 0, 0);
            // 
            // dayNgaycuoi
            // 
            this.dayNgaycuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNgaycuoi.Location = new System.Drawing.Point(396, 63);
            this.dayNgaycuoi.Name = "dayNgaycuoi";
            this.dayNgaycuoi.Size = new System.Drawing.Size(164, 23);
            this.dayNgaycuoi.TabIndex = 9;
            this.dayNgaycuoi.Value = new System.DateTime(2009, 4, 24, 0, 0, 0, 0);
            // 
            // lbNgaymuon
            // 
            this.lbNgaymuon.AutoSize = true;
            this.lbNgaymuon.ForeColor = System.Drawing.Color.Black;
            this.lbNgaymuon.Location = new System.Drawing.Point(314, 64);
            this.lbNgaymuon.Name = "lbNgaymuon";
            this.lbNgaymuon.Size = new System.Drawing.Size(77, 17);
            this.lbNgaymuon.TabIndex = 8;
            this.lbNgaymuon.Text = "Đến ngày";
            // 
            // btTim
            // 
            this.btTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTim.Image = ((System.Drawing.Image)(resources.GetObject("btTim.Image")));
            this.btTim.Location = new System.Drawing.Point(595, 29);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(55, 46);
            this.btTim.TabIndex = 7;
            this.btTim.TabStop = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btChon);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(7, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 471);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.SeaShell;
            this.btChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChon.Location = new System.Drawing.Point(480, 418);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(121, 39);
            this.btChon.TabIndex = 11;
            this.btChon.Text = "Chọn phiếu mượn";
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Visible = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtgSach);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(480, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh mục sách mượn";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtgSach
            // 
            this.dtgSach.AllowUserToResizeColumns = false;
            this.dtgSach.AllowUserToResizeRows = false;
            this.dtgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSach.Location = new System.Drawing.Point(6, 22);
            this.dtgSach.Name = "dtgSach";
            this.dtgSach.ReadOnly = true;
            this.dtgSach.RowHeadersVisible = false;
            this.dtgSach.Size = new System.Drawing.Size(319, 249);
            this.dtgSach.TabIndex = 0;
            // 
            // frmQuanlydanhsachphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(846, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanlydanhsachphieumuon";
            this.Text = "Quan ly danh sach phieu muon";
            this.Load += new System.EventHandler(this.frmQuanlydanhsachphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgaymuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btSua;
        private System.Windows.Forms.PictureBox btXoa;
        private System.Windows.Forms.NumericUpDown numNgaymuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPhieu;
        private System.Windows.Forms.PictureBox btThem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dayNgaydau;
        private System.Windows.Forms.DateTimePicker dayNgaycuoi;
        private System.Windows.Forms.Label lbNgaymuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgSach;
        private System.Windows.Forms.Button btChon;
    }
}