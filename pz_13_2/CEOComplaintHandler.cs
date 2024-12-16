using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_2
{
    public class CEOComplaintHandler : ComplaintHandlerBase
    {
        public override void HandleComplaint(string complaint)
        {
            Console.WriteLine("Генеральный директор обработал жалобу.");
        }
    }

}
