using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_1
{
    public class FamilyContactFactory : ContactFactory
    {
        public override Contact CreateContact()
        {
            return new FamilyContact();
        }
    }
}
