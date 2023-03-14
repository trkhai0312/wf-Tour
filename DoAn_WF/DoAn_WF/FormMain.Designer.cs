
namespace DoAn_WF
{
    partial class FormMain
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
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.frmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.frmKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.frmCTTour = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPhuongTien = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDiaDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTour = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTourKH = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTenTaiKhoan = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuChuongTrinh,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHeThong.ForeColor = System.Drawing.Color.Black;
            this.menuHeThong.ImageTransparentColor = System.Drawing.Color.White;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(165, 37);
            this.menuHeThong.Text = "HỆ THỐNG";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(230, 38);
            this.menuDangNhap.Text = "Đăng Nhập";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(230, 38);
            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(230, 38);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuChuongTrinh
            // 
            this.menuChuongTrinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmNhanVien,
            this.frmKhachHang,
            this.frmCTTour,
            this.frmPhuongTien,
            this.frmDiaDiem,
            this.menuTour});
            this.menuChuongTrinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChuongTrinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuChuongTrinh.Name = "menuChuongTrinh";
            this.menuChuongTrinh.Size = new System.Drawing.Size(237, 37);
            this.menuChuongTrinh.Text = "CHƯƠNG TRÌNH";
            // 
            // frmNhanVien
            // 
            this.frmNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.frmNhanVien.Name = "frmNhanVien";
            this.frmNhanVien.Size = new System.Drawing.Size(352, 38);
            this.frmNhanVien.Text = "Quản lý nhân viên";
            this.frmNhanVien.Click += new System.EventHandler(this.frmNhanVien_Click);
            // 
            // frmKhachHang
            // 
            this.frmKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.frmKhachHang.Name = "frmKhachHang";
            this.frmKhachHang.Size = new System.Drawing.Size(352, 38);
            this.frmKhachHang.Text = "Quản lý khách hàng";
            this.frmKhachHang.Click += new System.EventHandler(this.frmKhachHang_Click);
            // 
            // frmCTTour
            // 
            this.frmCTTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.frmCTTour.Name = "frmCTTour";
            this.frmCTTour.Size = new System.Drawing.Size(352, 38);
            this.frmCTTour.Text = "Quản lý chi tiết tour";
            this.frmCTTour.Click += new System.EventHandler(this.frmCTTour_Click);
            // 
            // frmPhuongTien
            // 
            this.frmPhuongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.frmPhuongTien.Name = "frmPhuongTien";
            this.frmPhuongTien.Size = new System.Drawing.Size(352, 38);
            this.frmPhuongTien.Text = "Quản lý phương tiện";
            this.frmPhuongTien.Click += new System.EventHandler(this.frmPhuongTien_Click);
            // 
            // frmDiaDiem
            // 
            this.frmDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.frmDiaDiem.Name = "frmDiaDiem";
            this.frmDiaDiem.Size = new System.Drawing.Size(352, 38);
            this.frmDiaDiem.Text = "Quản lý địa điểm";
            this.frmDiaDiem.Click += new System.EventHandler(this.frmDiaDiem_Click);
            // 
            // menuTour
            // 
            this.menuTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuTour.Name = "menuTour";
            this.menuTour.Size = new System.Drawing.Size(352, 38);
            this.menuTour.Text = "Quản lý thông tin tour";
            this.menuTour.Click += new System.EventHandler(this.menuTour_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTourKH});
            this.menuBaoCao.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(154, 37);
            this.menuBaoCao.Text = "BÁO CÁO";
            // 
            // menuTourKH
            // 
            this.menuTourKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuTourKH.Name = "menuTourKH";
            this.menuTourKH.Size = new System.Drawing.Size(298, 38);
            this.menuTourKH.Text = "Tour Khách Hàng";
            this.menuTourKH.Click += new System.EventHandler(this.menuTourKH_Click);
            // 
            // statusTenTaiKhoan
            // 
            this.statusTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusTenTaiKhoan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusTenTaiKhoan.Location = new System.Drawing.Point(0, 484);
            this.statusTenTaiKhoan.Name = "statusTenTaiKhoan";
            this.statusTenTaiKhoan.Size = new System.Drawing.Size(896, 22);
            this.statusTenTaiKhoan.TabIndex = 1;
            this.statusTenTaiKhoan.Text = "statusStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_WF.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 506);
            this.Controls.Add(this.statusTenTaiKhoan);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem frmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem frmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem frmCTTour;
        private System.Windows.Forms.ToolStripMenuItem frmPhuongTien;
        private System.Windows.Forms.ToolStripMenuItem frmDiaDiem;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuTourKH;
        private System.Windows.Forms.StatusStrip statusTenTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuTour;
    }
}