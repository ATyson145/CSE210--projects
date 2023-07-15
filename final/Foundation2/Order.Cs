using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2 {
    public class Order {
        private List<Product> _products;
        private Customer _customer;
        public Order (Customer customer) {
            _products = new List<Product>();
            this._customer = customer;
        }
        public void AddProduct(Product product) {
            _products.Add(product);
        }
        public decimal CalculateCost() {
            decimal cost = 0;
            foreach (Product product in _products) {
                cost += product.CalculatePrice();
            }
            if (_customer.IsInUSA()) {
                cost += 5;
            }
            else {
                cost += 35;
            }
            return cost;
        }
        public string GetPackingLabel() {
            StringBuilder label = new StringBuilder();
            foreach (Product Product in _products) {
                label.AppendLine($"Product ID: {Product.GetProductId()}, Name: {Product.GetName()}");
            }
            return label.ToString();
        }
        public string GetShippingLabel() {
            string customerName = _customer.GetName();
            string address = _customer.GetAddress().GetFullAddress();
            return $"Customer: {customerName}\n{address}";
        }
    }
}