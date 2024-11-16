using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.Bilder
{
    internal class BildLollipop : BilderCandy
    {
        Candy candy = new();
        public override Candy GetRsult()
        {
            return candy;
        }

        public override void SetAcidityregulator()
        {
            candy.add("Limon");
        }

        public override void SetShugar()
        {
            candy.add("200 mg");
        }

        public override void SetСolorant()
        {
            candy.add("Red");
        }
    }
}
