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
    public partial class FormTour : Form
    {
        ModelDBContext context;
        public FormTour()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            try
            {
                List<Tour> listTour = context.Tours.ToList();   
                BindGrid(listTour);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            txtMaTour.Text = "";
            txtTenTour.Text = "";
        }

        private void BindGrid(List<Tour> listTour)
        {
            dgvTour.Rows.Clear();
            foreach (var item in listTour)
            {
                int index = dgvTour.Rows.Add();
                dgvTour.Rows[index].Cells[0].Value = item.MaTour;
                dgvTour.Rows[index].Cells[1].Value = item.TenTour;
            }
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTour.CurrentRow.Selected = true;
                    txtMaTour.Text = dgvTour.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenTour.Text = dgvTour.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaTour.Text) == -1)
                {

                    Tour t = new Tour()
                    {
                        MaTour = txtMaTour.Text,
                        TenTour = txtTenTour.Text,

                    };
                    context.Tours.Add(t);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tour đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadDGV()
        {
            List<Tour> listTour = context.Tours.ToList();   
            BindGrid(listTour);
        }

        private int GetSelectedRow(string maTour)
        {
            for (int i = 0; i < dgvTour.Rows.Count; i++)
            {
                if (dgvTour.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvTour.Rows[i].Cells[0].Value.ToString() == maTour)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool CheckValidate()
        {
            if (txtMaTour.Text == "" || txtTenTour.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                Tour dbUpdate = context.Tours.FirstOrDefault(p => p.MaTour == txtMaTour.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.MaTour = txtMaTour.Text;
                    dbUpdate.TenTour = txtTenTour.Text;
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tour đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            Tour dbDelete = context.Tours.FirstOrDefault(p => p.MaTour == txtMaTour.Text);

            if (dbDelete != null)
            {
                context.Tours.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Xóa Tour thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Tour cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuyBoTour_Click(object sender, EventArgs e)
        {
            txtMaTour.Text = "";
            txtTenTour.Text = "";
        }
    }
}
