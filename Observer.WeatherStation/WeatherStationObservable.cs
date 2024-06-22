using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation
{
    public class WeatherStationObservable : IObservable
    {
        private int _temprature;
        public int Temprature => _temprature;
        private readonly List<IObserver> Observers;
        public WeatherStationObservable()
        {
            Observers = new List<IObserver>();
        }

        public void SetTemprature(int temprature)
        {
            _temprature = temprature;
            Notify();
        }
        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);

        }
    }
}
