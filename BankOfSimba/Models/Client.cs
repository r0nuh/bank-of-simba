using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class Client
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public bool King { get; set; }

        public Client(string name, double balance, string animal, bool king = false)
        {
            Name = name;
            Balance = balance;
            AnimalType = animal;
            Currency = "€coin";
            King = King;
        }
    }
}
