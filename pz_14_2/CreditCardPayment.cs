using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public class CreditCardPayment
    {
        public bool PayWithCreditCard(double amount)
        {
            Console.WriteLine($"Оплата кредитной картой на сумму {amount}...");
            // Логика для обработки платежа с использованием кредитной карты
            return true; // В реальной жизни тут будет проверка через API платёжной системы
        }
    }

}
