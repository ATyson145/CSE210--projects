using System;

namespace Foundation3 {
    public class Reception : Event {
        public string _email;
        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string email)
        : base(title, description, date, time, address) {
            _email = email;
        }
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_email}";
        }
        public override string GetShortDescription()
        {
            return $"{base.GetShortDescription()}\nType: Reception";
        }
    }
}