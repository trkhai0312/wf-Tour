
using DoAn_WF.BT;
using DoAn_WF.ModelDB;
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
    public delegate void DangNhapThanhCong(string tenHienThiTaiKhoan);
    public partial class FormDangNhap : Form
    {
        private TaiKhoanBT taiKhoanBT;
        public event DangNhapThanhCong DangNhapThanhCong;
        public FormDangNhap()
        {
            InitializeComponent();
            taiKhoanBT = new TaiKhoanBT();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            TaiKhoan taiKhoan = taiKhoanBT.LayTaiKhoan(tenDangNhap, matKhau);
            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                this.Close();
                DangNhapThanhCong(taiKhoan.TenHienThi);
            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
