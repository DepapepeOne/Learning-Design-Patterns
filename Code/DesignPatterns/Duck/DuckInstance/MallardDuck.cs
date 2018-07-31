using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.DuckBehavior.Fly;
using Duck.DuckBehavior.Quack;

namespace Duck.DuckInstance
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // 呱呱叫
            QuackBehavior = new Quack();

            // 有翅膀飞行
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
