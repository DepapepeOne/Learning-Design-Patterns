using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.DuckBehavior.Quack
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            // 叽叽叫
            Console.WriteLine("Squeak");
        }
    }
}
