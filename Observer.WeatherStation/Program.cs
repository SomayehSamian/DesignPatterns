// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation;

Console.WriteLine("Hello, World!");



var workStation = new WeatherStationObservable();

workStation.Add(new Kiosk("8.7.5.3"));
workStation.Add(new Kiosk("22.11.22.33"));
workStation.Add(new TVRoom());

workStation.SetTemprature(10);


workStation.Add(new WallTV());

workStation.SetTemprature(13);


