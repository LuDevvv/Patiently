using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.Doctors;

namespace Patiently.Core.Application.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorsRepository _doctorRepository;

        public DoctorService(IDoctorsRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task Update(SaveDoctorViewModel VM)
        {
            Doctor doctor = new();
            doctor.ID = VM.ID;
            doctor.FirstName = VM.FirstName;
            doctor.LastName = VM.LastName;
            doctor.Email = VM.Email;
            doctor.Phone = VM.Phone;
            doctor.Identification = VM.Identification;
            doctor.Photo = VM.Photo;

            await _doctorRepository.UpdateAsync(doctor);
        }

        public async Task Add(SaveDoctorViewModel VM)
        {
            Doctor doctor = new();
            doctor.ID = VM.ID;
            doctor.FirstName = VM.FirstName;
            doctor.LastName = VM.LastName;
            doctor.Email = VM.Email;
            doctor.Phone = VM.Phone;
            doctor.Identification = VM.Identification;
            doctor.Photo = VM.Photo;

            await _doctorRepository.AddAsync(doctor);
        }

        public async Task Delete(int ID)
        {
            var doctor = await _doctorRepository.GetByIdAsync(ID);
            await _doctorRepository.DeleteAsync(doctor);
        }

        public async Task<SaveDoctorViewModel> GetByIdSaveViewModel(int ID)
        {
            var doctor = await _doctorRepository.GetByIdAsync(ID);

            if (doctor != null)
            {
                SaveDoctorViewModel VM = new SaveDoctorViewModel
                {
                    ID = doctor.ID,
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Email = doctor.Email,
                    Phone = doctor.Phone,
                    Identification = doctor.Identification,
                    Photo = doctor.Photo
                };
                return VM;
            }
            else
            {
                return new SaveDoctorViewModel();
            }
        }

        public async Task<List<DoctorViewModel>> GetAllViewModel()
        {
            var doctors = await _doctorRepository.GetAllAsync();
            return doctors.Select(doctor => new DoctorViewModel
            {
                ID = doctor.ID,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email,
                Phone = doctor.Phone,
                Identification = doctor.Identification,
                Photo = doctor.Photo
            }).ToList();
        }
    }
}
