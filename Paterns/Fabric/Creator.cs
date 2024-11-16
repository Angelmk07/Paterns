using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Fabric
{
    abstract class Creator
    {
        string Name;
        int BaterrySize;

        public Creator(string name, int baterrySize) 
        {            Name = name;
            BaterrySize = baterrySize;
        }
        abstract public Laptop CreateLaptop();
    }
}
