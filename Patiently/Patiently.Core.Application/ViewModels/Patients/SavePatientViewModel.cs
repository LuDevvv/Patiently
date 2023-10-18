using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.ViewModels.Patients
{
    public class SavePatientViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Identification number is required.")]
        public string Identification { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Smoker status is required.")]
        public bool IsSmoker { get; set; }

        [Required(ErrorMessage = "Allergies status is required.")]
        public bool Allergies { get; set; }

        [RegularExpression(@"\.(jpg|jpeg|png|gif)$", ErrorMessage = "Photo is required or The photo format is incorrect.")]
        public string Photo { get; set; }
    }
}
