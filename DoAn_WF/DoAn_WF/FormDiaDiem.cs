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
    public partial class FormDiaDiem : Form
    {
        ModelDBContext context;
        public FormDiaDiem()
        {
            InitializeComponent();
            context = new ModelDBContext();
        }      
        private void FormDiaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                List<DiaDiem> listDiaDiem = context.DiaDiems.ToList();   //Lấy các phương tiện     
                BindGrid(listDiaDiem);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<DiaDiem> listDiaDiem)
        {
            dgvDiaDiem.Rows.Clear();
            foreach (var item in listDiaDiem)
            {
                int index = dgvDiaDiem.Rows.Add();
                dgvDiaDiem.Rows[index].Cells[0].Value = item.MaDiaDiem;
                dgvDiaDiem.Rows[index].Cells[1].Value = item.TenDD;
            }
        }

        private void refresh()
        {
            txtMaDiaDiem.Text = "";
            txtTenDiaDiem.Text = "";
        }
        private void dgvDiaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDiaDiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDiaDiem.CurrentRow.Selected = true;
                    txtMaDiaDiem.Text = dgvDiaDiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenDiaDiem.Text = dgvDiaDiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (GetSelectedRow(txtMaDiaDiem.Text) == -1)
                {

                    DiaDiem diaDiem = new DiaDiem()
                    {
                        MaDiaDiem = txtMaDiaDiem.Text,
                        TenDD = txtTenDiaDiem.Text,
                        
                    };
                    context.DiaDiems.Add(diaDiem);
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Địa điểm đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void reloadDGV()
        {
            List<DiaDiem> listDD = context.DiaDiems.ToList();   
            BindGrid(listDD);
        }

        private int GetSelectedRow(string maDD)
        {
            for (int i = 0; i < dgvDiaDiem.Rows.Count; i++)
            {
                if (dgvDiaDiem.Rows[i].Cells[0].Value != null) //them dong nay de check null dgv
                {
                    if (dgvDiaDiem.Rows[i].Cells[0].Value.ToString() == maDD)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool CheckValidate()
        {
            if (txtMaDiaDiem.Text == "" || txtTenDiaDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnSuaDD_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                DiaDiem dbUpdate = context.DiaDiems.FirstOrDefault(p => p.MaDiaDiem == txtMaDiaDiem.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.MaDiaDiem = txtMaDiaDiem.Text;
                    dbUpdate.TenDD = txtTenDiaDiem.Text;
                    context.SaveChanges();
                    reloadDGV();
                    refresh();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Địa điểm đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            DiaDiem dbDelete = context.DiaDiems.FirstOrDefault(p => p.MaDiaDiem == txtMaDiaDiem.Text);

            if (dbDelete != null)
            {
                context.DiaDiems.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Xóa địa điểm thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy địa điểm cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuyBoDD_Click(object sender, EventArgs e)
        {
            txtMaDiaDiem.Text = "";
            txtTenDiaDiem.Text = "";           
        }
    }
}
