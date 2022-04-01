using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreApplication
{
    public class Customer
    {
        // Fields
        private String firstName;
        private String lastName;
        private String phoneNumber;
        private Datetime time;

        public Customer() {}

        public Customer(firstName, lastName, phoneNumber, time) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.time = time;
        }

        
    }
}