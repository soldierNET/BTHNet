using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiThucHanh11.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DMPHONG> DMPHONGs { get; set; }
        public virtual DbSet<DSNV> DSNVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DSNV>()
                .Property(e => e.MaNV)
                .IsUnicode(false);
        }
    }
}
