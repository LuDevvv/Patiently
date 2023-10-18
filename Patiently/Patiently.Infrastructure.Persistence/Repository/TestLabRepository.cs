using Microsoft.EntityFrameworkCore;
using Patiently.Core.Domain.Entities;
using Patiently.Infrastucture.Persistence.Contexts;
using Patiently.Core.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Infrastructure.Persistence.Repositories
{
    public class TestLabRepository : GenericRepository<TestLab> ,ITestLabRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TestLabRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
