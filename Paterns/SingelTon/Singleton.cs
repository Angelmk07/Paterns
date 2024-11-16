using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns.SingelTon
{
    public class Singleton
    {
        private int _id = 0;
        private int Money = 0;
        private static Singleton instance;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public int ReturnId()
        {
            return _id;
        }
        public void Add(int value)
        {
            Money += value;
        }
        public void Substruct(int value)
        {
            Money -= value;
        }
    }
}
