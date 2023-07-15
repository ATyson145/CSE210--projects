using System;

namespace Foundation2 {
    public class Product {
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;
    
    public string GetName() {
        return _name;
    }
    public void SetName(string name) {
        _name = name;
    }
    public int GetProductId() {
        return _productId;
    }
    public void SetProductId(int productId) {
        _productId = productId;
    }
    public decimal GetPrice() {
        return _price;
    }
    public void SetPrice(decimal price) {
        _price = price;
    }
    public int GetQuantity() {
        return _quantity;
    }
    public void SetQuantity(int quantity) {
        _quantity = quantity;
    }
    public decimal CalculatePrice() {
        return _price * _quantity;
    }
    }
}