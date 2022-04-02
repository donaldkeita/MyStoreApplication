using System;

namespace StoreApplication.App
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello World!");    

          // 1.place orders to store locations for customers
          Manager manager = new Manager();

          // 2. add a new customer
          manager.addCustomer();
        }
    }
}