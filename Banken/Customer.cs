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
       
        public List<Transaction> transactions = new List<Transaction>();
        public string ShowCustomer { get { return Name; } } //This method returns the name of the customer
        public void AddBalance(int value)
        {
            Transaction t = new Transaction();
            t.value = value;
            t.time = DateTime.Now;
            transactions.Add(t);
        }
        public void RemoveBalance(int value)
        {
            Transaction t = new Transaction();
            t.value = -1* value;
            t.time = DateTime.Now;
            transactions.Add(t);
        }
        public int Balance()
        {
            int sum = 0;
            foreach (Transaction t in transactions)
            {
                sum += t.value;
            }
            return sum;
        }
        public string ShowTransactions()
        {
            string str = "";
            foreach(Transaction t in transactions)
            {
                str += (t.time + " " + t.value + " kr") + Environment.NewLine;
            }
            return str;
        }
    }
}
