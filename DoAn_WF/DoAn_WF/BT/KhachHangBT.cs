using DoAn_WF.DT;
using DoAn_WF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_WF.BT
{
    class KhachHangBT
    {
        private readonly KhachHangDT khachHangDT;
        public KhachHangBT()
        {
            khachHangDT = new KhachHangDT();
        }
        internal object LayDanhSachKhachHang()
        {
            return khachHangDT.LayDanhSachKhachHang();
        }
    }
}
