using LogiGear.Domain.Entities;
using LogiGear.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogiGear.Domain.Repositories.Shared;
using System.Linq.Expressions;
using LogiGear.Infrastructure.Persistence.Entities;

namespace LogiGear.Infrastructure.Persistence
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private EFRepository<User> _userRepository;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public JobSeeker Add(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public JobSeeker Update(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public JobSeeker Delete(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobSeeker> FindBy(Expression<Func<JobSeeker, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<JobSeeker> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
