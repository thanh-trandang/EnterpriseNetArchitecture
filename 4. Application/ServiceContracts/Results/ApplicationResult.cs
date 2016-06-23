using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiGear.Application.ServiceContracts.Results
{
    public class ApplicationResult<T>
    {
        public ApplicationResult(T target)
        {
            this.Result = target;
        }

        public T Result { get; }

        public ApplicationStatus Status { get
            {
                this._status = ApplicationStatus.SUCCESS;
                if (this.Error != null)
                {
                    this._status = ApplicationStatus.FAIL;
                }
               
                return _status;
            }
        }

        private ApplicationStatus _status;

        public Exception Error { get; set; }
    }

    public enum ApplicationStatus
    {
        SUCCESS,
        FAIL
    }
}
