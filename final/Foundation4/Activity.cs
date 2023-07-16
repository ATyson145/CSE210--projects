using System;
using System.Collections.Generic;

namespace Foundation4 {
    public abstract class Activity {
        private DateTime _date;
        private int _length;
        public Activity (DateTime date, int length) {
            _date = date;
            _length = length;
        }
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public int GetLength() {
            return _length;
        }
        public virtual string GetSummary() {
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();

            string summary = $"{_date:d MMM yyyy} {GetType().Name} ({_length} min): Distance: {distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min per km";
            return summary;
        }
    }
}