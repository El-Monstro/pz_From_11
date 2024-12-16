using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_2
{
    public class PaymentFacade
    {
        private IPaymentSystem _paymentSystem;

        // Устанавливаем платежную систему через адаптер
        public void SetPaymentMethod(IPaymentSystem paymentSystem)
        {
            _paymentSystem = paymentSystem;
        }

        // Метод для осуществления платежа
        public void ProcessPayment(double amount)
        {
            if (_paymentSystem == null)
            {
                Console.WriteLine("Платежная система не выбрана.");
                return;
            }

            if (_paymentSystem.MakePayment(amount))
            {
                Console.WriteLine("Оплата прошла успешно.");
            }
            else
            {
                Console.WriteLine("Ошибка при оплате.");
            }
        }
    }

}
