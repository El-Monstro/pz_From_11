using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public class EWalletAdapter : IPaymentSystem
    {
        private EWalletPayment _eWalletPayment;

        public EWalletAdapter(EWalletPayment eWalletPayment)
        {
            _eWalletPayment = eWalletPayment;
        }

        public bool MakePayment(double amount)
        {
            return _eWalletPayment.PayWithEWallet(amount);
        }
    }

}
