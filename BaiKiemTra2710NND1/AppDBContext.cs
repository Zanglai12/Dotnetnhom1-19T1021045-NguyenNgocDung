using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2710NND1
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }
        public virtual DbSet<TenGoi> TenGois { get; set; }
        public virtual DbSet<Nhom> Nhoms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.TenGois)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);
        }
    }
}
