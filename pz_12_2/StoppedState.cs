using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_2
{
    public class StoppedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Играет музыка...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Невозможно приостановить, музыка не воспроизводится.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Музыка уже остановлена.");
        }

        public void Rewind(Player player)
        {
            Console.WriteLine("Перемотка невозможна, музыка не воспроизводится.");
        }
    }

}

