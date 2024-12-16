using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_2
{
    public interface IPlayerState
    {
        void Play(Player player);
        void Pause(Player player);
        void Stop(Player player);
        void Rewind(Player player);
    }


}
