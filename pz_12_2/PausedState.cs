using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_2
{
    public class PausedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Возобновлено воспроизведение музыки...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Музыка уже приостановлена.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Музыка остановлена.");
            player.SetState(new StoppedState());
        }

        public void Rewind(Player player)
        {
            Console.WriteLine("Перемотка невозможна, музыка приостановлена.");
        }
    }

}
