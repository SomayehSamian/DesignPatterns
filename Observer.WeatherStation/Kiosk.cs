using Observer.WeatherStation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.WeatherStation
{
    public class Kiosk : IObserver
    {
        private readonly string _ipAddress;
        public Kiosk(string ipAddress)
        {
            _ipAddress = ipAddress;
            
        }
        public void Update(IObservable obs)
        {
            if (obs is WeatherStationObservable workStation)
            {
                Console.WriteLine("Kiosk, {0},{1}", workStation.Temprature,_ipAddress);
            }
        }
    }
}
