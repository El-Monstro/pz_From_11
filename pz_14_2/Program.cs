namespace pz_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр фасада
            PaymentFacade paymentFacade = new PaymentFacade();

            // Простое меню
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Система бронирования отелей");
                Console.WriteLine("1. Оплатить с помощью кредитной карты");
                Console.WriteLine("2. Оплатить через электронный кошелек");
                Console.WriteLine("3. Выйти");
                Console.Write("Выберите опцию: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        paymentFacade.SetPaymentMethod(new CreditCardAdapter(new CreditCardPayment()));
                        break;
                    case "2":
                        paymentFacade.SetPaymentMethod(new EWalletAdapter(new EWalletPayment()));
                        break;
                    case "3":
                        Console.WriteLine("Выход...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1, 2 или 3.");
                        continue;
                }

                // Запрос суммы для оплаты
                Console.Write("Введите сумму для оплаты: ");
                double amount = double.Parse(Console.ReadLine());

                // Обработка платежа
                paymentFacade.ProcessPayment(amount);

                // Пауза перед новым циклом
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
