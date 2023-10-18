using Patiently.Core.Application.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserViewModel, UserViewModel>
    {

    }
}
