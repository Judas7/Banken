using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Customer> Customers = new List<Customer>();
        static void Main(string[] args)
        {
            SelectMenuItem();
        }

        private static void SelectMenuItem()
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
        }
    }
}
