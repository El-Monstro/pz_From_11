using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public abstract class Contact
    {
        public string Name { get; set; }  // Имя контакта
        public string PhoneNumber { get; set; }  // Номер телефона
        public string Email { get; set; }  // Электронная почта

        // Абстрактный метод для отображения информации  о контакте
        public abstract void DisplayContactInfo();
    }
}
