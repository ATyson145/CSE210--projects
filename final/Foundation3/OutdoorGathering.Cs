using System;

namespace Foundation3 {
    public class OutdoorGathering : Event {
        private string _weather;
        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
            : base(title, description, date, time, address) {
                _weather = weather;
            }
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
        }
        public override string GetShortDescription()
        {
            return $"{base.GetShortDescription()}\nType: Outdoor Gathering";
        }
    }
}