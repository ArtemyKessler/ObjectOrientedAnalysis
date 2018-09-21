using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class FlyByRocket:FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Rocket Jump!");
        }
    }
}
