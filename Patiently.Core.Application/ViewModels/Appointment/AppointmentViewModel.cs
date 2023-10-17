using Patiently.Core.Application.ViewModels.Doctors;
using Patiently.Core.Application.ViewModels.Patients;

namespace Patiently.Core.Application.ViewModels.Appointment
{
    public class AppointmentViewModel
    {
        public int ID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public bool Status { get; set; }

        // Foreign Key References
        public DoctorViewModel Doctor { get; set; }
        public PatientViewModel Patient { get; set; }
    }
}
