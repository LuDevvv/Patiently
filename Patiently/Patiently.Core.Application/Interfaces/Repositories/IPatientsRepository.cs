using Patiently.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patiently.Core.Application.Interfaces.Repositories;

namespace Patiently.Core.Application.Interfaces.Repositories
{
    public interface IPatientsRepository : IGenericRepository<Patient>
    {

    }
}
