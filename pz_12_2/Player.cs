using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12_2
{
    public class Player
    {
        private IPlayerState _state;

        public Player()
        {
            _state = new StoppedState(); // Начальное состояние плеера
        }

        public void SetState(IPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }

        public void Rewind()
        {
            _state.Rewind(this);
        }
    }

}

