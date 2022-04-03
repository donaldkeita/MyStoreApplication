using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication.App
{
    public class Product
    {
    
        // Fields
        public string productType;
        private string productName;
        private int quantity;
        private double cost;

        // Parametized construtor
        public Product(string productType, string productName, int quantity, double cost) {
            this.productType = productType; 
            this.productName = productName;
            this.quantity = quantity;
            this.cost = cost;
        }

        public string getproductType() {
            return productType;
        }
    }
}