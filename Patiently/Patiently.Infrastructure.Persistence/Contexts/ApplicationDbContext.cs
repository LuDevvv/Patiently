using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patiently.Core.Domain.Entities;

namespace Patiently.Infrastucture.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<TestLab> TestLab { get; set; }
        public DbSet<ResultLab> ResultLab { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<Appointment>().ToTable("Appointments");
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<TestLab>().ToTable("TestLab");
            modelBuilder.Entity<ResultLab>().ToTable("ResultLab");
            modelBuilder.Entity<User>().ToTable("Users");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Appointment>().HasKey(Appointments => Appointments.ID);
            modelBuilder.Entity<Doctor>().HasKey(Doctors => Doctors.ID);
            modelBuilder.Entity<Patient>().HasKey(Patients => Patients.ID);
            modelBuilder.Entity<TestLab>().HasKey(TestLab => TestLab.ID);
            modelBuilder.Entity<ResultLab>().HasKey(ResultLab => ResultLab.ID);
            modelBuilder.Entity<User>().HasKey(Users => Users.ID);
            #endregion

            #region relationships
            modelBuilder.Entity<Appointment>()
           .HasOne(c => c.Doctor).WithMany(m => m.Appointments).HasForeignKey(c => c.DoctorID).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
           .HasOne(c => c.Patient).WithMany(p => p.Appointments).HasForeignKey(c => c.PatientID).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResultLab>()
                .HasOne(rl => rl.Patient).WithMany(p => p.LabResults).HasForeignKey(rl => rl.PatientID).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResultLab>()
                .HasOne(rl => rl.TestLab)
                .WithMany(pl => pl.ResultLabs)
                .HasForeignKey(rl => rl.LabTestID)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property Configurations"
            #region "Appointment"
            modelBuilder.Entity<Appointment>().Property(c => c.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Appointment>().Property(c => c.DoctorID).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.PatientID).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Date).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Time).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Status).IsRequired();
            #endregion

            #region "Doctor"
            modelBuilder.Entity<Doctor>().Property(m => m.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Doctor>().Property(m => m.FirstName).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.LastName).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Email).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Identification).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Phone).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Photo).IsRequired();
            #endregion

            #region "Patient"
            modelBuilder.Entity<Patient>().Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Patient>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Phone).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Address).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Identification).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.DateOfBirth).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.IsSmoker).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Allergies).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Photo).IsRequired();
            #endregion

            #region "TestLab"
            modelBuilder.Entity<TestLab>().Property(pl => pl.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<TestLab>().Property(pl => pl.Name).IsRequired();
            #endregion

            #region "ResultLab"
            modelBuilder.Entity<ResultLab>().Property(rl => rl.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.PatientID).IsRequired();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.LabTestID).IsRequired();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.Result).IsRequired();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.Status).IsRequired();
            #endregion
            #endregion

        }

    }
}
