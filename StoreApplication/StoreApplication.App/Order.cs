using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication.App
{
    public class Order
    {
        // Fields
        private int customerID;
        private string location;
        private DateTime time;
        private int productID;

        public Order(int customerID, int productID, string location, DateTime time) {
            this.customerID = customerID;
            this.productID = productID;
            this.location = location;
            this.time = time;
        }
    }
}