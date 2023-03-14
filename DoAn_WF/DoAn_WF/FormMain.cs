using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_WF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormDangNhap>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.DangNhapThanhCong += FormDangNhap_DangNhapThanhCong;
                formDangNhap.StartPosition = FormStartPosition.CenterScreen;
                formDangNhap.ShowDialog();
            }
        }

        private void FormDangNhap_DangNhapThanhCong(string tenHienThiTaiKhoan)
        {
            CaiDatMenuChuongTrinh(true);
            statusTenTaiKhoan.Items.Add(tenHienThiTaiKhoan);
        }

        private void CaiDatMenuChuongTrinh(bool status)
        {
            menuDangNhap.Enabled = !status;
            menuChuongTrinh.Enabled = status;
            menuBaoCao.Enabled = status;
            menuDangXuat.Enabled = status;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //False: chưa đăng nhập
            //True: đã đăng nhập
            CaiDatMenuChuongTrinh(false);
        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormNhanVien>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormNhanVien frmNV = new FormNhanVien();
                frmNV.StartPosition = FormStartPosition.CenterScreen;
                frmNV.Show();
            }
        }
        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormKhachHang>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormKhachHang frmKH = new FormKhachHang();
                frmKH.StartPosition = FormStartPosition.CenterScreen;
                frmKH.Show();
            }
        }

        private void frmPhuongTien_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormPhuongTien>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormPhuongTien frmPT = new FormPhuongTien();
                frmPT.StartPosition = FormStartPosition.CenterScreen;
                frmPT.Show();
            }
        }

        private void frmDiaDiem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormDiaDiem>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormDiaDiem frmDD = new FormDiaDiem();
                frmDD.StartPosition = FormStartPosition.CenterScreen;
                frmDD.Show();
            }
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            //Đóng tất cả các cửa sổ con đang mở
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            //Xóa trạng thái tên tài khoản
            statusTenTaiKhoan.Items.Clear();
            //Chuyển về menu chưa đăng nhập
            CaiDatMenuChuongTrinh(false);
            //Mở form đăng nhập
            menuDangNhap.PerformClick();
        }
        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            Form frm = this.MdiChildren.OfType<FormBaoCaoKhachHang>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormBaoCaoKhachHang frmBaoCaoDoanhThu = new FormBaoCaoKhachHang();
                frmBaoCaoDoanhThu.StartPosition = FormStartPosition.CenterScreen;
                frmBaoCaoDoanhThu.Show();
            }
        }

        private void menuTourKH_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormBaoCaoKhachHang>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormBaoCaoKhachHang frmBaoCaoKhachHang = new FormBaoCaoKhachHang();
                frmBaoCaoKhachHang.StartPosition = FormStartPosition.CenterScreen;
                frmBaoCaoKhachHang.Show();
            }
        }

        private void menuDoanhThuTour_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormBaoCaoKhachHang>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormBaoCaoKhachHang frmBaoCaoKhachHang = new FormBaoCaoKhachHang();
                frmBaoCaoKhachHang.StartPosition = FormStartPosition.CenterScreen;
                frmBaoCaoKhachHang.Show();
            }
        }

        private void frmCTTour_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormCTTour>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormCTTour frmCTTour = new FormCTTour();
                frmCTTour.StartPosition = FormStartPosition.CenterScreen;
                frmCTTour.Show();
            }
        }

        private void menuTour_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormTour>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormTour frmTour = new FormTour();
                frmTour.StartPosition = FormStartPosition.CenterScreen;
                frmTour.Show();
            }
        }
    }
}
