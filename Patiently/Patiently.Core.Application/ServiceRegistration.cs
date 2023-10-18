using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.Services;

namespace Patiently.Infrastucture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<ITestLabService, TestLabService>();
            services.AddTransient<IResultadoService, ResultLabService>();
            services.AddTransient<IUserService, UserServie>();
            #endregion
        }
    }
}
