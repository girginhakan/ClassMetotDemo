 using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 0;
            customer1.CustomerName = "Hakan";
            customer1.CustomerSurname = "Girgin";
            customer1.CustomerEmail = "hakan@hakan.com";
            customer1.CustomerRewiew = "Bu siteye girmek için çok heyecanlıyım";

            Customer customer2 = new Customer();
            customer2.CustomerId = 1;
            customer2.CustomerName = "Merve";
            customer2.CustomerSurname = "Gümüşsoy Girgin";
            customer2.CustomerEmail = "merve@merve.com";
            customer2.CustomerRewiew = "Bu site çok güzel üye olabilmek bir harika";

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer kisi in customers )
            {
                Console.WriteLine(kisi.CustomerName);
                Console.WriteLine(kisi.CustomerSurname);
                Console.WriteLine(kisi.CustomerEmail);
                Console.WriteLine(kisi.CustomerRewiew);

            }
            Console.WriteLine("------------------------------------------------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            Console.WriteLine("------------------------------------------------------");

            customerManager.DeleteCustomer(customer1);
            
        }
    }
}
