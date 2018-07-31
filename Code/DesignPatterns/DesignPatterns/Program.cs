using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.DuckBehavior.Fly;
using Duck.DuckInstance;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck.Duck mallard = new MallardDuck();

            mallard.PerformQuack();
            mallard.PerformFly();

            Duck.Duck model = new ModelDuck();
            model.PerformQuack();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
