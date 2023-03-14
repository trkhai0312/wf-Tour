using DoAn_WF.BT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_WF.ModelDB;
using DoAn_WF.DTO;
using Microsoft.Reporting.WinForms;

namespace DoAn_WF
{
    public partial class FormBaoCaoKhachHang : Form
    {
        private ChiTietTourBT tourBT;
        private KhachHangBT khachHangBT;
        public FormBaoCaoKhachHang()
        {
            InitializeComponent();
            tourBT = new ChiTietTourBT();
            khachHangBT = new KhachHangBT();
            cmbKH.ValueMember = "MaKH";
            cmbKH.DisplayMember = "TenKH";
        }

        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            cmbKH.DataSource = khachHangBT.LayDanhSachKhachHang();

            this.reportViewer1.RefreshReport();
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKH = cmbKH.SelectedValue.ToString();
            List<ChiTietTourDTO> danhSachTourTheoKhachHang = ChiTietTourBT.LayDanhSachTourTheoKhachHang(maKH);
            //Cài đặt report để hiển thị dữ liệu
            this.reportViewer1.LocalReport.ReportPath = @"D:\DoAn_LTW\DoAn_WF\DoAn_WF\Reporting\ReportBaoCaoKhachHang.rdlc";
            var reportDataSource = new ReportDataSource("ChiTietTourDataSet", danhSachTourTheoKhachHang);
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
