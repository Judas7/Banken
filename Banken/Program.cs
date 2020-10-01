using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banken
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {


            int choice = 0; //The variable "choice" is set to 0 
            while (choice !=7) //As long as the user doesn't choose number 7 the program will keep on running.
            {
                choice = SelectMenuItem(); //
                switch (choice)
                {
                    case 1:
                        AddCustomer(); //If the user chooses 1 they get to add a customer
                        break;
                    case 2:
                        ShowAllCustomers(); //This shows all the existing customers
                        RemoveCustomer(); //If the uses chooses 2 they get to remove a customer
                        break;
                    case 3:
                        ShowAllCustomers(); 
                        break;
                    case 4:
                        ShowAllCustomers();
                        ShowBalance(); //If the user chooses 4 they get to see a customers balance
                        break;
                    case 5:
                        ShowAllCustomers();
                        AddBalance(); //If the user chooses 5 they get to transfer money to a customer
                        break;
                    case 6:
                        ShowAllCustomers();
                        WithdrawBalance(); //If the use chooses 6 they get to withdraw money from a customer
                        break;
                    case 7:
                        Console.WriteLine("Du valde att avsluta programmet. Klicka enter för att stänga ner."); //If the user choses 7 the program turns off
                        break;
                }
            }

            
            Console.ReadLine();
        }

        private static void WithdrawBalance() //This function is used for withdrawing money from a specific user
        {
            Console.WriteLine("Välj vilken kund du vill göra ett uttag från: "); //The user is asked which customer they want to withdraw money from
            int i = int.Parse(Console.ReadLine()); //The number of the customer the user wants to withdraw money from is stored in the variable "i"
            Console.WriteLine("Hur mycket pengar vill du ta ut"); //The user gets asked how much money they want to withdraw
            int withdraw = int.Parse(Console.ReadLine()); //The amount that the user wants to withdraw from a customer gets stored in the variable "withdraw". It also converts the answer to a integer
            if (customers[i].Balance < withdraw ) //If the user wants to withdraw more money than the customer has in the bank they have to try again
            {
                Console.WriteLine("Du kan inte ta ut mer än vad du har på kontot!");
            }
            else
            {
                customers[i].Balance = customers[i].Balance - withdraw; //The chosen customers balance gets subtracted with the amount the user wanted to withdraw
            }
            
        }

        private static void AddBalance() //This function is used for adding balance to a specific customer
        {
            Console.WriteLine("Välj vilken kund du vill göra en insättning till: "); //The user is asked which customer they want to add money to
            int i = int.Parse(Console.ReadLine()); //The number of the customer that the user wants to add money to gets stored in the variable "i"
            Console.WriteLine("Hur mycket pengar vill du sätta in"); //The user gets asked how much money they want to add
            int transfer = int.Parse(Console.ReadLine()); //The amount of money that the user wants to add gets stored in the variable "transfer". Aswell as converting the answer to a integer
            customers[i].Balance = customers [i].Balance +transfer; //The chosen customers balance gets added by the amount
        }

        private static void ShowBalance() //This function is used for seeing the balance of a customer
        {
            Console.WriteLine("Välj vilken kunds saldo du vill se: "); //Which customers balance does the user want to see
            int i = int.Parse(Console.ReadLine()); 
            Console.WriteLine(customers[i].Name + " har:" + customers[i].Balance + " kr"); //The chosen customers name and balance is written out.
        }

        private static void RemoveCustomer() //This function allows the user to remove a customer
        {
            Console.Write("Ange vem du vill ta bort: "); //Which customer does the user want to remove?
            int i = int.Parse(Console.ReadLine());
            customers.RemoveAt(i); //Removes the customer with the index that the user chose from the customers list. 
            Console.WriteLine("Du tog bort en användare"); 
        }

        private static void AddCustomer() //This function is used to add a new customer
        {
            Customer customer = new Customer(); //This creates a empty customer
            Console.Write("Ange ditt namn: "); //What is the name of the customer?
            customer.Name = Console.ReadLine(); //Here the new customer gets its name
            Console.WriteLine("Du la till en ny användare");
            customers.Add(customer); //The new customer is added to the list
        }

        private static void ShowAllCustomers() //This function shows all the existing customers
        {
            Console.WriteLine("Du valde att se alla användare");
            for (int i = 0; i < customers.Count(); i++) //As long as i is less than the amount of customers in the list this will loop
            {
                Console.WriteLine(i + ": " + customers[i].ShowCustomer); //For each loop this writes out a customer and its number. 
            }
        }

        private static int SelectMenuItem() //This function contains the different menu options you have 
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Välkommen till Banken!");
            Console.WriteLine("");
            Console.WriteLine("Ange vilket av följande alternativ du vill göra");
            Console.WriteLine("");
            Console.WriteLine("1: Lägg till en användare");
            Console.WriteLine("2: Ta bort en användare");
            Console.WriteLine("3: Visa alla befintliga användare");
            Console.WriteLine("4: Visa saldo");
            Console.WriteLine("5: Gör en insättning");
            Console.WriteLine("6: Gör ett uttag");
            Console.WriteLine("7: Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("Skriv ditt val:");
            string c = Console.ReadLine(); //The choice is stored in the variable "c"
            int choice = int.Parse(c); //The value of "c" is transfered to "choice" and converted to a int
            return choice;

        }
    }
}
