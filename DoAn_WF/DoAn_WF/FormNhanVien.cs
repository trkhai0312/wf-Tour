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
    public partial class FormNhanVien : Form
    {
        ModelDBContext context;
        public FormNhanVien()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhanVien> listNhanVien = context.NhanViens.ToList();    //Lấy nhân viên
                List<ChucVu> listChucVu = context.ChucVus.ToList();  //Lấy các chức vụ
                FillChucVuCombobox(listChucVu);
                BindGrid(listNhanVien);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm binding list có tên hiển thị là tên chức vụ của nhân viên, giá trị là Mã chức vụ
        private void FillChucVuCombobox(List<ChucVu> listChucVu)
        {
            this.cmbChucVuNV.DataSource = listChucVu;
            this.cmbChucVuNV.ValueMember = "MaChucVu";
            this.cmbChucVuNV.DisplayMember = "TenCV";
        }
        //refresh các ô nhập dữ liệu nhan vien
        private void refresh()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            txtNamSinhNV.Text = "";
            txtDiaChiNV.Text = "";
            cmbChucVuNV.SelectedItem = null;
        }

        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dgvQLNV.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int index = dgvQLNV.Rows.Add();
                dgvQLNV.Rows[index].Cells[0].Value = item.MaNV;
                dgvQLNV.Rows[index].Cells[1].Value = item.TenNV;
                dgvQLNV.Rows[index].Cells[2].Value = item.SDT;
                dgvQLNV.Rows[index].Cells[3].Value = item.NamSinh;
                dgvQLNV.Rows[index].Cells[4].Value = item.DiaChi;
                dgvQLNV.Rows[index].Cells[5].Value = item.ChucVu.TenCV;
            }
        }
        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLNV.CurrentRow.Selected = true;
                    txtMaNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtSDTNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtNamSinhNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtDiaChiNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    cmbChucVuNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSelectedRow(string maNV)
        {
            for (int i = 0; i < dgvQLNV.Rows.Count; i++)
            {
                if (dgvQLNV.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvQLNV.Rows[i].Cells[0].Value.ToString() == maNV)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void insertUpdate(int selectedRow)
        {
            dgvQLNV.Rows[selectedRow].Cells[0].Value = txtMaNV.Text;
            dgvQLNV.Rows[selectedRow].Cells[1].Value = txtTenNV.Text;
            dgvQLNV.Rows[selectedRow].Cells[2].Value = txtSDTNV.Text;
            dgvQLNV.Rows[selectedRow].Cells[3].Value = int.Parse(txtNamSinhNV.Text).ToString();
            dgvQLNV.Rows[selectedRow].Cells[4].Value = txtDiaChiNV.Text;
            dgvQLNV.Rows[selectedRow].Cells[5].Value = cmbChucVuNV.Text;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaNV.Text) == -1)
                {

                    NhanVien nv = new NhanVien()
                    {
                        MaNV = txtMaNV.Text,
                        TenNV = txtTenNV.Text,
                        SDT = txtSDTNV.Text,
                        NamSinh = int.Parse(txtNamSinhNV.Text.ToString()),
                        DiaChi = txtDiaChiNV.Text,
                        MaChucVu = cmbChucVuNV.SelectedValue.ToString()
                    };
                    context.NhanViens.Add(nv);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nhân Viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        //Load lại thông tin trên datagridview
        private void reloadDGV()
        {
            List<NhanVien> listNhanVien = context.NhanViens.ToList();   //Lấy nhân viên
            BindGrid(listNhanVien);
        }

        private bool CheckValidate()
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "" || txtNamSinhNV.Text == "" || txtDiaChiNV.Text == "" || cmbChucVuNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (txtSDTNV.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                NhanVien dbUpdate = context.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.TenNV = txtTenNV.Text;
                    dbUpdate.SDT = txtSDTNV.Text;
                    dbUpdate.NamSinh = int.Parse(txtNamSinhNV.Text);
                    dbUpdate.DiaChi = txtDiaChiNV.Text;
                    dbUpdate.MaChucVu = cmbChucVuNV.SelectedValue.ToString();
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            NhanVien dbDelete = context.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            if (dbDelete != null)
            {
                context.NhanViens.Remove(dbDelete);
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
        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            txtNamSinhNV.Text = "";
            txtDiaChiNV.Text = "";
            cmbChucVuNV.Text = null;
        }
    }
}