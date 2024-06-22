using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.WeatherStation.Abstractions
{
    public interface IObserver
    {
        public void Update(IObservable obs);
    }
}
