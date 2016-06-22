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

        public JobSeeker Save(JobSeeker jobSeeker)
        {
            User user = new User();
            user.Email = jobSeeker.Email;
            user.FirstName = jobSeeker.FirstName;
            user.MiddleName = jobSeeker.MiddleName;
            user.LastName = jobSeeker.LastName;
            return jobSeeker;
        }

        public JobSeeker FindOnlyOneJobSeeker(string email)
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
