using LogiGear.Application.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogiGear.Application.Commands;
using LogiGear.Domain.Repositories;
using LogiGear.Domain.Entities;

namespace LogiGear.Application.Services
{
    public class JobSeekerRegistrationAppService : IJobSeekerRegistrationAppService
    {
        private IJobSeekerRepository _jobSeekerRepository;

        public JobSeekerRegistrationAppService(IJobSeekerRepository jobSeekerRepository)
        {
            this._jobSeekerRepository = jobSeekerRepository;
        }

        public void RegisterJobSeeker(RegisterJobSeekerCommand command)
        {
            JobSeeker jobSeeker = new JobSeeker(command.Email, command.FirstName, command.LastName);
            this._jobSeekerRepository.Save(jobSeeker);
        }
    }
}
