using DoAn_WF.DTO;
using DoAn_WF.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_WF.DT
{
    class KhachHangDT
    {
        internal List<KhachHangDTO> LayDanhSachKhachHang()
        {
            using (var dbConText = new ModelDBContext())
            {
                return (from kh in dbConText.KhachHangs
                        select new KhachHangDTO()
                        {
                            MaKH = kh.MaKH,
                            TenKH = kh.TenKH,
                            SDT = kh.SDT,
                            NamSinh = kh.NamSinh,
                            DiaChi = kh.DiaChi,
                            CMND = kh.CMND
                        }).ToList();
            }
        }
    }
}
