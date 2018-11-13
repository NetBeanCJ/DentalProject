using DentalProjectDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Data
{
    public class DentalContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {

            OptionsBuilder.UseSqlServer("Data Source=DESKTOP-CU78S16\\SQLEXPRESS; Initial Catalog = DentalProject; Integrated Security = True; Coonect Timeout = 30; "); 
                 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //****************************************************************************PERSON

            modelBuilder.Entity<Person>()
                .Property(pr => pr.PersonId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Person>()
                .Property(pr => pr.SSRN)
               .HasMaxLength(13);

           modelBuilder.Entity<Person>()
               .Property(pr => pr.FirstName)
              .HasMaxLength(15);

            modelBuilder.Entity<Person>()
                .Property(pr => pr.LastName)
                .HasMaxLength(25);

             modelBuilder.Entity<Person>()
               .Property(pr => pr.Email)
               .HasMaxLength(50);

             modelBuilder.Entity<Person>()
                .Property(pr => pr.StreetName)
               .HasMaxLength(70);

             modelBuilder.Entity<Person>()
                .Property(pr => pr.StreetNr)
                .HasMaxLength(5);

            modelBuilder.Entity<Person>()
               .Property(pr => pr.PostCode)
                 .HasMaxLength(10);

            modelBuilder.Entity<Person>()
              .Property(pr => pr.City)
              .HasMaxLength(50);

            //modelBuilder.Entity<Employee>()
            //    .ToTable(nameof(Employee));


            modelBuilder.Entity<Employee>()
                          .Property(em => em.EmpoyeeId)
                          .ValueGeneratedOnAdd();

            modelBuilder.Entity<Employee>()
                .Property(em => em.EmpoymentDate)
                .HasColumnType("datetime2");

            // //***************************************************

            // modelBuilder.Entity<Patient>();

            //*********************************************************************PATIENT

            modelBuilder.Entity<Patient>()
                          .Property(pt => pt.PatientId)
                          .ValueGeneratedOnAdd();






            //*******************************************************************JOURNAL
            modelBuilder.Entity<Journal>()
             .Property(jr => jr.JournalId)
             .ValueGeneratedOnAdd();

            modelBuilder.Entity<Journal>()
           .Property(jr => jr.Text)
           .HasMaxLength(500);

            //***************************************************PHONE

            modelBuilder.Entity<Phone>()
                .Property(ph => ph.PhoneId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Phone>()
                 .Property(ph => ph.MobileNr)
                 .HasMaxLength(20);

            modelBuilder.Entity<Phone>()
                 .Property(ph => ph.HomeNr)
                 .HasMaxLength(25);
            //***************************************************

            modelBuilder.Entity<Treatment>()
               .Property(tr => tr.TreatmentId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Treatment>()
                 .Property(tr => tr.Name)
                 .HasMaxLength(20);

            modelBuilder.Entity<Treatment>()
                 .Property(tr => tr.Description)
                 .HasMaxLength(500);

            modelBuilder.Entity<Treatment>()
                 .Property(tr => tr.Price)
                 .HasColumnType("Money");

            //***************************************************

            //modelBuilder.Entity<Journal>()
            //   .HasOne(jr => jr.Patient)
            //   .WithOne(pt => pt.Journal);


            //modelBuilder.Entity<Patient>()
            //    .HasOne(pt => pt.Journal)
            //    .WithOne(jr => jr.Patient)
            //    .HasForeignKey<Patient>(pt => pt.PatientId);

            //modelBuilder.Entity<Phone>()
            //  .HasOne(pr => pr.Person)
            //  .WithMany(ph => ph.Phones)
            //  .HasForeignKey(pr => pr.PersonId);
        }




    }
}

