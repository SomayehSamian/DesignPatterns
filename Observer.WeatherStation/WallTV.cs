using Observer.WeatherStation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.WeatherStation
{
    public class WallTV : IObserver
    {
        public void Update(IObservable obs)
        {
            if (obs is WeatherStationObservable workStation)
            {
                Console.WriteLine("Kiosk, {0}", workStation.Temprature);
            }
        }
    }
}
