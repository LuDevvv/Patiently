using Patiently.Core.Domain.Entities;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces.Services;
using Patiently.Core.Application.ViewModels.TestLab;

namespace Patiently.Core.Application.Services
{
    public class TestLabService  : ITestLabService
    {
        private readonly ITestLabRepository _testLabRepository;
        public TestLabService(ITestLabRepository testLabRepository)
        {
            _testLabRepository = testLabRepository;
        }

        public async Task Add(SaveTestLab VM)
        {
            TestLab testLab = new();
            testLab.ID = VM.ID;
            testLab.Name = VM.Name;

            await _testLabRepository.AddAsync(testLab);
        }
        public async Task Update(SaveTestLab VM)
        {
            TestLab testLab = new();
            testLab.ID = VM.ID;
            testLab.Name = VM.Name;

            await _testLabRepository.UpdateAsync(testLab);
        }
        public async Task Delete(int ID)
        {
            var testLab = await _testLabRepository.GetByIdAsync(ID);
            await _testLabRepository.DeleteAsync(testLab);
        }

        public async Task<SaveTestLab> GetByIdSaveViewModel(int ID)
        {
            var testLab = await _testLabRepository.GetByIdAsync(ID);
            SaveTestLab saveTestLab = new SaveTestLab();

            saveTestLab.ID = testLab.ID;
            saveTestLab.Name = testLab.Name;

            return saveTestLab;
        }

        public async Task<List<TestLabViewModel>> GetAllViewModel()
        {
            var testLab = await _testLabRepository.GetAllAsync();
            return testLab.Select(testLab => new TestLabViewModel
            {
                ID = testLab.ID,
                Name = testLab.Name,
            }).ToList();

        }
    }
}
