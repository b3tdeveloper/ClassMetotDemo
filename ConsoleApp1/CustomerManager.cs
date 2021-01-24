using System;
using System.Collections.Generic;
using System.Text;

namespace BankSimulation
{
    class CustomerManager
    {
        
        public void add(Customer customer)
        {
            

            Console.WriteLine("Please enter your name : ");
            customer.name = Console.ReadLine();
            Console.WriteLine("Please enter your surname : ");
            customer.surname = Console.ReadLine();
            Console.WriteLine("Please enter your mail adress : ");
            customer.mailAdress = Console.ReadLine();
            Console.WriteLine("Please enter your year of birth : ");
            customer.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Please enter your identy card number : ");
            customer.Id = Console.ReadLine();
            Console.WriteLine("Please enter your phone number : ");
            customer.phoneNumber = Console.ReadLine();

        }

        internal void listCustomer()
        {
            Console.WriteLine("Listed"); 
        }

        public void listCustomer(Customer customer)
        {
            //Console.WriteLine("name : " + customer.name);
            //Console.WriteLine("surname : " + customer.surname);
            //Console.WriteLine("mail adress : " + customer.mailAdress);
            //Console.WriteLine("date of birth : " + customer.dateOfBirth);
            //Console.WriteLine("ıdentify number : " + customer.Id);
            //Console.WriteLine("phone number : " + customer.phoneNumber);
            //Console.WriteLine("\nIdentify number : " + custom.Id + "\nCustomer name : " + custom.name + "\nCustomer surname : " + custom.surname + "\nMail Adress : " + custom.mailAdress + "\nDate Of Birth : " + custom.dateOfBirth + "\nPhone number : " + custom.phoneNumber);


            //foreach (string info in information)
            //{
            //    Console.WriteLine(info);
            //}

            Console.WriteLine("Listed");
        }
        public void deleteCustomer(Customer customer)
        { 
            customer.mailAdress = " ";
            customer.dateOfBirth = "";
            customer.phoneNumber = "";
            Console.WriteLine(customer.Id +"  :  "+ customer.name + "" + customer.surname 
                + " deleted on the system.");
            customer.name = " ";
            customer.surname = " ";
            customer.Id = "";
        }
        //public void finance(Customer customer)
        
    }
}
