using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.DuckBehavior.Quack
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            // 呱呱叫
            Console.WriteLine("Quack");
        }
    }
}
