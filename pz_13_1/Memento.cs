using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_1
{
    public class Memento
    {
        private readonly decimal _state;

        public Memento(decimal state)
        {
            _state = state;
        }

        public decimal GetState()
        {
            return _state;
        }
    }

}
