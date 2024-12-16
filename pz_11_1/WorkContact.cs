using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public class WorkContact : Contact
    {
        public string Position { get; set; }  // Должность

        public override void DisplayContactInfo()
        {
            Console.WriteLine($"Рабочий контакт: {Name}\nТелефон: {PhoneNumber}\nEmail: {Email}\nДолжность: {Position}");
        }
    }
}
