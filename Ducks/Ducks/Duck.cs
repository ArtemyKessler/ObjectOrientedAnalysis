using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck
    {

        public string shape;
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        public void die() { }
        public void swim() { }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
