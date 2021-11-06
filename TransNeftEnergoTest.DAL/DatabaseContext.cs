using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergoTest.DAL.Models;

namespace TransNeftEnergoTest.DAL
{
    public class DatabaseContext : DbContext
    {
        private static string SqlConnectionString = "Server=(localdb)\\mssqllocaldb; Database=TransNeftEnergoTest; Trusted_Connection=true;";
        public DbSet<ParentOrganization> ParentOrganizations { get; set; }
        public DbSet<ChildOrganization> ChildOrganizations { get; set; }
        public DbSet<ConsumptionUnit> ConsumptionUnits { get; set; }
        public DbSet<SupplyPoint> SuplyPoints { get; set; }
        public DbSet<AccountingDevice> AccountingDevices { get; set; }
        public DbSet<MeasurementPoint> MeasurementPoints { get; set; }
        public DbSet<ElectricityMeter> ElectricityMeters { get; set; }
        public DbSet<CurrentTransformer> CurrentTransformers { get; set; }
        public DbSet<VoltageTransformer> VoltageTransformers { get; set; }
        public DbSet<MeasurementPointToAccountingDevice> MeasurementPointToAccountingDevice { get; set; }
        public DatabaseContext() : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyPoint>()
                .HasOne(sp => sp.AccountingDevice)
                .WithOne(ad => ad.SupplyPoint)
                .HasForeignKey<AccountingDevice>(ad => ad.SupplyPointID);
            modelBuilder.Entity<AccountingDevice>()
                .HasOne(ad => ad.SupplyPoint)
                .WithOne(sp => sp.AccountingDevice);
            modelBuilder.Entity<MeasurementPointToAccountingDevice>()
                .HasOne(mp2ad => mp2ad.AccountingDevice)
                .WithOne(ad => ad.MeasurementPointToAccountingDevice)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<MeasurementPointToAccountingDevice>()
                .HasOne(mp2ad => mp2ad.MeasurementPoint)
                .WithOne(mp => mp.MeasurementPointToAccountingDevice)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
