using Patiently.Core.Application.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.Interfaces.Services
{
    public interface IPatientService : IGenericService<SavePatientViewModel, PatientViewModel>
    {
    }
}
