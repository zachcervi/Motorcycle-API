using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rev.Models
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasMany(v => v.Vehicles).WithOne(a => a.Type).HasForeignKey(a => a.TypeId);
            modelBuilder.Seed();
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> Types { get; set; }
    }
}

