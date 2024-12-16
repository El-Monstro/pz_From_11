using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public interface IPaymentSystem
    {
        bool MakePayment(double amount);
    }

}
