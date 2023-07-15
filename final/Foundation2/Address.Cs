using System;

namespace Foundation2 {
    public class Address {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;
        public string GetStreetAddress() {
            return _streetAddress;
        }
        public void SetStreetAddress(string streetAddress) {
            _streetAddress = streetAddress;
        }
        public string GetCity() {
            return _city;
        }
        public void SetCity(string city) {
            _city = city;
        }
        public string GetStateProvince() {
            return _stateProvince;
        }
        public void SetStateProvince(string stateProvince) {
            _stateProvince = stateProvince;
        }
        public string GetCountry() {
            return _country;
        }
        public void SetCountry(string country) {
            _country = country;
        }
        public bool IsInUSA() {
            return _country == "USA";
        }
        public string GetFullAddress() {
            return $"{_streetAddress}, {_city}\n{_stateProvince}, {_country}";
        }
    }
}