using Microsoft.EntityFrameworkCore;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Domain.Entities;
using Patiently.Infrastructure.Persistence.Repositories;
using Patiently.Infrastucture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Infrastructure.Persistence.Repository
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DoctorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
