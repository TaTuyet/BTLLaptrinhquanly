namespace BaiTapLonLTQL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
           
        }
        public virtual DbSet<ChiTietBan> ChiTietBans { get; set; }
        public virtual DbSet<ChiTietMua> ChiTietMuas { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HDBan> HDBans { get; set; }
        public virtual DbSet<HDMua> HDMuas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHangHoa> LoaiHangHoas { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        
    


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietBan>()
               .Property(e => e.SoHDBan)
               .IsUnicode(false);

            modelBuilder.Entity<ChiTietBan>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBan>()
                .Property(e => e.DonGia)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietMua>()
                .Property(e => e.SoHDMua)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietMua>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietMua>()
                .Property(e => e.DonGia)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.TenHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonViTinh)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietBans)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietMuas)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HDBan>()
                .Property(e => e.SoHDBan)
                .IsUnicode(false);

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HDBan>()
                .HasMany(e => e.ChiTietBans)
                .WithRequired(e => e.HDBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HDMua>()
                .Property(e => e.SoHDMua)
                .IsUnicode(false);

            modelBuilder.Entity<HDMua>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<HDMua>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HDMua>()
                .HasMany(e => e.ChiTietMuas)
                .WithRequired(e => e.HDMua)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHangHoa>()
                .Property(e => e.MaLoaiHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiHangHoa>()
                .Property(e => e.TenLoaiHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiHangHoa>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.TenNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.HDMuas)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HDMuas)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
               .Property(e => e.Username)
               .IsUnicode(false);

            modelBuilder.Entity<Account>()
             .Property(e => e.Password)
             .IsUnicode(false);
        }
    }
}
