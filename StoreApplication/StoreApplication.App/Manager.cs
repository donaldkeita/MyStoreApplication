using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.App
{
    public class Manager
    {
        // Fields
        List<Customer> customerList;

        // Constructor
        public  Manager() {
            customerList = new List<Customer>();
        }

        public void addCustomer(string phoneNumber) {
            //Customer customer = new Customer("Jackie", "Jane", "240-550");
            var rand = new Random();
            
            Console.Write("Enter first name => ");
            string fname = Console.ReadLine();
            Console.Write("Enter last name => ");
            string lname = Console.ReadLine();
            Customer customer = new Customer(rand.Next(100, 501), fname, lname, phoneNumber);
        }

        public void placeOrder() {
            //Order order = new Order();
        }

        public void searchCustomer() {
            
        }

        public void displayOrder() {
            // StringBuilder sb = new StringBuilder();
            // sb.Append($"Hello, my name is {this.Name}, and I am Student {this.ID}");
            // return sb.ToString();
        }

        public void displayOrder(string str1, string str2) {

        }

        public void displayOrder(string str1, string str2, string str3) {
            
        }

        public void displaySubOrder() {
            Product product = new Product();
            string str = "";
            //str += 
        }
    }
}