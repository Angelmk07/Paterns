using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Prototipe
{
    internal class LightHero : Player
    {
        string weapen;
        public LightHero(int id, int hp, string weapen) : base(id, hp)
        {
            this.weapen = weapen;
        }

        public override Player Clone()
        {
            return new LightHero(Id, Hp, this.weapen);
        }
    }
}
