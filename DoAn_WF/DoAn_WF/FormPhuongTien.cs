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
    public partial class FormPhuongTien : Form
    {
        ModelDBContext context;
        public FormPhuongTien()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }
        private void FormPhuongTien_Load(object sender, EventArgs e)
        {
            try
            {
                List<PhuongTien> listPhuongTien = context.PhuongTiens.ToList();   //Lấy các phương tiện     
                BindGrid(listPhuongTien);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            txtMaPhuongTien.Text = "";
            txtTenPhuongTien.Text = "";
        }

        private void BindGrid(List<PhuongTien> listPhuongTien)
        {
            dgvPhuongTien.Rows.Clear();
            foreach (var item in listPhuongTien)
            {
                int index = dgvPhuongTien.Rows.Add();
                dgvPhuongTien.Rows[index].Cells[0].Value = item.MaPhuongTien;
                dgvPhuongTien.Rows[index].Cells[1].Value = item.TenPT;
            }
        }
        private void dgvPhuongTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPhuongTien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvPhuongTien.CurrentRow.Selected = true;
                    txtMaPhuongTien.Text = dgvPhuongTien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenPhuongTien.Text = dgvPhuongTien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemPT_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaPhuongTien.Text) == -1 && GetSelectedRowTenPT(txtTenPhuongTien.Text) == -1)
                {

                    PhuongTien phuongTien = new PhuongTien()
                    {
                        MaPhuongTien = txtMaPhuongTien.Text,
                        TenPT = txtTenPhuongTien.Text
                    };
                    context.PhuongTiens.Add(phuongTien);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Mã và tên phương tiện đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private int GetSelectedRowTenPT(string tenPT)
        {
            for (int i = 0; i < dgvPhuongTien.Rows.Count; i++)
            {
                if (dgvPhuongTien.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvPhuongTien.Rows[i].Cells[1].Value.ToString() == tenPT)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void reloadDGV()
        {
            List<PhuongTien> listPT = context.PhuongTiens.ToList();   //Lấy phương tiện
            BindGrid(listPT);
        }

        private int GetSelectedRow(string maPT)
        {
            for (int i = 0; i < dgvPhuongTien.Rows.Count; i++)
            {
                if (dgvPhuongTien.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvPhuongTien.Rows[i].Cells[0].Value.ToString() == maPT)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool CheckValidate()
        {
            if (txtMaPhuongTien.Text == "" || txtTenPhuongTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnSuaPT_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                PhuongTien dbUpdate = context.PhuongTiens.FirstOrDefault(p => p.MaPhuongTien == txtMaPhuongTien.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.MaPhuongTien = txtMaPhuongTien.Text;
                    dbUpdate.TenPT = txtTenPhuongTien.Text;
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Phương Tiện đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            PhuongTien dbDelete = context.PhuongTiens.FirstOrDefault(p => p.MaPhuongTien == txtMaPhuongTien.Text);

            if (dbDelete != null)
            {
                context.PhuongTiens.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Xóa phương tiện thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy phương tiện cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuyBoPT_Click(object sender, EventArgs e)
        {
            txtMaPhuongTien.Text = "";
            txtTenPhuongTien.Text = "";
        }
    }
}
