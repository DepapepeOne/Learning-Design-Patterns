using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.DuckBehavior.Fly;
using Duck.DuckBehavior.Quack;

namespace Duck.DuckInstance
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
