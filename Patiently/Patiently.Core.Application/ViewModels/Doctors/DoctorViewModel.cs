using Patiently.Core.Application.ViewModels.Appointment;

namespace Patiently.Core.Application.ViewModels.Doctors
{
    public class DoctorViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Identification { get; set; }
        public string Photo { get; set; }

        public ICollection<AppointmentViewModel> Appointments { get; set; }
    }
}
