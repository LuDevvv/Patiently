using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.Patients;

namespace Patiently.Core.Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientsRepository _patientRepository;

        public PatientService(IPatientsRepository PatientsRepository)
        {
            _patientRepository = PatientsRepository;
        }

        public async Task Add(SavePatientViewModel VM)
        {
            Patient patient = new();
            patient.ID = VM.ID;
            patient.FirstName = VM.FirstName;
            patient.LastName = VM.LastName;
            patient.Phone = VM.Phone;
            patient.Address = VM.Address;
            patient.Identification = VM.Identification;
            patient.DateOfBirth = VM.DateOfBirth;
            patient.IsSmoker = VM.IsSmoker;
            patient.Allergies = VM.Allergies;
            patient.Photo = VM.Photo;

            await _patientRepository.AddAsync(patient);
        }
        public async Task Update(SavePatientViewModel VM)
        {
            Patient patient = new();
            patient.ID = VM.ID;
            patient.FirstName = VM.FirstName;
            patient.LastName = VM.LastName;
            patient.Phone = VM.Phone;
            patient.Address = VM.Address;
            patient.Identification = VM.Identification;
            patient.DateOfBirth = VM.DateOfBirth;
            patient.IsSmoker = VM.IsSmoker;
            patient.Allergies = VM.Allergies;
            patient.Photo = VM.Photo;

            await _patientRepository.UpdateAsync(patient);
        }

        public async Task Delete(int ID)
        {
            var patient = await _patientRepository.GetByIdAsync(ID);
            await _patientRepository.DeleteAsync(patient);
        }

        public async Task<SavePatientViewModel> GetByIdSaveViewModel(int ID)
        {
            var patient = await _patientRepository.GetByIdAsync(ID);
            SavePatientViewModel VM = new();
            VM.ID = patient.ID;
            VM.FirstName = patient.FirstName;
            VM.LastName = patient.LastName;
            VM.Phone = patient.Phone;
            VM.Address = patient.Address;
            VM.Identification = patient.Identification;
            VM.DateOfBirth = patient.DateOfBirth;
            VM.IsSmoker = patient.IsSmoker;
            VM.Allergies = patient.Allergies;
            VM.Photo = patient.Photo;

            return VM;
        }

        public async Task<List<PatientViewModel>> GetAllViewModel()
        {
            var patients = await _patientRepository.GetAllAsync();
            return patients.Select(patient => new PatientViewModel
            {
                ID = patient.ID,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Phone = patient.Phone,
                Address = patient.Address,
                Identification = patient.Identification,
                DateOfBirth = patient.DateOfBirth,
                IsSmoker = patient.IsSmoker,
                Allergies = patient.Allergies,
                Photo = patient.Photo
            }).ToList();
        }

    }
}
