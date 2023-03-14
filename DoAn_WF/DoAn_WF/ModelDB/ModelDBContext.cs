using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_WF.ModelDB
{
    public partial class ModelDBContext : DbContext
    {
        public ModelDBContext()
            : base("name=ModelDBContext2")
        {
        }

        public virtual DbSet<ChiTietTour> ChiTietTours { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhuongTien> PhuongTiens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietTour>()
                .Property(e => e.MaCTTour)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTour>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTour>()
                .Property(e => e.MaPhuongTien)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTour>()
                .Property(e => e.MaDiaDiem)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTour>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaDiem>()
                .Property(e => e.MaDiaDiem)
                .IsUnicode(false);

            modelBuilder.Entity<DiaDiem>()
                .HasMany(e => e.ChiTietTours)
                .WithRequired(e => e.DiaDiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.ChiTietTours)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<PhuongTien>()
                .Property(e => e.MaPhuongTien)
                .IsUnicode(false);

            modelBuilder.Entity<PhuongTien>()
                .HasMany(e => e.ChiTietTours)
                .WithRequired(e => e.PhuongTien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.ChiTietTours)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
