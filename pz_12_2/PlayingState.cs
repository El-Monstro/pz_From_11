using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_2
{
    public class PlayingState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Музыка уже воспроизводится.");
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Музыка приостановлена.");
            player.SetState(new PausedState());
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Музыка остановлена.");
            player.SetState(new StoppedState());
        }

        public void Rewind(Player player)
        {
            Console.WriteLine("Перемотка музыки...");
            player.SetState(new RewindingState());
        }
    }


}
