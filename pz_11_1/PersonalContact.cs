using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public class PersonalContact : Contact
    {
        public override void DisplayContactInfo()
        {
            Console.WriteLine($"Личный контакт: {Name}\nТелефон: {PhoneNumber}\nEmail: {Email}");
        }
    }
}
