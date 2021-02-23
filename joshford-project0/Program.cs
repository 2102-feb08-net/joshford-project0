using System;
using System.Linq;
using System.Collections.Generic;

namespace joshford_project0
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool validID = false;           // ID Validation boolean
            bool validResponse = false;     // User input validation boolean
            string newOrReturn;           // User input for new or returning customer
            string customerFirstName;       // Stores first name of new customer
            string customerLastName;        // Stores last name of new customer     
            int customerID = 0;             // Stores the ID of customer
            int employeeID = 0;             // Stores the ID of employee, for order information
            int storeID = 0;                // Stores the ID of the store the order was placed

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

                CustomerValidate customerToValidate = new CustomerValidate();

                if(customerToValidate.ValidateID(customerID))
                {
                    validID = true;
                    Customer rCustomer = new Customer(customerID, storeID);
                }

                else
                {
                    Console.WriteLine("Invalid ID");
                }
                    
            }

            else
            {
                // New Customer enters first and last name for record keeping
                Console.WriteLine("Please enter your first name: ");
                customerFirstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                customerLastName = Console.ReadLine();

                Customer nCustomer = new Customer(customerFirstName, customerLastName);

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
