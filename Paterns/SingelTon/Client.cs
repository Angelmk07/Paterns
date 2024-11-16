using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.SingelTon
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Singleton.Instance.ReturnId();
        }

    }
}
