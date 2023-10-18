using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.Appointment;

namespace Patiently.Core.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task Update(SaveAppointmentViewModel VM)
        {
            Appointment appointment = new();
            appointment.ID = VM.ID;
            appointment.DoctorID = VM.DoctorID;
            appointment.PatientID = VM.PatientID;
            appointment.Date = VM.Date;
            appointment.Time = VM.Time;
            appointment.Reason = VM.Reason;
            appointment.Status = VM.Status;

            await _appointmentRepository.UpdateAsync(appointment);
        }

        public async Task Add(SaveAppointmentViewModel VM)
        {
            Appointment appointment = new();
            appointment.ID = VM.ID;
            appointment.DoctorID = VM.DoctorID;
            appointment.PatientID = VM.PatientID;
            appointment.Date = VM.Date;
            appointment.Time = VM.Time;
            appointment.Reason = VM.Reason;
            appointment.Status = VM.Status;

            await _appointmentRepository.AddAsync(appointment);
        }

        public async Task Delete(int ID)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(ID);
            await _appointmentRepository.DeleteAsync(appointment);
        }

        public async Task<SaveAppointmentViewModel> GetByIdSaveViewModel(int ID)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(ID);
            SaveAppointmentViewModel saveAppointmentViewModel = new SaveAppointmentViewModel();
            saveAppointmentViewModel.ID = appointment.ID;
            saveAppointmentViewModel.DoctorID = appointment.DoctorID;
            saveAppointmentViewModel.PatientID = appointment.PatientID;
            saveAppointmentViewModel.Date = appointment.Date;
            saveAppointmentViewModel.Time = appointment.Time;
            saveAppointmentViewModel.Reason = appointment.Reason;
            saveAppointmentViewModel.Status = appointment.Status;

            return saveAppointmentViewModel;
        }

        public async Task<List<AppointmentViewModel>> GetAllViewModel()
        {
            var appointments = await _appointmentRepository.GetAllAsync();

            return appointments.Select(appointment => new AppointmentViewModel
            {
                DoctorID = appointment.DoctorID,
                PatientID = appointment.PatientID,
                Date = appointment.Date,
                Time = appointment.Time,
                Reason = appointment.Reason,
                Status = appointment.Status,
            }).ToList();
        }
    }
}
