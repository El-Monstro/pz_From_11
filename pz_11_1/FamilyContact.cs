using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public class FamilyContact : Contact
    {
        public string Relationship { get; set; }  // Родство

        public override void DisplayContactInfo()
        {
            Console.WriteLine($"Семейный контакт: {Name}\nТелефон: {PhoneNumber}\nEmail: {Email}\nОтношения: {Relationship}");
        }
    }
}
