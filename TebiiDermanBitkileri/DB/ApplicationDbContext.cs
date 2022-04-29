using Microsoft.EntityFrameworkCore;
using TebiiDermanBitkileri.Entity;
using TebiiDermanBitkileri.Entity.Helpers;

namespace TebiiDermanBitkileri.DB
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Bitki> Bitkiler { get; set; }
        public DbSet<BitkiNovu> BitkiNovleri { get; set; }
        public DbSet<Simptom> Simptomlar { get; set; }
        public DbSet<Vitamin> Vitaminler { get; set; }
        public DbSet<Xestelik> Xestelikler { get; set; }
        public DbSet<BitkiVitamin> BitkiVitamin { get; set; }
        public DbSet<BitkiXestelik> BitkiXestelik { get; set; }
        public DbSet<XestelikSimptom> XestelikSimptom { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitki>().HasOne(b => b.BitkiNovu).WithMany(b => b.Bitkiler).HasForeignKey(b => b.BitkiNovuId);
            modelBuilder.Entity<BitkiNovu>().HasMany(b => b.Bitkiler).WithOne(b => b.BitkiNovu).HasForeignKey(b => b.BitkiNovuId);

            modelBuilder.Entity<BitkiVitamin>().HasKey(i => new { i.BitkiId, i.VitaminId });
            modelBuilder.Entity<BitkiVitamin>().HasOne(i => i.Vitamin).WithMany(i => i.BitkiVitamin).HasForeignKey(i => i.VitaminId);
            modelBuilder.Entity<BitkiVitamin>().HasOne(i => i.Bitki).WithMany(i => i.BitkiVitamin).HasForeignKey(i => i.BitkiId);

            modelBuilder.Entity<BitkiXestelik>().HasKey(i => new { i.BitkiId, i.XestelikId });
            modelBuilder.Entity<BitkiXestelik>().HasOne(i=>i.Bitki).WithMany(i=>i.BitkiXestelik).HasForeignKey(i=>i.BitkiId);
            modelBuilder.Entity<BitkiXestelik>().HasOne(i => i.Xestelik).WithMany(i => i.BitkiXestelik).HasForeignKey(i => i.XestelikId);

            modelBuilder.Entity<XestelikSimptom>().HasKey(i=> new {i.XestelikId, i.SimptomId});
            modelBuilder.Entity<XestelikSimptom>().HasOne(i => i.Xestelik).WithMany(i => i.XestelikSimptom).HasForeignKey(i => i.XestelikId);
            modelBuilder.Entity<XestelikSimptom>().HasOne(i => i.Simptom).WithMany(i => i.XestelikSimptom).HasForeignKey(i => i.SimptomId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
