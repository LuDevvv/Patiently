using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel>
        where SaveViewModel : class
        where ViewModel : class
    {
        Task Update(SaveViewModel VM);

        Task Add(SaveViewModel VM);

        Task Delete(int ID);

        Task<SaveViewModel> GetByIdSaveViewModel(int ID);

        Task<List<ViewModel>> GetAllViewModel();


    }

}
