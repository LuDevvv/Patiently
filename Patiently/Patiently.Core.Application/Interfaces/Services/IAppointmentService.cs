using Patiently.Core.Application.ViewModels.Appointment;

namespace Patiently.Core.Application.Interfaces.Services
{
    public interface IAppointmentService : IGenericService<SaveAppointmentViewModel, AppointmentViewModel>
    {
        Task Update(SaveAppointmentViewModel VM);
    }
}
