using Patiently.Core.Application.ViewModels.ResultLab;
using Patiently.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Application.ViewModels.TestLab
{
    public class TestLabViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ResultLabViewModel> ResultLabs { get; set; }
    }
}
