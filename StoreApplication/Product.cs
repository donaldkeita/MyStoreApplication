using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication
{
    public class Product
    {
    
        // Fields
        private string productType;
        private string productName;
        private int quantity;
        private double cost;

        // Parametized construtor
        public Inventory(string productType, string productName, int quantity, double cost) {
            this.productType = productType; 
            this.productName = productName;
            this.quantity = quantity;
            this.cost = cost;
        }
    }
}