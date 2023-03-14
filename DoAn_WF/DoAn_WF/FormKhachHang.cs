
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
    public partial class FormKhachHang : Form
    {
        ModelDBContext context;
        public FormKhachHang()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                List<KhachHang> listKhachHang = context.KhachHangs.ToList();    //Lấy khách hàng
                BindGrid(listKhachHang);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
        }


        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvQLKH.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvQLKH.Rows.Add();
                dgvQLKH.Rows[index].Cells[0].Value = item.MaKH;
                dgvQLKH.Rows[index].Cells[1].Value = item.TenKH;
                dgvQLKH.Rows[index].Cells[2].Value = item.SDT;
                dgvQLKH.Rows[index].Cells[3].Value = item.NamSinh;
                dgvQLKH.Rows[index].Cells[4].Value = item.DiaChi;
                dgvQLKH.Rows[index].Cells[5].Value = item.CMND;
            }
        }
        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLKH.CurrentRow.Selected = true;
                    txtMaKhachHang.Text = dgvQLKH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenKhachHang.Text = dgvQLKH.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtSDT.Text = dgvQLKH.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtNamSinh.Text = dgvQLKH.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtDiaChi.Text = dgvQLKH.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtCMND.Text = dgvQLKH.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSelectedRow(String maKH)
        {
            for (int i = 0; i < dgvQLKH.Rows.Count; i++)
            {
                if (dgvQLKH.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvQLKH.Rows[i].Cells[0].Value.ToString() == maKH)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void insertUpdate(int selectedRow)
        {
            dgvQLKH.Rows[selectedRow].Cells[0].Value = txtMaKhachHang.Text;
            dgvQLKH.Rows[selectedRow].Cells[1].Value = txtTenKhachHang.Text;
            dgvQLKH.Rows[selectedRow].Cells[2].Value = txtSDT.Text;
            dgvQLKH.Rows[selectedRow].Cells[3].Value = int.Parse(txtNamSinh.Text).ToString();
            dgvQLKH.Rows[selectedRow].Cells[4].Value = txtDiaChi.Text;
            dgvQLKH.Rows[selectedRow].Cells[5].Value = txtCMND.Text;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaKhachHang.Text) == -1)
                {

                    KhachHang kh = new KhachHang()
                    {
                        MaKH = txtMaKhachHang.Text,
                        TenKH = txtTenKhachHang.Text,
                        SDT = txtSDT.Text,
                        NamSinh = int.Parse(txtNamSinh.Text.ToString()),
                        DiaChi = txtDiaChi.Text,
                        CMND = txtCMND.Text,
                        //MaTour = cmbTour.SelectedValue.ToString()
                    };
                    context.KhachHangs.Add(kh);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadDGV()
        {
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();   //Lấy khách hàng
            BindGrid(listKhachHang);
        }
        private bool CheckValidate()
        {
            if (txtMaKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtSDT.Text == "" || txtNamSinh.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (txtCMND.TextLength != 9)
            {
                MessageBox.Show("Số điện thoại phải đủ 9 số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {         
            KhachHang dbDelete = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKhachHang.Text);
          
            if (dbDelete != null)
            {
                context.KhachHangs.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                KhachHang dbUpdate = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKhachHang.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.TenKH = txtTenKhachHang.Text;
                    dbUpdate.SDT = txtSDT.Text;
                    dbUpdate.NamSinh = int.Parse(txtNamSinh.Text);
                    dbUpdate.DiaChi = txtDiaChi.Text;
                    dbUpdate.CMND = txtCMND.Text;
                    //dbUpdate.MaTour = cmbTour.SelectedValue.ToString();
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtNamSinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
        }
    }
}
