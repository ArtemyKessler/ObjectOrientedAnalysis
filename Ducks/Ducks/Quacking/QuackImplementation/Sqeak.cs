using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Sqeak: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Пии");
        }
    }
}
