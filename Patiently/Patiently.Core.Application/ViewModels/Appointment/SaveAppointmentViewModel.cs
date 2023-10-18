using System.ComponentModel.DataAnnotations;

namespace Patiently.Core.Application.ViewModels.Appointment
{
    public class SaveAppointmentViewModel
    {
        public class Appointment
        {
            public int ID { get; set; }

            [Required(ErrorMessage = "Doctor selection is required.")]
            public int DoctorID { get; set; }

            [Required(ErrorMessage = "Patient selection is required.")]
            public int PatientID { get; set; }

            [Required(ErrorMessage = "Patient date is required.")]
            public DateTime Date { get; set; }

            [Required(ErrorMessage = "Patient time is required.")]
            public DateTime Time { get; set; }

            [Required(ErrorMessage = "The 'Reason' field is mandatory.")]
            public string Reason { get; set; }

            [Required(ErrorMessage = "State selection is required.")]
            public bool Status { get; set; }
        }

    }
}
