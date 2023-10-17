using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Infrastucture.Persistence.Contexts;
using Patiently.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patiently.Infrastructure.Persistence.Repository;

namespace Patiently.Infrastucture.Persistence
{
    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region DbContext
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                           m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); ;
            }
            #endregion
            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            services.AddTransient<IDoctorsRepository, DoctorRepository>();
            services.AddTransient<IPatientsRepository, PatientRepository>();
            services.AddTransient<ITestLabRepository, TestLabRepository>();
            services.AddTransient<IResultLabRepository, Resultado_LaboRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion


        }
    }
}
