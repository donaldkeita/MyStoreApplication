using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication
{
    public class Manager
    {
        // Fields
        List<Customer> customerList;

        // Constructor
        public  Manager() {
            customerList = new List<Customer>();
        }

        public void addCustomer() {
            Customer customer = new Customer("Jackie", "Jane", "240-550");
        }
    }
}