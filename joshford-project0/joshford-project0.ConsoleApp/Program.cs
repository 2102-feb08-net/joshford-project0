using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    class Program
    {
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions;

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
            using var context = new joshfordproject0Context(s_dbContextOptions);

            // User Interface Begins
            Console.WriteLine("\t**********************************");
            Console.WriteLine("\t* Welcome to Rise 'N Grind Cafe! *");
            Console.WriteLine("\t**********************************");
            Console.WriteLine("\t*N: New Customer\n\t*S: Sign In");

            do
            {
                newOrReturn = Console.ReadLine().ToUpper();

                if (newOrReturn != "N" && newOrReturn != "S")
                {
                    Console.WriteLine("Invalid Input.");
                    Console.WriteLine(" Please select option from menu below");
                    Console.WriteLine("\t*N: New Customer\n\t*S: Sign In");
                }

                else
                {
                    validResponse = true;
                }

            } while (!validResponse);

            // Returning customer will input ID for ID validation
            // New customer will input name, and receive a customer ID
            if (newOrReturn == "S")
            {
                CustomerValidate customerToValidate = new CustomerValidate();

                Console.WriteLine("Please enter customer ID: ");
                customerID = int.Parse(Console.ReadLine());
                do
                {
                    if (customerToValidate.ValidateID(customerID))
                    {
                        validID = true;
                    }

                    else
                    {
                        Console.WriteLine("Invalid customer ID entered.");
                        Console.WriteLine("Please enter a valid customer ID: ");
                        customerID = int.Parse(Console.ReadLine());
                    }
                } while (!validID);
                    
            }

            else
            {
                CustomerValidate customerToValidate = new CustomerValidate();

                // New Customer enters first and last name for record keeping
                Console.WriteLine("\t--New Customer Information--");
                Console.WriteLine("\tPlease enter your first name: ");
                customerFirstName = Console.ReadLine();
                while (!customerToValidate.ValidateName(customerFirstName))
                {
                    Console.WriteLine("\tName cannot contain spaces");
                    Console.WriteLine("\tPlease enter a valid name");
                    customerFirstName = Console.ReadLine();
                }

                Console.WriteLine("\tPlease enter your last name: ");
                customerLastName = Console.ReadLine();
                while (!customerToValidate.ValidateName(customerLastName))
                {
                    Console.WriteLine("\tName cannot contain spaces");
                    Console.WriteLine("\tPlease enter a valid name");
                    customerLastName = Console.ReadLine();
                }

                Customer customerToAdd = new Customer();

                customerToAdd.AddNewCustomer(customerFirstName, customerLastName);

                validID = true;
            }

            // Create Customer Object
            Customer customer = new Customer(customerID);

            Console.WriteLine("Make UI Now");

            if (validID)
            {
                // Customer UI Initiation
                Order order = new Order(customerID, employeeID, storeID);


                // UI will handle Customer interaction(Print menu, get customer
                //  order, retrieve history, etc.)
                // LINQ SQL Queries will handle input data
            }
            
        }
    }
}
