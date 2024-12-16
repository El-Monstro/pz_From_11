using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_1
{
    public abstract class DataValidator
    {
        // Шаблонный метод, который задает общий процесс проверки данных
        public void Validate(string data)
        {
            if (!IsValidFormat(data))
            {
                Console.WriteLine("Данные имеют некорректный формат.");
                return;
            }
            if (!MeetsLengthCriteria(data))
            {
                Console.WriteLine("Данные не соответствуют критериям длины.");
                return;
            }
            if (!MeetsAdditionalCriteria(data))
            {
                Console.WriteLine("Данные не соответствуют дополнительным критериям.");
                return;
            }
            Console.WriteLine("Данные прошли все проверки.");
        }

            protected abstract bool IsValidFormat(string data);

        // Шаг 2: Проверка длины данных (можно переопределить в подклассе)
        protected virtual bool MeetsLengthCriteria(string data)
        {
            return data.Length >= 5 && data.Length <= 100;  // Например, длина от 5 до 100 символов
        }

        // Шаг 3: Дополнительные проверки, которые могут быть специфичными для данных
        protected abstract bool MeetsAdditionalCriteria(string data);
    }
    
}
