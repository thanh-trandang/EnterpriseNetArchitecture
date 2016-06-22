using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiGear.Domain.Entities
{
    public class JobSeeker
    {
        public JobSeeker(String email, String firstName, String lastName)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public String Email { get; private set; }
        public String FirstName { get; private set; }
        public String MiddleName { get; set; }
        public String LastName { get; private set; }

        public bool Active { get; private set; }

        public void DeActive()
        {
            this.Active = false;
        }
        public void ReActive()
        {
            this.Active = true;
        }
    }
}
