namespace pz_14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем фасад
            HotelBookingFacade bookingFacade = new HotelBookingFacade();

            // Простое меню
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Система бронирования отелей");
                Console.WriteLine("1. Найти и забронировать отель");
                Console.WriteLine("2. Выход");
                Console.Write("Выберите опцию: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        bookingFacade.BookHotel();
                        break;
                    case "2":
                        Console.WriteLine("Выход...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1 или 2.");
                        break;
                }

                // Пауза перед новым циклом
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
    
}
