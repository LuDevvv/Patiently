using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.Usuarios;

namespace Patiently.Core.Application.Services
{
    public class UserServie : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserServie(IUserRepository usersRepository)
        {
            _userRepository = usersRepository;
        }

        public async Task Add(SaveUserViewModel VM)
        {
            User user = new();
            user.ID = VM.ID;
            user.FirstName = VM.FirstName;
            user.LastName = VM.LastName;
            user.Email = VM.Email;
            user.Username = VM.Username;
            user.UserType = VM.UserType;
            user.Password = VM.Password;

            await _userRepository.AddAsync(user);
        }
        public async Task Update(SaveUserViewModel VM)
        {
            User user = new();
            user.ID = VM.ID;
            user.FirstName = VM.FirstName;
            user.LastName = VM.LastName;
            user.Email = VM.Email;
            user.Username = VM.Username;
            user.UserType = VM.UserType;
            user.Password = VM.Password;

            await _userRepository.UpdateAsync(user);
        }   
        public async Task Delete(int ID)
        {
            var user = await _userRepository.GetByIdAsync(ID);
            await _userRepository.DeleteAsync(user);
        }
        public async Task<List<UserViewModel>> GetAllViewModel()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(users => new UserViewModel
            {
                ID = users.ID,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Email = users.Email,
                Username = users.Username,
                UserType = users.UserType,
                Password = users.Password
            }).ToList();
        }
        public async Task<SaveUserViewModel> GetByIdSaveViewModel(int ID)
        {
            var user = await _userRepository.GetByIdAsync(ID);

            SaveUserViewModel vm = new();
            vm.ID = user.ID;
            vm.FirstName = user.FirstName;
            vm.LastName = user.LastName;
            vm.Email = user.Email;
            vm.Username = user.Username;
            vm.UserType = user.UserType;
            vm.Password = user.Password;
            return vm;
        }


    }
}
