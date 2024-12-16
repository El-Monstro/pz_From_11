using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_2
{
    public abstract class ComplaintHandlerBase : IComplaintHandler
    {
        protected IComplaintHandler _nextHandler;

        public void SetNext(IComplaintHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void HandleComplaint(string complaint);
    }

}
