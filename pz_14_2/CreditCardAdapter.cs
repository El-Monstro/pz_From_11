using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public class CreditCardAdapter : IPaymentSystem
    {
        private CreditCardPayment _creditCardPayment;

        public CreditCardAdapter(CreditCardPayment creditCardPayment)
        {
            _creditCardPayment = creditCardPayment;
        }

        public bool MakePayment(double amount)
        {
            return _creditCardPayment.PayWithCreditCard(amount);
        }
    }

}
