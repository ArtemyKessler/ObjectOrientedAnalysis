using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverGui
{
    class ConcreteObserver:IObserver,IDisplayElement
    {
        public void Update(double temperature, double humid, double wind)
        { }

        public void Display()
        { }
    }
}
