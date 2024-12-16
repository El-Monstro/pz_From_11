using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public class EWalletPayment
    {
        public bool PayWithEWallet(double amount)
        {
            Console.WriteLine($"Оплата через электронный кошелек на сумму {amount}...");
            // Логика для обработки платежа через электронный кошелек
            return true; // В реальной жизни тут будет проверка через API платёжной системы
        }
    }

}
