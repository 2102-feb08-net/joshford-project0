using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Library;

namespace joshford_project0
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Let do this thing
            bool validID = false;           
            bool validResponse = false;     
            string newOrReturn;             
            string customerFirstName;       
            string customerLastName;             
            int customerID = 0;             
            int employeeID = 0;             
            int storeID = 0;                

            // Database Connection is established
            DataAccess_Library dataAccess = new DataAccess_Library();
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            // User Interface Begins
            Console.WriteLine("\tWelcome to Rise 'N Grind Cafe!");
            Console.WriteLine("Are you a first time customer?");

            do
            {
                Console.WriteLine("Please enter 'Y' or 'N'");
                newOrReturn = Console.ReadLine().ToUpper();

                if (newOrReturn != "Y" || newOrReturn != "N")
                {
                    Console.WriteLine("Invalid Response");
                }

                else
                {
                    validResponse = true;
                }

            } while (!validResponse);

            // Returning customer will input ID for ID validation
            // New customer will input name, and receive a customer ID
            if (newOrReturn == "Y")
            {
                Console.WriteLine("Please enter customer ID: ");
                customerID = int.Parse(Console.ReadLine());
                do
                {
                    CustomerValidate customerToValidate = new CustomerValidate();
                    if (customerToValidate.ValidateID(customerID))
                    {
                        validID = true;
                    }

                    else
                    {
                        throw new ArgumentException("Invalid ID entered.");
                        Console.WriteLine("Please enter valid customer ID: ");
                        customerID = int.Parse(Console.ReadLine());
                    }
                } while (!validID);
                    
            }

            else
            {
                // New Customer enters first and last name for record keeping
                Console.WriteLine("Please enter your first name: ");
                customerFirstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                customerLastName = Console.ReadLine();

                validID = true;
            }


            if (validID)
            {
                // Customer UI Initiation
                // UI will handle Customer interaction(Print menu, get customer
                //  order, retrieve history, etc.)
                // LINQ SQL Queries will handle input data
            }
            
        }
    }
}
