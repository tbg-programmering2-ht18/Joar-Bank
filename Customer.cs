using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        
        public string name { get; set; }
        public int balance { get; set; }

            public static void showCustomer() // funktion för att visa alla användare
            {
                int count = 0;
                    foreach (var Customer in Program.customerbalance)
                    {
                        count = count + 1;
                        Console.WriteLine("User " + count + ": " + Customer.name);
                    }

            }

    }
}
