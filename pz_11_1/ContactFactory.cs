using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public abstract class ContactFactory
    {
        // Метод для создания контакта, который должен быть реализован в конкретных фабриках
        public abstract Contact CreateContact();
    }
}
