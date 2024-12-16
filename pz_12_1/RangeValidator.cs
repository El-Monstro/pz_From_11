using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_1
{
    public class RangeValidator : DataValidator
    {
        private readonly int _minValue;
        private readonly int _maxValue;

        public RangeValidator(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        // Проверка, является ли строка числом
        protected override bool IsValidFormat(string data)
        {
            return int.TryParse(data, out _);
        }

        // Дополнительная проверка: число должно быть в пределах заданного диапазона
        protected override bool MeetsAdditionalCriteria(string data)
        {
            int number = int.Parse(data);
            return number >= _minValue && number <= _maxValue;
        }
    }
}
