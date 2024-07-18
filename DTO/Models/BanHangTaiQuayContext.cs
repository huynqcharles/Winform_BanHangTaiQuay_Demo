using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DTO.Models
{
    public partial class BanHangTaiQuayContext : DbContext
    {
        public BanHangTaiQuayContext()
        {
        }

        public BanHangTaiQuayContext(DbContextOptions<BanHangTaiQuayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-THGS1N4\\SQLEXPRESS;Database=BanHangTaiQuay;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D46395333DEE53E9");

                entity.ToTable("ChucVu");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenChucVu).HasMaxLength(50);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B94E0BFDD");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.Sdtkh)
                    .HasMaxLength(15)
                    .HasColumnName("SDTKH");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK_HoaDon_NhanVien");

                entity.HasOne(d => d.SdtkhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Sdtkh)
                    .HasConstraintName("FK_HoaDon_KhachHang");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaSpct, e.MaHoaDon })
                    .HasName("PK__HoaDonCh__36E3C854A234982E");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.MaSpct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSPCT");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_HoaDon");

                entity.HasOne(d => d.MaSpctNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSpct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_SanPhamChiTiet");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Sdtkh)
                    .HasName("PK__KhachHan__DD06556408D960B6");

                entity.ToTable("KhachHang");

                entity.Property(e => e.Sdtkh)
                    .HasMaxLength(15)
                    .HasColumnName("SDTKH");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.MaKichCo)
                    .HasName("PK__KichCo__DE76ED87DFF4FC60");

                entity.ToTable("KichCo");

                entity.Property(e => e.MaKichCo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenKichCo).HasMaxLength(50);
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.MaMauSac)
                    .HasName("PK__MauSac__B9A91162BCD6D540");

                entity.ToTable("MauSac");

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenMauSac).HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA47F204EBEB");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("FK_NhanVien_ChucVu");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D6DDF6D3E");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.TenSanPham).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaSpct)
                    .HasName("PK__SanPhamC__9ED6254763E247EC");

                entity.ToTable("SanPhamChiTiet");

                entity.Property(e => e.MaSpct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaSPCT");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaKichCo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaKichCoNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaKichCo)
                    .HasConstraintName("FK_SanPhamChiTiet_KichCo");

                entity.HasOne(d => d.MaMauSacNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaMauSac)
                    .HasConstraintName("FK_SanPhamChiTiet_MauSac");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK_SanPhamChiTiet_SanPham");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
