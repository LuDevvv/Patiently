using Patiently.Core.Application.ViewModels.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.Interfaces.Services
{
    public interface IDoctorService : IGenericService<SaveDoctorViewModel, DoctorViewModel>
    {

    }
}
