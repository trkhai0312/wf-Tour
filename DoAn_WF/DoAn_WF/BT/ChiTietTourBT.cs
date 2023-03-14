using DoAn_WF.DT;
using DoAn_WF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_WF.BT
{
    class ChiTietTourBT
    {
        private readonly ChiTietTourDT tourDT;
        public ChiTietTourBT()
        {
            tourDT = new ChiTietTourDT();
        }
        internal static List<ChiTietTourDTO> LayDanhSachTourTheoKhachHang(string maKH)
        {
            return ChiTietTourDT.LayDanhSachTourTheoKhachHang(maKH);
        }
    }
}
