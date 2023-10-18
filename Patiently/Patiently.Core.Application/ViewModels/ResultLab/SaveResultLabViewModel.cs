using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.ViewModels.ResultLab
{
    public class SaveResultLabViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Patient selection is required.")]
        public int PatientID { get; set; }

        [Required(ErrorMessage = "Lab Test selection is required.")]
        public int LabTestID { get; set; }

        [Required(ErrorMessage = "Result is required.")]
        public string Result { get; set; }

        [Required(ErrorMessage = "Status selection is required.")]
        public bool Status { get; set; }
    }
}
