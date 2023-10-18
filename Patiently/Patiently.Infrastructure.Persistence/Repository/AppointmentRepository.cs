using Microsoft.EntityFrameworkCore;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Domain.Entities;
using Patiently.Infrastucture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patiently.Infrastructure.Persistence.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
