using LogiGear.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiGear.Application.ServiceContracts
{
    public interface IJobSeekerRegistrationAppService
    {
        void RegisterJobSeeker(RegisterJobSeekerCommand command);
    }
}
