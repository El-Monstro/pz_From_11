using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_1
{
    public class HotelBookingFacade
    {
        private HotelSearch hotelSearch;
        private Booking booking;
        private Payment payment;

        public HotelBookingFacade()
        {
            hotelSearch = new HotelSearch();
            booking = new Booking();
            payment = new Payment();
        }

        // Метод для поиска отелей, бронирования и предоплаты
        public void BookHotel()
        {
            // Ввод данных от пользователя
            Console.Write("Введите местоположение для поиска отелей: ");
            string location = Console.ReadLine();

            Console.Write("Введите дату заезда (в формате гггг-мм-дд): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите дату выезда (в формате гггг-мм-дд): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите сумму предоплаты: ");
            double prepaymentAmount = double.Parse(Console.ReadLine());

            // Шаг 1: Поиск отелей
            var hotels = hotelSearch.SearchHotels(location, checkIn, checkOut);
            if (hotels.Count == 0)
            {
                Console.WriteLine("Нет доступных отелей.");
                return;
            }

            // Печать списка отелей
            Console.WriteLine("Доступные отели:");
            for (int i = 0; i < hotels.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {hotels[i]}");
            }

            // Шаг 2: Выбор отеля
            Console.Write("Выберите отель (введите номер): ");
            int selectedIndex = int.Parse(Console.ReadLine()) - 1;
            if (selectedIndex < 0 || selectedIndex >= hotels.Count)
            {
                Console.WriteLine("Неверный выбор отеля.");
                return;
            }
            string selectedHotel = hotels[selectedIndex];

            // Шаг 3: Бронирование
            if (booking.BookHotel(selectedHotel, checkIn, checkOut))
            {
                // Шаг 4: Предоплата
                if (payment.MakePayment(selectedHotel, prepaymentAmount))
                {
                    Console.WriteLine("Ваше бронирование и предоплата успешно завершены!");
                }
                else
                {
                    Console.WriteLine("Ошибка при обработке предоплаты.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка при бронировании отеля.");
            }
        }
    }
}
