namespace QuanLyThuVien
{
    partial class frmCapnhatLoaisachNgonngu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapnhatLoaisachNgonngu));
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtgDanhshach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btCapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhshach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(79, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(227, 29);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Cập nhật loại sách";
            // 
            // dtgDanhshach
            // 
            this.dtgDanhshach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhshach.Location = new System.Drawing.Point(22, 65);
            this.dtgDanhshach.Name = "dtgDanhshach";
            this.dtgDanhshach.Size = new System.Drawing.Size(407, 275);
            this.dtgDanhshach.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 46);
            this.panel1.TabIndex = 20;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Location = new System.Drawing.Point(251, 355);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(101, 30);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCapnhat.Location = new System.Drawing.Point(69, 355);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(101, 30);
            this.btCapnhat.TabIndex = 2;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // frmCapnhatLoaisachNgonngu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 397);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgDanhshach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapnhatLoaisachNgonngu";
            this.Text = "Cap nhat loai sach";
            this.Load += new System.EventHandler(this.frmCapnhatLoaisachNgonngu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhshach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dtgDanhshach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCapnhat;
    }
}