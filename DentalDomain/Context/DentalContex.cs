using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace DentalProjectDomain.Context

{
   public class DentalContex  : DbContext

    {                                              
    private const string ConnectionString = @"server=(localdb)\MSSQLLocalDb;" +
            "Database=DentalDB;Trusted_Connection=True";



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("pj");
   


// Tabelen Patients
        modelBuilder.Entity<Patient>
            .ToTable("Patients")
           .HasKey(p => p.PatientId);

        modelBuilder.Entity<Patient>()
           .Property(p => p.PatientId)
           .ValueGeneratedOnAdd();

        modelBuilder.Entity<Patient>()
           .Property(p => p.SSNR)
           .HasMaxLength(13);

        modelBuilder.Entity<Patient>()
               .Property(p => p.FirstName)
               .HasMaxLength(20);

        modelBuilder.Entity<Patient>()
           .Property(p => p.LastName)
           .HasMaxLength(50);

        modelBuilder.Entity<Patient>()
            .Property(p => p.Email)
            .HasMaxLength(20);

        modelBuilder.Entity<Patient>()
           .Property(p => p.Street)
           .HasMaxLength(20);

        modelBuilder.Entity<Patient>()
          .Property(p => p.StreetNr)
          .HasMaxLength(10);

        modelBuilder.Entity<Patient>()
        .Property(p => p.City)
       .HasMaxLength(20);

        modelBuilder.Entity<Patient>()
               .Property(p => p.PostCode)
              .HasMaxLength(20);

/// join?? 
        modelBuilder.Entity<Patient>()
          .HasOne(j => j.Journal)
           .WithOne(j => j.Patient);
            //Tabel Journal

        modelBuilder.Entity<Journal>()
           .ToTable("Journals")
            .HasKey(j => j.JournalId);  //identity column

        modelBuilder.Entity<Journal>()
            .Property(j => j.MenuId)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Journal>()
          .Property(j => j.Text)
            .HasMaxLength(120);

        modelBuilder.Entity<Journal>()
          .Property(j => j.Price)
           .HasColumnType("Money");

        modelBuilder.Entity<Menu>()
            .HasOne(j => j.Patients)
           .WithOne(j => j.Journals)
           .HasForeignKey(j => j.Patients);


            //////Tabel Treatment

        modelBuilder.Entity<Treatment>
              .ToTable("Treatments")
             .HasKey(t => t.TreatmentId);

        modelBuilder.Entity<Treatment>()
           .Property(t => t.TreatmentId)
           .ValueGeneratedOnAdd();

        modelBuilder.Entity<Treatment>()
               .Property(t => t.Name)
               .HasMaxLength(10);

        modelBuilder.Entity<Treatment>()
        .Property(t => t.Description)
        .HasMaxLength(150);


        modelBuilder.Entity<Treatment>()
       .Property(t => t.Price)
       .HasColumnType("Money");

        }
    }
}
