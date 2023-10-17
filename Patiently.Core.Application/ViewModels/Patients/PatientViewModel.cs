using Patiently.Core.Application.ViewModels.Appointment;
using Patiently.Core.Application.ViewModels.ResultLab;
using Patiently.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.ViewModels.Patients
{
    public class PatientViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Identification { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool isSmoker { get; set; }
        public bool Allergies { get; set; }
        public string Photo { get; set; }

        public ICollection<AppointmentViewModel> Appointments { get; set; }
        public ICollection<SaveResultLabViewModel> LabResults { get; set; }
    }
}
