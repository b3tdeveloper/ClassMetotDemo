using System;

namespace BankSimulation
{
    class Program
    {
       

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer = new Customer();
            while (true) 
            {
                string choice = " \n ---CHOOSE--- \n" +
                    "\n1- Add customer\n 2- Show customers\n" +
                    "3- Delete Customer\n";
                Console.WriteLine(choice);
                string selection = Console.ReadLine();
                if (selection == "1")
                {
                    customerManager.add(customer);
                }else if (selection == "2")
                {
                    customerManager.listCustomer();
                }else if (selection == "3")
                {
                    customerManager.deleteCustomer(customer);
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                }

            }
        }
    }
}
