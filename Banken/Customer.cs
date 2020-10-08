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
        public void AddBalance(int value) //This function adds the transfer to the specific customers transaction list with date and time of the transfer
        {
            Transaction t = new Transaction();
            t.value = value;
            t.time = DateTime.Now;
            transactions.Add(t);
        }
        public void RemoveBalance(int value) //This function adds the withdrawal to the specific customers transacion list with date and time of the withdrawal
        {
            Transaction t = new Transaction();
            t.value = -1* value;
            t.time = DateTime.Now;
            transactions.Add(t);
        }
        public int Balance() //This function calculates the customers balance
        {
            int sum = 0;
            foreach (Transaction t in transactions)
            {
                sum += t.value;
            }
            return sum;
        }
        public string ShowTransactions() //This function shows the transaction history of a customer
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
