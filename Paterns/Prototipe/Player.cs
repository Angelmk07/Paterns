using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Prototipe
{
    internal abstract class Player
    {
        public int Id;
        public int Hp;
        public Player(int id, int hp)
        {
            Id = id;
            Hp = hp;
        }
        public abstract Player Clone();
    }
}
