namespace DoAn_WF.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(200)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        public int NamSinh { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChucVu { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
