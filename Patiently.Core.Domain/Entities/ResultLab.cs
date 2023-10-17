using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Domain.Entities
{
    public class ResultLab
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int LabTestID { get; set; }
        public string Result { get; set; }
        public bool Status { get; set; }

        public Patient Patient { get; set; }
        public TestLab TestLab { get; set; }
    }

}
