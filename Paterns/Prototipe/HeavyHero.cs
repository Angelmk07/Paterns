using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Prototipe
{
    internal class HeavyHero : Player
    {
        string weapen;
        public HeavyHero(int id, int hp, string weapen) : base(id, hp)
        {
            this.weapen = weapen;
        }

        public override Player Clone()
        {
            return new HeavyHero(Id, Hp,this.weapen);
        }
    }
}
