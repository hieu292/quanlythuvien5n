namespace QuanLyThuVien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlydocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlysach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlyphieumuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulapphieumuonsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrasach = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.phiếuMượnToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanlydocgia,
            this.mnuQuanlysach,
            this.mnuQuanlyphieumuon,
            this.mnuExit});
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.qToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuQuanlydocgia
            // 
            this.mnuQuanlydocgia.Name = "mnuQuanlydocgia";
            this.mnuQuanlydocgia.Size = new System.Drawing.Size(186, 22);
            this.mnuQuanlydocgia.Text = "Quản lý độc giả";
            this.mnuQuanlydocgia.Click += new System.EventHandler(this.quanlydocgia);
            // 
            // mnuQuanlysach
            // 
            this.mnuQuanlysach.Name = "mnuQuanlysach";
            this.mnuQuanlysach.Size = new System.Drawing.Size(186, 22);
            this.mnuQuanlysach.Text = "Quản lý sách";
            this.mnuQuanlysach.Click += new System.EventHandler(this.mnuQuanlysach_Click);
            // 
            // mnuQuanlyphieumuon
            // 
            this.mnuQuanlyphieumuon.Name = "mnuQuanlyphieumuon";
            this.mnuQuanlyphieumuon.Size = new System.Drawing.Size(186, 22);
            this.mnuQuanlyphieumuon.Text = "Quản lý phiếu mượn";
            this.mnuQuanlyphieumuon.Click += new System.EventHandler(this.mnuQuanlyphieumuon_Click_1);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(186, 22);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // phiếuMượnToolStripMenuItem
            // 
            this.phiếuMượnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnulapphieumuonsach,
            this.mnutrasach});
            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            // 
            // mnulapphieumuonsach
            // 
            this.mnulapphieumuonsach.Name = "mnulapphieumuonsach";
            this.mnulapphieumuonsach.Size = new System.Drawing.Size(191, 22);
            this.mnulapphieumuonsach.Text = "Lập phiếu mượn sách";
            this.mnulapphieumuonsach.Click += new System.EventHandler(this.mnulapphieumuonsach_Click);
            // 
            // mnutrasach
            // 
            this.mnutrasach.Name = "mnutrasach";
            this.mnutrasach.Size = new System.Drawing.Size(191, 22);
            this.mnutrasach.Text = "Trả sách";
            this.mnutrasach.Click += new System.EventHandler(this.mnutrasach_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phan mem quan ly thu vien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlydocgia;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlysach;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnulapphieumuonsach;
        private System.Windows.Forms.ToolStripMenuItem mnutrasach;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlyphieumuon;
    }
}

