using DoAn_WF.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_WF.DT
{
    class TaiKhoanDT
    {
        public TaiKhoan LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            using (var dbContext = new ModelDBContext())
            {
                return dbContext.TaiKhoans.Where(s => s.TenDangNhap == tenDangNhap && s.MatKhau == matKhau).FirstOrDefault();
            }
        }
    }
}
