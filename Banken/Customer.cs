using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Customer //This is like a box for every customer that contains their name and how much money they have in the bank
    {
        public string Name { get; set; } //This stores the name of the customer
        public int Balance { get; set; } //This stores the balance of the customer
        public string ShowCustomer { get { return Name; } } //This method returns the name of the customer
    }
}
