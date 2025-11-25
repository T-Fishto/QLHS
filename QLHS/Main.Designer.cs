namespace QLHS
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanLop = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhSachHS = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệToolStripMenuItem
            // 
            this.hệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.mnuThoat});
            this.hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            this.hệToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.hệToolStripMenuItem.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Image = global::QLHS.Properties.Resources.login_16;
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(224, 34);
            this.mnuDangNhap.Text = "Đăng &nhập...";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = global::QLHS.Properties.Resources.logout_16;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(224, 34);
            this.mnuDangXuat.Text = "Đăng &xuất";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QLHS.Properties.Resources.exit_32;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(224, 34);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLopHoc,
            this.mnuQueQuan,
            this.mnuHocSinh,
            this.mnuPhanLop});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.quảnLýToolStripMenuItem.Text = "&Quản lý";
            // 
            // mnuLopHoc
            // 
            this.mnuLopHoc.Image = global::QLHS.Properties.Resources.block_32;
            this.mnuLopHoc.Name = "mnuLopHoc";
            this.mnuLopHoc.Size = new System.Drawing.Size(204, 34);
            this.mnuLopHoc.Text = "&Lớp học...";
            this.mnuLopHoc.Click += new System.EventHandler(this.lớphọcToolStripMenuItem_Click);
            // 
            // mnuQueQuan
            // 
            this.mnuQueQuan.Image = global::QLHS.Properties.Resources.blocks_1_32;
            this.mnuQueQuan.Name = "mnuQueQuan";
            this.mnuQueQuan.Size = new System.Drawing.Size(204, 34);
            this.mnuQueQuan.Text = "&Quê quán...";
            this.mnuQueQuan.Click += new System.EventHandler(this.mnuQueQuan_Click);
            // 
            // mnuHocSinh
            // 
            this.mnuHocSinh.Image = global::QLHS.Properties.Resources.users_1_32;
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(204, 34);
            this.mnuHocSinh.Text = "&Học sinh...";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);
            // 
            // mnuPhanLop
            // 
            this.mnuPhanLop.Image = global::QLHS.Properties.Resources.home_32;
            this.mnuPhanLop.Name = "mnuPhanLop";
            this.mnuPhanLop.Size = new System.Drawing.Size(204, 34);
            this.mnuPhanLop.Text = "&Phân lớp...";
            this.mnuPhanLop.Click += new System.EventHandler(this.mnuPhanLop_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhSachHS});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.báoCáoThốngKêToolStripMenuItem.Text = "&Báo Cáo-Thống kê";
            // 
            // mnuDanhSachHS
            // 
            this.mnuDanhSachHS.Image = global::QLHS.Properties.Resources.pie_2_32;
            this.mnuDanhSachHS.Name = "mnuDanhSachHS";
            this.mnuDanhSachHS.Size = new System.Drawing.Size(279, 34);
            this.mnuDanhSachHS.Text = "&Danh sách học sinh...";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDanSuDung,
            this.toolStripSeparator2,
            this.mnuThongTinPhanMem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.trợGiúpToolStripMenuItem.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            this.mnuHuongDanSuDung.Image = global::QLHS.Properties.Resources.edit_16;
            this.mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            this.mnuHuongDanSuDung.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHuongDanSuDung.Size = new System.Drawing.Size(363, 34);
            this.mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(360, 6);
            // 
            // mnuThongTinPhanMem
            // 
            this.mnuThongTinPhanMem.Image = global::QLHS.Properties.Resources.view_16;
            this.mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            this.mnuThongTinPhanMem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mnuThongTinPhanMem.Size = new System.Drawing.Size(363, 34);
            this.mnuThongTinPhanMem.Text = "Thông tin &phần mềm...";
            this.mnuThongTinPhanMem.Click += new System.EventHandler(this.mnuThongTinPhanMem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 25);
            this.toolStripStatusLabel1.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(336, 25);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(192, 25);
            this.toolStripStatusLabel3.Text = "http://regis.agu.edu.vn";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuQueQuan;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanLop;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhSachHS;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDanSuDung;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinPhanMem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}