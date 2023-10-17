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


        public DbSet<Appointment> citas { get; set; }
        public DbSet<Doctor> medicos { get; set; }
        public DbSet<Patient> pacientes { get; set; }
        public DbSet<TestLab> prueba_Labos { get; set; }
        public DbSet<ResultLab> resultado_Labos { get; set; }
        public DbSet<User> usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<TestLab>().ToTable("TestLab");
            modelBuilder.Entity<ResultLab>().ToTable("ResultLab");
            modelBuilder.Entity<User>().ToTable("Users");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Appointment>().HasKey(Cita => Cita.ID);
            modelBuilder.Entity<Doctor>().HasKey(Medico => Medico.ID);
            modelBuilder.Entity<Patient>().HasKey(Paciente => Paciente.ID);
            modelBuilder.Entity<TestLab>().HasKey(Prueba_Labo => Prueba_Labo.ID);
            modelBuilder.Entity<ResultLab>().HasKey(Resultado_Labo => Resultado_Labo.ID);
            modelBuilder.Entity<User>().HasKey(Usuario => Usuario.ID);
            #endregion

            #region relationships
            // Configurar relaciones uno a muchos entre Cita, Medico y Paciente
            modelBuilder.Entity<Appointment>()
           .HasOne(c => c.Medico).WithMany(m => m.Citas).HasForeignKey(c => c.IdMedicos).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
           .HasOne(c => c.Paciente).WithMany(p => p.Citas).HasForeignKey(c => c.IdPacientes).OnDelete(DeleteBehavior.Cascade);

            // Configurar relaciones uno a muchos entre Resultado_Labo y Paciente
            modelBuilder.Entity<ResultLab>()
                .HasOne(rl => rl.Paciente).WithMany(p => p.Resultado_Labos).HasForeignKey(rl => rl.IDPaciente).OnDelete(DeleteBehavior.Cascade);

            // Configurar relaciones uno a muchos entre Resultado_Labo y Prueba_Labo
            modelBuilder.Entity<ResultLab>()
                .HasOne(rl => rl.Prueba_Labo)
                .WithMany(pl => pl.Resultado_Labos)
                .HasForeignKey(rl => rl.IDPruebaLabo)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property Configurations"
            #region "Cita"
            modelBuilder.Entity<Appointment>().Property(c => c.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Appointment>().Property(c => c.IdMedicos).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.IdPacientes).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Fecha).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Hora).IsRequired();
            modelBuilder.Entity<Appointment>().Property(c => c.Estado).IsRequired();
            #endregion

            #region "Medico"
            modelBuilder.Entity<Doctor>().Property(m => m.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Doctor>().Property(m => m.Nombre).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Apellido).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Correo).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Cedula).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Telefono).IsRequired();
            modelBuilder.Entity<Doctor>().Property(m => m.Foto).IsRequired();
            #endregion

            #region "Paciente"
            modelBuilder.Entity<Patient>().Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Patient>().Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Apellido).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Telefono).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Direccion).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Cedula).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Fecha_Nacimiento).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Fumador).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Alergias).IsRequired();
            modelBuilder.Entity<Patient>().Property(p => p.Foto).IsRequired();
            #endregion

            #region "Prueba_Labo"
            modelBuilder.Entity<TestLab>().Property(pl => pl.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<TestLab>().Property(pl => pl.Nombre).IsRequired();
            #endregion

            #region "Resultado_Labo"
            modelBuilder.Entity<ResultLab>().Property(rl => rl.ID).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.IDPaciente).IsRequired();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.IDPruebaLabo).IsRequired();
            modelBuilder.Entity<ResultLab>().Property(rl => rl.Resultado).IsRequired();
            #endregion
            #endregion

        }

    }
}
