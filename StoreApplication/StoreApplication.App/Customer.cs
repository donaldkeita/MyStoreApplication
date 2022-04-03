using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication
{
    public class Customer
    {
        // Fields
        private int customerID;
        private String firstName;
        private String lastName;
        private String phoneNumber;
        

        //public Customer() {}

        public Customer(int customerID, string firstName, string lastName, string phoneNumber) {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        
    }
}