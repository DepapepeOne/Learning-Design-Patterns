using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.DuckBehavior.Fly;
using Duck.DuckBehavior.Quack;

namespace Duck
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            // 游泳
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            FlyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            QuackBehavior = behavior;
        }
    }
}

