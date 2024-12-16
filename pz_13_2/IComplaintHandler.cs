using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_2
{
    public interface IComplaintHandler
    {
        void SetNext(IComplaintHandler handler);  // Устанавливает следующий обработчик в цепочке
        void HandleComplaint(string complaint);   // Обрабатывает жалобу
    }

}
