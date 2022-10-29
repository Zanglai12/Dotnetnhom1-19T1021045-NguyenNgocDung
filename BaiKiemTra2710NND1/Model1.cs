using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiKiemTra2710NND1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Nhom> Nhoms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TenGoi> TenGois { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.TenGois)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);

            modelBuilder.Entity<TenGoi>()
                .Property(e => e.TenGoi1)
                .IsUnicode(false);

            modelBuilder.Entity<TenGoi>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TenGoi>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<TenGoi>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);
        }
    }
}
