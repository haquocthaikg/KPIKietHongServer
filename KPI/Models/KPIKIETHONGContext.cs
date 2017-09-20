using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KPI.Models
{
    public partial class KPIKIETHONGContext : DbContext
    {
        public virtual DbSet<Tblchinhanh> Tblchinhanh { get; set; }
        public virtual DbSet<Tblcontroller> Tblcontroller { get; set; }
        public virtual DbSet<Tbldanhgia> Tbldanhgia { get; set; }
        public virtual DbSet<Tbldapan> Tbldapan { get; set; }
        public virtual DbSet<Tblloaitieuchi> Tblloaitieuchi { get; set; }
        public virtual DbSet<Tblnhanvien> Tblnhanvien { get; set; }
        public virtual DbSet<Tblnhomtieuchi> Tblnhomtieuchi { get; set; }
        public virtual DbSet<Tblquanlychinhanh> Tblquanlychinhanh { get; set; }
        public virtual DbSet<Tblquyencontroller> Tblquyencontroller { get; set; }
        public virtual DbSet<Tblquyenuser> Tblquyenuser { get; set; }
        public virtual DbSet<Tbltieuchi> Tbltieuchi { get; set; }
        public virtual DbSet<Tbltonkholoi> Tbltonkholoi { get; set; }

        public KPIKIETHONGContext(DbContextOptions<KPIKIETHONGContext> options)
                    : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblchinhanh>(entity =>
            {
                entity.HasKey(e => e.Idchinhanh);

                entity.ToTable("tblchinhanh");

                entity.Property(e => e.Idchinhanh).HasColumnName("idchinhanh");

                entity.Property(e => e.Machinhanh)
                    .HasColumnName("machinhanh")
                    .HasMaxLength(10);

                entity.Property(e => e.Tenchinhanh)
                    .HasColumnName("tenchinhanh")
                    .HasMaxLength(150);

                entity.Property(e => e.Tragnthaicn).HasColumnName("tragnthaicn");
            });

            modelBuilder.Entity<Tblcontroller>(entity =>
            {
                entity.HasKey(e => e.Idcontroller);

                entity.ToTable("tblcontroller");

                entity.Property(e => e.Idcontroller)
                    .HasColumnName("idcontroller")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Chucnang)
                    .HasColumnName("chucnang")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Tbldanhgia>(entity =>
            {
                entity.HasKey(e => e.Iddanhgia);

                entity.ToTable("tbldanhgia");

                entity.Property(e => e.Iddanhgia).HasColumnName("iddanhgia");

                entity.Property(e => e.Diemdanhgia).HasColumnName("diemdanhgia");

                entity.Property(e => e.Ghichu)
                    .HasColumnName("ghichu")
                    .HasMaxLength(20);

                entity.Property(e => e.Iddapan).HasColumnName("iddapan");

                entity.Property(e => e.Idtieuchi).HasColumnName("idtieuchi");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Ngaydanhgia)
                    .HasColumnName("ngaydanhgia")
                    .HasColumnType("date");

                entity.Property(e => e.Noidungdanhgia)
                    .HasColumnName("noidungdanhgia")
                    .HasMaxLength(500);

                entity.Property(e => e.Trangthaidanhgia).HasColumnName("trangthaidanhgia");

                entity.HasOne(d => d.IdtieuchiNavigation)
                    .WithMany(p => p.Tbldanhgia)
                    .HasForeignKey(d => d.Idtieuchi)
                    .HasConstraintName("FK_tbldanhgia_tbltieuchi");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Tbldanhgia)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("FK_tbldanhgia_tblnhanvien");
            });

            modelBuilder.Entity<Tbldapan>(entity =>
            {
                entity.HasKey(e => e.Iddapan);

                entity.ToTable("tbldapan");

                entity.Property(e => e.Iddapan).HasColumnName("iddapan");

                entity.Property(e => e.Diemdapan).HasColumnName("diemdapan");

                entity.Property(e => e.Idtieuchi).HasColumnName("idtieuchi");

                entity.Property(e => e.Tendapan)
                    .HasColumnName("tendapan")
                    .HasMaxLength(150);

                entity.Property(e => e.Trangthaidapan).HasColumnName("trangthaidapan");

                entity.HasOne(d => d.IdtieuchiNavigation)
                    .WithMany(p => p.Tbldapan)
                    .HasForeignKey(d => d.Idtieuchi)
                    .HasConstraintName("FK_tbldapan_tbltieuchi");
            });

            modelBuilder.Entity<Tblloaitieuchi>(entity =>
            {
                entity.HasKey(e => e.Idloaitc);

                entity.ToTable("tblloaitieuchi");

                entity.Property(e => e.Idloaitc).HasColumnName("idloaitc");

                entity.Property(e => e.Tenloaitc)
                    .HasColumnName("tenloaitc")
                    .HasMaxLength(50);

                entity.Property(e => e.Trangthaitc).HasColumnName("trangthaitc");
            });

            modelBuilder.Entity<Tblnhanvien>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.ToTable("tblnhanvien");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(400);

                entity.Property(e => e.Giatrixacthuc)
                    .HasColumnName("giatrixacthuc")
                    .HasMaxLength(5);

                entity.Property(e => e.Idchinhanh).HasColumnName("idchinhanh");

                entity.Property(e => e.Isadmin).HasColumnName("isadmin");

                entity.Property(e => e.Keychung).HasColumnName("keychung");

                entity.Property(e => e.Keyrieng).HasColumnName("keyrieng");

                entity.Property(e => e.Khoa).HasColumnName("khoa");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(400);

                entity.Property(e => e.Secrect).HasColumnName("secrect");

                entity.Property(e => e.Sodienthoai)
                    .HasColumnName("sodienthoai")
                    .HasMaxLength(11);

                entity.Property(e => e.Tennhanvien)
                    .HasColumnName("tennhanvien")
                    .HasMaxLength(50);

                entity.Property(e => e.Tolken).HasColumnName("tolken");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdchinhanhNavigation)
                    .WithMany(p => p.Tblnhanvien)
                    .HasForeignKey(d => d.Idchinhanh)
                    .HasConstraintName("FK_tblnhanvien_ToTable");
            });

            modelBuilder.Entity<Tblnhomtieuchi>(entity =>
            {
                entity.HasKey(e => e.Idnhomtieuchi);

                entity.ToTable("tblnhomtieuchi");

                entity.Property(e => e.Idnhomtieuchi).HasColumnName("idnhomtieuchi");

                entity.Property(e => e.Tennhomtieuchi)
                    .HasColumnName("tennhomtieuchi")
                    .HasMaxLength(450);

                entity.Property(e => e.Trangthaintc).HasColumnName("trangthaintc");
            });

            modelBuilder.Entity<Tblquanlychinhanh>(entity =>
            {
                entity.HasKey(e => new { e.Iduser, e.Idchinhanh });

                entity.ToTable("tblquanlychinhanh");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Idchinhanh).HasColumnName("idchinhanh");

                entity.Property(e => e.Trangthaiquanly).HasColumnName("trangtraiquanly");

                entity.HasOne(d => d.IdchinhanhNavigation)
                    .WithMany(p => p.Tblquanlychinhanh)
                    .HasForeignKey(d => d.Idchinhanh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblquanlychinhanh_tblchinhanh");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Tblquanlychinhanh)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblquanlychinhanh_tblnhanvien");
            });

            modelBuilder.Entity<Tblquyencontroller>(entity =>
            {
                entity.HasKey(e => e.Idquyen);

                entity.ToTable("tblquyencontroller");

                entity.Property(e => e.Idquyen)
                    .HasColumnName("idquyen")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idcontroller)
                    .HasColumnName("idcontroller")
                    .HasMaxLength(50);

                entity.Property(e => e.Motaquyen)
                    .HasColumnName("motaquyen")
                    .HasMaxLength(250);

                entity.Property(e => e.Tenquyen)
                    .HasColumnName("tenquyen")
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdcontrollerNavigation)
                    .WithMany(p => p.Tblquyencontroller)
                    .HasForeignKey(d => d.Idcontroller)
                    .HasConstraintName("FK_tblquyencontroller_tblcontroller");
            });

            modelBuilder.Entity<Tblquyenuser>(entity =>
            {
                entity.HasKey(e => new { e.Idquyen, e.Iduser });

                entity.ToTable("tblquyenuser");

                entity.Property(e => e.Idquyen).HasColumnName("idquyen");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.HasOne(d => d.IdquyenNavigation)
                    .WithMany(p => p.Tblquyenuser)
                    .HasForeignKey(d => d.Idquyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblquyenuser_tblquyencontroller");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Tblquyenuser)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblquyenuser_tblnhanvien");
            });

            modelBuilder.Entity<Tbltieuchi>(entity =>
            {
                entity.HasKey(e => e.Idtieuchi);

                entity.ToTable("tbltieuchi");

                entity.Property(e => e.Idtieuchi)
                    .HasColumnName("idtieuchi")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Diemtieuchi).HasColumnName("diemtieuchi");

                entity.Property(e => e.Idchinhanh).HasColumnName("idchinhanh");

                entity.Property(e => e.Idloaitc).HasColumnName("idloaitc");

                entity.Property(e => e.Idnhomtieuchi).HasColumnName("idnhomtieuchi");

                entity.Property(e => e.Matieuchi)
                    .HasColumnName("matieuchi")
                    .HasMaxLength(10);

                entity.Property(e => e.Tentieuchi)
                    .HasColumnName("tentieuchi")
                    .HasColumnType("ntext");

                entity.Property(e => e.Trangthaitc).HasColumnName("trangthaitc");

                entity.HasOne(d => d.IdchinhanhNavigation)
                    .WithMany(p => p.Tbltieuchi)
                    .HasForeignKey(d => d.Idchinhanh)
                    .HasConstraintName("FK_tbltieuchi_tblchinhanh");

                entity.HasOne(d => d.IdloaitcNavigation)
                    .WithMany(p => p.Tbltieuchi)
                    .HasForeignKey(d => d.Idloaitc)
                    .HasConstraintName("FK_tbltieuchi_tblloaitc");

                entity.HasOne(d => d.IdnhomtieuchiNavigation)
                    .WithMany(p => p.Tbltieuchi)
                    .HasForeignKey(d => d.Idnhomtieuchi)
                    .HasConstraintName("FK_tbltieuchi_tblnhomtieuchi");

                entity.HasOne(d => d.IdtieuchiNavigation)
                    .WithOne(p => p.InverseIdtieuchiNavigation)
                    .HasForeignKey<Tbltieuchi>(d => d.Idtieuchi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbltieuchi_tbltieuchi");
            });

            modelBuilder.Entity<Tbltonkholoi>(entity =>
            {
                entity.HasKey(e => e.Idtonkholoi);

                entity.ToTable("tbltonkholoi");

                entity.Property(e => e.Idtonkholoi).HasColumnName("idtonkholoi");

                entity.Property(e => e.Daxuly).HasColumnName("daxuly");

                entity.Property(e => e.Decen).HasColumnName("decen");

                entity.Property(e => e.Idtieuchi).HasColumnName("idtieuchi");

                entity.Property(e => e.Ngaychamdiem)
                    .HasColumnName("ngaychamdiem")
                    .HasColumnType("date");
            });
        }
    }
}
