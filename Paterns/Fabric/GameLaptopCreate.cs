using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Fabric
{
    internal class GameLaptopCreate : Creator
    {
        public GameLaptopCreate(string name, int baterrySize) : base(name, baterrySize)
        {
        }

        public override Laptop CreateLaptop()
        {
            return new GameLaptop();
        }
    }
}
