using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DentalProjectDomain.Models;

namespace Persistance.Data
{
    public class DentalContext : DbContext
    {
        //private const string ConnectionString = @"server=(localdb)\MSSQLLocalDb;" +
        //   "Database=MenuCards;Trusted_Connection=True";
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<User> Users { get; set; }
        ////protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        ////{
        ////    base.OnConfiguring(optionsBuilder);
        ////    optionsBuilder.UseSqlServer(ConnectionString);
        ////    // optionsBuilder.UseSqlServer(ConnectionString, options => options.MaxBatchSize(1));
        ////}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.HasDefaultSchema("ur");

        //    modelBuilder.Entity<User>()
        //    .ToTable("Users")
        //    .HasKey(U)


        //}
    }
