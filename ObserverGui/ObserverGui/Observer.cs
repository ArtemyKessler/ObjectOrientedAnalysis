using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverGui
{
    public interface IObserver
    {
        void Update(double temperature, double humid, double wind);
    }
}
