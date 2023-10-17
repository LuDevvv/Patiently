using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Core.Domain.Entities
{
    public class TestLab
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ResultLab> ResultLabs { get; set; }
    }

}
