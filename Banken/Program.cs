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


            int choice = 0;
            while (choice !=7)
            {
                choice = SelectMenuItem();
                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ShowAllCustomers();
                        RemoveCustomer();
                        break;
                    case 3:
                        ShowAllCustomers();
                        break;
                    case 4:
                        ShowAllCustomers();
                        ShowBalance();
                        break;
                    case 5:
                        ShowAllCustomers();
                        AddBalance();
                        break;
                    case 6:
                        ShowAllCustomers();
                        WithdrawBalance();
                        break;
                    case 7:
                        Console.WriteLine("Du valde att avsluta programmet. Klicka enter för att stänga ner.");
                        break;
                }
            }

            
            Console.ReadLine();
        }

        private static void WithdrawBalance()
        {
            Console.WriteLine("Välj vilken kund du vill göra ett uttag från: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket pengar vill du ta ut");
            int withdraw = int.Parse(Console.ReadLine());
            if (customers[i].Balance < withdraw )
            {
                Console.WriteLine("Du kan inte ta ut mer än vad du har på kontot!");
            }
            else
            {
                customers[i].Balance = customers[i].Balance - withdraw;
            }
            
        }

        private static void AddBalance()
        {
            Console.WriteLine("Välj vilken kund du vill göra en insättning till: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket pengar vill du sätta in");
            int transfer = int.Parse(Console.ReadLine());
            customers[i].Balance = customers [i].Balance +transfer;
        }

        private static void ShowBalance()
        {
            Console.WriteLine("Välj vilken kunds saldo du vill se: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(customers[i].Name + " har:" + customers[i].Balance + " kr");
        }

        private static void RemoveCustomer()
        {
            Console.Write("Ange vem du vill ta bort: ");
            int i = int.Parse(Console.ReadLine());
            customers.RemoveAt(i);
            Console.WriteLine("Du tog bort en användare");
        }

        private static void AddCustomer()
        {
            Customer customer = new Customer();
            Console.Write("Ange ditt namn: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Du la till en ny användare");
            customers.Add(customer);
        }

        private static void ShowAllCustomers()
        {
            Console.WriteLine("Du valde att se alla användare");
            for (int i = 0; i < customers.Count(); i++)
            {
                Console.WriteLine(i + ": " + customers[i].ShowCustomer);
            }
        }

        private static int SelectMenuItem()
        {
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
            string c = Console.ReadLine();
            int choice = int.Parse(c);
            return choice;

        }
    }
}
