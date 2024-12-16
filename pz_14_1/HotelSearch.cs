using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14_1
{
    public class HotelSearch
    {
        public List<string> SearchHotels(string location, DateTime checkIn, DateTime checkOut)
        {
            Console.WriteLine($"Поиск отелей в {location} с {checkIn.ToShortDateString()} по {checkOut.ToShortDateString()}...");
            // В реальной системе тут будет запрос к базе данных или API
            return new List<string> { "Отель A", "Отель B", "Отель C" };
        }
    }
}
