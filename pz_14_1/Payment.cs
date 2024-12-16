using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_1
{
    public class Payment
    {
        public bool MakePayment(string hotelName, double amount)
        {
            Console.WriteLine($"Предоплата за отель {hotelName}: {amount} долларов...");
            // Здесь могла бы быть интеграция с платежной системой
            return true;  // Пусть предоплата всегда проходит успешно
        }
    }
}
