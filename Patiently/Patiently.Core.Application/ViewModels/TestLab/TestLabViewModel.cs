using Patiently.Core.Application.ViewModels.ResultLab;

namespace Patiently.Core.Application.ViewModels.TestLab
{
    public class TestLabViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ResultLabViewModel> ResultLabs { get; set; }
    }
}
