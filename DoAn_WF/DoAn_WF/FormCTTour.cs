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
    public partial class FormCTTour : Form
    {
        ModelDBContext context;
        public FormCTTour()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }
        private void FormCTTour_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            try
            {
                List<ChiTietTour> listCTTour = context.ChiTietTours.ToList();
                List<Tour> listTour = context.Tours.ToList();    //Lấy Tour
                List<DiaDiem> listDiaDiem = context.DiaDiems.ToList();   //Lấy các địa điểm
                List<PhuongTien> listPhuongTien = context.PhuongTiens.ToList();   //Lấy các phương tiện
                List<KhachHang> listKhachHang = context.KhachHangs.ToList();   //Lấy các khách hàng   
                FillTourCombobox(listTour);
                FillDiaDiemCombobox(listDiaDiem);
                FillPhuongTienCombobox(listPhuongTien);
                FillKhachHangCombobox(listKhachHang);
                BindGrid(listCTTour);
                refresh();
                Sum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FillTourCombobox(List<Tour> listTour)
        {
            this.cmbTour.DataSource = listTour;
            this.cmbTour.ValueMember = "MaTour";
            this.cmbTour.DisplayMember = "TenTour";
        }

        private void FillKhachHangCombobox(List<KhachHang> listKhachHang)
        {
            this.cmbKhachHang.DataSource = listKhachHang;
            this.cmbKhachHang.ValueMember = "MaKH";
            this.cmbKhachHang.DisplayMember = "MaKH";
        }

        private void BindGrid(List<ChiTietTour> listCTTour)
        {
            dgvCTTour.Rows.Clear();
            foreach (var item in listCTTour)
            {
                int index = dgvCTTour.Rows.Add();
                dgvCTTour.Rows[index].Cells[0].Value = item.MaCTTour;
                dgvCTTour.Rows[index].Cells[1].Value = item.MaTour;
                dgvCTTour.Rows[index].Cells[2].Value = item.Tour.TenTour;
                dgvCTTour.Rows[index].Cells[3].Value = item.GiaTour;
                dgvCTTour.Rows[index].Cells[4].Value = item.KhachHang.MaKH;
                dgvCTTour.Rows[index].Cells[5].Value = item.KhachHang.TenKH;
                dgvCTTour.Rows[index].Cells[6].Value = item.PhuongTien.TenPT;
                dgvCTTour.Rows[index].Cells[7].Value = item.DiaDiem.TenDD;
            }
        }

        private void FillDiaDiemCombobox(List<DiaDiem> listDiaDiem)
        {
            this.cmbDiaDiem.DataSource = listDiaDiem;
            this.cmbDiaDiem.ValueMember = "MaDiaDiem";
            this.cmbDiaDiem.DisplayMember = "TenDD";
        }
        private void FillPhuongTienCombobox(List<PhuongTien> listPhuongTien)
        {
            this.cmbLoaiPT.DataSource = listPhuongTien;
            this.cmbLoaiPT.ValueMember = "MaPhuongTien";
            this.cmbLoaiPT.DisplayMember = "TenPT";
        }
        private void refresh()
        {
            txtMaCTTour.Text = "";
            cmbTour.SelectedItem = null;
            txtGiaTour.Text = "";
            cmbKhachHang.SelectedItem = null;
            cmbLoaiPT.SelectedItem = null;
            cmbDiaDiem.SelectedItem = null;
        }
        private void dgvCTTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCTTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCTTour.CurrentRow.Selected = true;
                    txtMaCTTour.Text = dgvCTTour.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cmbTour.Text = dgvCTTour.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cmbTour.Text = dgvCTTour.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtGiaTour.Text = dgvCTTour.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    cmbKhachHang.Text = dgvCTTour.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    cmbKhachHang.Text = dgvCTTour.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    cmbLoaiPT.Text = dgvCTTour.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    cmbDiaDiem.Text = dgvCTTour.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCTTour_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaCTTour.Text) == -1)
                {

                    ChiTietTour ctTour = new ChiTietTour()
                    {
                        MaCTTour = txtMaCTTour.Text,
                        MaTour = cmbTour.SelectedValue.ToString(),
                        GiaTour = int.Parse(txtGiaTour.Text.ToString()),
                        MaKH = cmbKhachHang.SelectedValue.ToString(),
                        MaPhuongTien = cmbLoaiPT.SelectedValue.ToString(),
                        MaDiaDiem = cmbDiaDiem.SelectedValue.ToString()
                    };
                    context.ChiTietTours.Add(ctTour);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    Sum();
                }
                else
                {
                    MessageBox.Show("Chi tiết Tour đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadDGV()
        {
            List<ChiTietTour> listCTTour = context.ChiTietTours.ToList();  
            BindGrid(listCTTour);
        }

        private int GetSelectedRow(string maCTTour)
        {
            for (int i = 0; i < dgvCTTour.Rows.Count; i++)
            {
                if (dgvCTTour.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvCTTour.Rows[i].Cells[0].Value.ToString() == maCTTour)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool CheckValidate()
        {
            if (txtMaCTTour.Text == "" || cmbTour.Text == "" || txtGiaTour.Text == "" || cmbKhachHang.Text == "" || cmbLoaiPT.Text == "" || cmbDiaDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (int.Parse(txtGiaTour.Text.ToString()) < 0)
            {
                MessageBox.Show("Giá tour phải lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                ChiTietTour dbUpdate = context.ChiTietTours.FirstOrDefault(p => p.MaCTTour == txtMaCTTour.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.MaTour = cmbTour.SelectedValue.ToString();
                    dbUpdate.GiaTour = int.Parse(txtGiaTour.Text);
                    dbUpdate.MaKH = cmbKhachHang.SelectedValue.ToString();
                    dbUpdate.MaPhuongTien = cmbLoaiPT.SelectedValue.ToString();
                    dbUpdate.MaDiaDiem = cmbDiaDiem.SelectedValue.ToString();
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    Sum();
                }
                else
                {
                    MessageBox.Show("Chi tiết Tour đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            ChiTietTour dbDelete = context.ChiTietTours.FirstOrDefault(p => p.MaCTTour == txtMaCTTour.Text);

            if (dbDelete != null)
            {
                context.ChiTietTours.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Xóa chi tiết tour thành công!", "Thông báo", MessageBoxButtons.OK);
                Sum();
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết tour cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnHuyTour_Click(object sender, EventArgs e)
        {
            txtMaCTTour.Text = "";
            cmbTour.Text = "";
            txtGiaTour.Text = "";
            cmbKhachHang.Text = "";
            cmbLoaiPT.Text = "";
            cmbDiaDiem.Text = "";
        }
        private void Sum()
        {
            int sumTongTien = 0;
            for (int i = 0; i < dgvCTTour.Rows.Count; i++)
            {
                if (dgvCTTour.Rows[i].Cells[0].Value != null)
                {
                    sumTongTien += int.Parse(dgvCTTour.Rows[i].Cells[3].Value.ToString());               
                }
            }
            txtTongTien.Text = sumTongTien.ToString();
        }

    }
}
