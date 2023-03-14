namespace DoAn_WF.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietTour")]
    public partial class ChiTietTour
    {
        [Key]
        [StringLength(10)]
        public string MaCTTour { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTour { get; set; }

        public int GiaTour { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhuongTien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDiaDiem { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        public virtual DiaDiem DiaDiem { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual PhuongTien PhuongTien { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
