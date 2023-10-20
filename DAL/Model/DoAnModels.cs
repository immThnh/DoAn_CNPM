using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class DoAnModels : DbContext
    {
        public DoAnModels()
            : base("name=DoAnModels")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.IDHoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.MonAns)
                .WithOptional(e => e.KhuyenMai)
                .HasForeignKey(e => e.IDKhuyenMai);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.Menu)
                .HasForeignKey(e => e.IDMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.IDMonAn)
                .WillCascadeOnDelete(false);
        }
    }
}
