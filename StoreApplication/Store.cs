using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication
{
    public class Store
    {
        // Fields
        private string address;
        private List<Product> inventory;

        // Parametized constructor
        public Store(string address, List<Product> inventory) {
            this.address = address;
            this.inventory = inventory;
        }
    }
}