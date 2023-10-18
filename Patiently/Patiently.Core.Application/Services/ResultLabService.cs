using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.ResultLab;

namespace Patiently.Core.Application.Services
{
    public class ResultLabService : IResultadoService
    {
        private readonly IResultLabRepository _resultLabRepository;

        public ResultLabService(IResultLabRepository resultLabRepository)
        {
            _resultLabRepository = resultLabRepository;
        }
        public async Task Add(SaveResultLabViewModel VM)
        {
            ResultLab resultLab = new();
            resultLab.ID = VM.ID;
            resultLab.PatientID = VM.PatientID;
            resultLab.LabTestID = VM.LabTestID;
            resultLab.Result = VM.Result;
            //resultLab.Status = VM.Status;

            await _resultLabRepository.AddAsync(resultLab);
        }

        public async Task Update(SaveResultLabViewModel VM)
        {
            ResultLab resultLab = new();
            resultLab.ID = VM.ID;
            resultLab.PatientID = VM.PatientID;
            resultLab.LabTestID = VM.LabTestID;
            resultLab.Result = VM.Result;
            //resultLab.Status = VM.Status;

            await _resultLabRepository.UpdateAsync(resultLab);
        }

        public async Task Delete(int ID)
        {
            var resultLab = await _resultLabRepository.GetByIdAsync(ID);
            await _resultLabRepository.DeleteAsync(resultLab);
        }

        public async Task<SaveResultLabViewModel> GetByIdSaveViewModel(int ID)
        {
            var resultLab = await _resultLabRepository.GetByIdAsync(ID);
            SaveResultLabViewModel VM = new();
            VM.ID = resultLab.ID;
            VM.PatientID = resultLab.PatientID;
            VM.LabTestID = resultLab.LabTestID;
            VM.Result = resultLab.Result;
            //resultLab.Status = VM.Status;

            return VM;
        }

        public async Task<List<ResultLabViewModel>> GetAllViewModel()
        {
            var resultLab = await _resultLabRepository.GetAllAsync();
            return resultLab.Select(resultLab => new ResultLabViewModel
            {
                ID = resultLab.ID,
                PatientID = resultLab.PatientID,
                LabTestID = resultLab.LabTestID,
                Result = resultLab.Result,

            }).ToList();
        }
    }
}
