using System;
using System.Collections.Generic;
using System.Text;

namespace BankSimulation
{
    public class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mailAdress { get; set; }
        public int dateOfBirth { get; set; }
        public ulong Id { get; set; }
        public ulong phoneNumber { get; set; }

    }
}
