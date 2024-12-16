using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_1
{
    public class Booking
    {
        public bool BookHotel(string hotelName, DateTime checkIn, DateTime checkOut)
        {
            Console.WriteLine($"Бронирование отеля {hotelName} с {checkIn.ToShortDateString()} по {checkOut.ToShortDateString()}...");
            // Здесь могла бы быть логика бронирования
            return true;  // Предположим, бронирование всегда удачно
        }
    }
}
