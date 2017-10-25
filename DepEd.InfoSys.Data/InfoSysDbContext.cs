using DepEd.InfoSys.Data.Helpers;
using DepEd.InfoSys.Entities;
using DepEd.InfoSys.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Data
{
    public class InfoSysDbContext : DbContext
    {
        public InfoSysDbContext(DbContextOptions<InfoSysDbContext> options)
            : base(options)
        { }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<District> Districts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>()
                .ToTable(Constants.Tables.Region)
                .HasKey(_ => _.Id);

            modelBuilder.Entity<Division>()
                .ToTable(Constants.Tables.Division)
                .HasKey(_ => _.Id);

            modelBuilder.Entity<District>()
                .ToTable(Constants.Tables.District)
                .HasKey(_ => _.Id);
        }
    }
}
