using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DentalProjectDomain.Models;
using Microsoft.Extensions.Options;
using Microsoft.SqlServer;

namespace Persistance.Data
{
    public class DentalContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
           
        {
            OptionsBuilder.UseSqlServer("Data Source = LAPTOP - B9AASP37\\SQLEXPRESS; Initial Catalog = DentalProject; Integrated Security = True; Connect Timeout = 30; ");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
                .HasOne(ph => ph.Employee)
                .WithMany(e => e.Phones)
                .HasForeignKey(ph => ph.PhoneId);

            modelBuilder.Entity<Journal>()
                .HasOne(j => j.Patients)
                .WithOne(p => p.Journal)
                .HasForeignKey<Patient>(p => p.PatientId);
        }
       
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Phone> Phones { get; set; }
        
        public DbSet<Patient> GetSet { get; set; }
        public DbSet<Journal> Journals { get; set; }
        














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
     

    }
}
