using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ObserverGui
{
    class WeatherData: ISubject
    {
        private List<IObserver> observers;
        private double temperature;
        private double wind;
        private double humid;
        private HttpClient http = new HttpClient();

        public WeatherData()
        {
            observers = new List<IObserver> { };
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature,humid,wind);
            }
        }

        public void DataChanged()
        {
            NotifyObserver();
        }

        public void SetData(double temp, double w, double h)
        {
            temperature = temp;
            wind = w;
            humid = h;
            DataChanged();
        }
    }
}
