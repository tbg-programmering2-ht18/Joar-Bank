using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        //Skapar en lista för customer
        public static List<Customer> customerbalance = new List<Customer>();
        

        static void Main(string[] args)
        {

            /*
           Customer customerbalance1 = new Customer();
           Customer customerbalance2 = new Customer();
           Customer customerbalance3 = new Customer(); */

            Console.WriteLine("Welcome to JorreCapitalBank!");

            Console.WriteLine("");
            Console.WriteLine("Choose one of the following options.");
            Console.WriteLine("");
            while (true) // evighetsloop för programmet
            {
                Console.WriteLine("1 : Add customer");
                Console.WriteLine("2 : Show customer");
                Console.WriteLine("3 : Remove customer from bank");
                Console.WriteLine("4 : Exit bank");
                Console.WriteLine("");
                Console.Write("Write your choice: ");
                string answer = Console.ReadLine();
                try
                {
                    switch (answer)
                    {
                        // case 1 lägger till användare i banken
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Add customer");
                            AddCustomer();
                            Console.Clear();
                            break;
                        // case 2 visar befintliga användare
                        case "2":
                            Console.Clear();
                            foreach (var Customer in customerbalance)
                            {
                                Console.WriteLine("User: {0}", Customer.name);
                            }
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        //case 3 tar bort användare för banken
                        case "3":

                            Console.Clear();
                            Customer.showCustomer();
                            Console.WriteLine("");
                            Console.Write("Which customer do you want to remove: ");
                            DeleteCustomer();
                            Console.Clear();
                            break;
                        case "4":
                            Console.Clear();

                            break;
                        default:
                            throw new Exception();

                    
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error, Try using number that exist");
                    Console.ReadKey();
                    Console.Clear();
                }


            }




            Console.ReadKey();

        }


        public static void AddCustomer() // funktion för att lägga till användare
        {
            Console.WriteLine("");
            Console.Write("Name of customer: ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.name = name;
            customerbalance.Add(customer);


        }


        public static void DeleteCustomer() // funktion för att ta bort användare 
        {
            int retrieve = 1;
            retrieve = Convert.ToInt32(Console.ReadLine());
            int counting = 1;
            foreach (var customer in customerbalance)
                  {
                    if (retrieve == counting)
                        {
                           customerbalance.Remove(customer);
                           break;
                        }
                    counting++;
                  }
        }






    }
}