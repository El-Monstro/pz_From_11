using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_2
{
    public class ManagerComplaintHandler : ComplaintHandlerBase
    {
        public override void HandleComplaint(string complaint)
        {
            if (complaint.Contains("менеджер"))
            {
                Console.WriteLine("Менеджер обработал жалобу на сотрудника.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleComplaint(complaint);  // Передаем жалобу дальше
            }
            else
            {
                Console.WriteLine("Жалоба не может быть обработана.");
            }
        }
    }

}
