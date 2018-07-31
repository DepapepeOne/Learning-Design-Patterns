using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.DuckBehavior.Quack
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            // 不会叫
            Console.WriteLine("Slience");
        }
    }
}
