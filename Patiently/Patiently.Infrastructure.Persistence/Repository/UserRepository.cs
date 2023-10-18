using Microsoft.EntityFrameworkCore;
using Patiently.Core.Domain.Entities;
using Patiently.Infrastucture.Persistence.Contexts;
using Patiently.Core.Application.Interfaces.Repositories;
using Patiently.Core.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patiently.Infrastructure.Persistence.Repositories;

namespace Patiently.Infrastructure.Persistence.Repository
{

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
