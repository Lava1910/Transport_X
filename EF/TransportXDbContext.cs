using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Transport_X.Configurations;
using Transport_X.Controllers;
using Transport_X.Entities;

namespace Transport_X.EF
{
    public class TransportXDbContext : DbContext
    {
        public TransportXDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WardConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new GoodsConfiguration());
            modelBuilder.ApplyConfiguration(new WeightConfiguration());
            modelBuilder.ApplyConfiguration(new InsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new ReasonFailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ward> Wards { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<ReasonFail> ReasonFail { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Weight> Weight { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
