using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Prototipe
{
    internal class Client
    {
        public Client() { }
        void Operation()
        {
            Player prototype = new LightHero(0,75);
            Player clone = prototype.Clone();
            prototype = new HeavyHero(1,200);
            clone = prototype.Clone();
        }
    }
}
