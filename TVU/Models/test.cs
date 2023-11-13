namespace TVU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class test : DbContext
    {
        public test()
            : base("name=test")
        {
        }

        public virtual DbSet<covanhoctap> covanhoctap { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.namHoc)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.maLop)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.dienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.quyetDinh)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.ghiChu)
                .IsUnicode(false);

            modelBuilder.Entity<covanhoctap>()
                .Property(e => e.noiDungDieuChinh)
                .IsUnicode(false);
        }
    }
}
