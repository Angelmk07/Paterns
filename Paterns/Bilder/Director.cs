using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Bilder
{
    internal class Director
    {
        private BilderCandy BilderCandy;
        public Director(BilderCandy bilderCandy)
        {
            BilderCandy = bilderCandy;
        }
        public void Construct()
        {
            BilderCandy.SetAcidityregulator();
            BilderCandy.SetShugar();
            BilderCandy.SetСolorant();
        }
    }
}
