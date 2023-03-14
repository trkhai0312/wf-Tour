using DoAn_WF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_WF.ModelDB;

namespace DoAn_WF.DT
{
    class ChiTietTourDT
    {
        internal static List<ChiTietTourDTO> LayDanhSachTourTheoKhachHang(string maKH)
        {
            using (var dbcontext = new ModelDBContext())
            {
                return (from t in dbcontext.ChiTietTours
                        where t.MaKH == maKH
                        select new ChiTietTourDTO()
                        {
                            MaCTTour = t.MaCTTour,
                            MaTour = t.Tour.TenTour,
                            GiaTour = t.GiaTour,
                            MaKH = t.KhachHang.TenKH,
                            MaPhuongTien = t.PhuongTien.TenPT,
                            MaDiaDiem = t.DiaDiem.TenDD
                        }).ToList();
            }
        }
    }
}
