using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Domain.Entities
{
    public class Appointment
    {
        public int ID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public bool Status { get; set; }

        // Foreign Key References
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }

}
