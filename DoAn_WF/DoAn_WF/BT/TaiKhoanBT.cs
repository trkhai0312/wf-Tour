using DoAn_WF.DT;
using DoAn_WF.Libs;
using DoAn_WF.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_WF.BT
{
    class TaiKhoanBT
    {
        private readonly TaiKhoanDT taiKhoanDT;
        public TaiKhoanBT()
        {
            taiKhoanDT = new TaiKhoanDT();
        }
        public TaiKhoan LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            matKhau = Helpers.MaHoaMatKhauMd5(matKhau);
            return taiKhoanDT.LayTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
