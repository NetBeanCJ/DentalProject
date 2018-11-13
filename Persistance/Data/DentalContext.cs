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
            OptionsBuilder.UseSqlServer("Data Source=LAPTOP-B9AASP37\\SQLEXPRESS; Initial Catalog = DentalProject; Integrated Security = True; Connect Timeout = 30; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(pr => pr.PersonId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Employee>()
                .ToTable(nameof(Employee));




            // modelBuilder.Entity<Employee>()
            //     .Property(e => e.EntemploymentDate)
            //     .HasColumnType("datetime2");

            // //***************************************************

            modelBuilder.Entity<Patient>();



            // //***************************************************

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.PersonId)
            //     .ValueGeneratedOnAdd();

            // modelBuilder.Entity<Person>()
            //   .Property(pr => pr.FirstName)
            //   .HasMaxLength(15);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.LastName)
            //     .HasMaxLength(25);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.SSRN)
            //     .HasMaxLength(13);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.Email)
            //     .HasMaxLength(50);

            // //modelBuilder.Entity<Person>()
            // //    .Property(pr => pr.Phones)
            // //    .HasMaxLength(20);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.StreetName)
            //     .HasMaxLength(70);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.StreetNr)
            //     .HasMaxLength(5);

            // modelBuilder.Entity<Person>()
            //     .Property(pr => pr.PostCode)
            //     .HasMaxLength(5);

            // modelBuilder.Entity<Person>()
            //   .Property(pr => pr.City)
            //   .HasMaxLength(50);

            // //***************************************************


            // modelBuilder.Entity<Journal>()
            //  .Property(j => j.JournalId)
            //  .ValueGeneratedOnAdd();

            // modelBuilder.Entity<Journal>()
            //.Property(j => j.Text)
            //.HasMaxLength(500);

            // //***************************************************

            // modelBuilder.Entity<Phone>()
            //     .Property(ph => ph.PhoneId)
            //     .ValueGeneratedOnAdd();

            // modelBuilder.Entity<Phone>()
            //      .Property(ph => ph.MobileNr)
            //      .HasMaxLength(20);

            // modelBuilder.Entity<Phone>()
            //      .Property(ph => ph.HomeNr)
            //      .HasMaxLength(25);
            // //***************************************************

            // modelBuilder.Entity<Treatment>()
            //    .Property(tr => tr.TreatmentId)
            //    .ValueGeneratedOnAdd();

            // modelBuilder.Entity<Treatment>()
            //      .Property(tr => tr.Name)
            //      .HasMaxLength(20);

            // modelBuilder.Entity<Treatment>()
            //      .Property(tr => tr.Description)
            //      .HasMaxLength(500);

            // modelBuilder.Entity<Treatment>()
            //      .Property(tr => tr.Price)
            //      .HasColumnType("Money");

            //***************************************************

            //    modelBuilder.Entity<Journal>()
            //        .HasOne(j => j.Patient)
            //        .WithOne(p => p.Journal)
            //        .HasForeignKey<Patient>(p => p.PatientId);

            //    modelBuilder.Entity<Phone>()
            //      .HasOne(pr => pr.Person)
            //      .WithMany(ph => ph.Phones)
            //      .HasForeignKey(pr => pr.PersonId);
        }

        //detta ska anväda när man jobbar mot db 
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Phone> Phones { get; set; }

        //public DbSet<Patient> GetSet { get; set; }
        //public DbSet<Journal> Journals { get; set; }















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
