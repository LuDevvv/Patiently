using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Domain.Entities
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Identification { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSmoker { get; set; }
        public bool Allergies { get; set; }
        public string Photo { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<ResultLab> LabResults { get; set; }
    }

}
