using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_12_1
{
    public class EmailValidator : DataValidator
    {
        // Проверка формата email
        protected override bool IsValidFormat(string data)
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(data);
        }

        // Дополнительная проверка для email (например, можно проверить домен)
        protected override bool MeetsAdditionalCriteria(string data)
        {
            // Допустим, проверяем, что домен email - "example.com"
            return data.EndsWith("@example.com");
        }
    }
}
