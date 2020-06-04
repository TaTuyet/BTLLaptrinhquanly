namespace BaiTapLonLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietBan",
                c => new
                    {
                        SoHDBan = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaHangHoa = c.String(nullable: false, maxLength: 10, unicode: false),
                        DonGia = c.String(nullable: false, maxLength: 20, unicode: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SoHDBan, t.MaHangHoa })
                .ForeignKey("dbo.HangHoa", t => t.MaHangHoa)
                .ForeignKey("dbo.HDBan", t => t.SoHDBan)
                .Index(t => t.SoHDBan)
                .Index(t => t.MaHangHoa);
            
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        MaHangHoa = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenHangHoa = c.String(nullable: false, maxLength: 50, unicode: false),
                        DonViTinh = c.String(nullable: false, maxLength: 15, unicode: false),
                        MoTa = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaHangHoa);
            
            CreateTable(
                "dbo.ChiTietMua",
                c => new
                    {
                        SoHDMua = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaHangHoa = c.String(nullable: false, maxLength: 10, unicode: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => new { t.SoHDMua, t.MaHangHoa })
                .ForeignKey("dbo.HDMua", t => t.SoHDMua)
                .ForeignKey("dbo.HangHoa", t => t.MaHangHoa)
                .Index(t => t.SoHDMua)
                .Index(t => t.MaHangHoa);
            
            CreateTable(
                "dbo.HDMua",
                c => new
                    {
                        SoHDMua = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayMua = c.DateTime(nullable: false),
                        MaNCC = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.SoHDMua)
                .ForeignKey("dbo.NhaCungCap", t => t.MaNCC)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .Index(t => t.MaNCC)
                .Index(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenNCC = c.String(nullable: false, maxLength: 50, unicode: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 15, unicode: false),
                        DiaChi = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        DiaChi = c.String(nullable: false, maxLength: 50, unicode: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.HDBan",
                c => new
                    {
                        SoHDBan = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaKhachHang = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        NgayBan = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SoHDBan)
                .ForeignKey("dbo.KhachHang", t => t.MaKhachHang)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .Index(t => t.MaKhachHang)
                .Index(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenKhachHang = c.String(nullable: false, maxLength: 15, unicode: false),
                        DiaChi = c.String(nullable: false, maxLength: 50, unicode: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.LoaiHangHoa",
                c => new
                    {
                        MaLoaiHangHoa = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenLoaiHangHoa = c.String(nullable: false, maxLength: 50, unicode: false),
                        GhiChu = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.MaLoaiHangHoa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietMua", "MaHangHoa", "dbo.HangHoa");
            DropForeignKey("dbo.HDMua", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.HDBan", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.HDBan", "MaKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.ChiTietBan", "SoHDBan", "dbo.HDBan");
            DropForeignKey("dbo.HDMua", "MaNCC", "dbo.NhaCungCap");
            DropForeignKey("dbo.ChiTietMua", "SoHDMua", "dbo.HDMua");
            DropForeignKey("dbo.ChiTietBan", "MaHangHoa", "dbo.HangHoa");
            DropIndex("dbo.HDBan", new[] { "MaNhanVien" });
            DropIndex("dbo.HDBan", new[] { "MaKhachHang" });
            DropIndex("dbo.HDMua", new[] { "MaNhanVien" });
            DropIndex("dbo.HDMua", new[] { "MaNCC" });
            DropIndex("dbo.ChiTietMua", new[] { "MaHangHoa" });
            DropIndex("dbo.ChiTietMua", new[] { "SoHDMua" });
            DropIndex("dbo.ChiTietBan", new[] { "MaHangHoa" });
            DropIndex("dbo.ChiTietBan", new[] { "SoHDBan" });
            DropTable("dbo.LoaiHangHoa");
            DropTable("dbo.KhachHang");
            DropTable("dbo.HDBan");
            DropTable("dbo.NhanVien");
            DropTable("dbo.NhaCungCap");
            DropTable("dbo.HDMua");
            DropTable("dbo.ChiTietMua");
            DropTable("dbo.HangHoa");
            DropTable("dbo.ChiTietBan");
        }
    }
}
