using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    class Program
    {
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = DataAccess_Library.OpenDatabaseConnection();

        public static void Main(string[] args)
        {
            // Let do this thing
            bool validID = false;
            bool validResponse = false;
            string newOrReturn;
            int menuOptions = 16;
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
                    Console.WriteLine("\tInvalid Input.");
                    Console.WriteLine("\tPlease select option from menu below");
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
                        Console.WriteLine("\tInvalid customer ID entered.");
                        Console.WriteLine("\tPlease enter a valid customer ID: ");
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
                    Console.WriteLine("\tPlease enter a valid name: ");
                    customerFirstName = Console.ReadLine();
                }

                Console.WriteLine("\tPlease enter your last name: ");
                customerLastName = Console.ReadLine();
                while (!customerToValidate.ValidateName(customerLastName))
                {
                    Console.WriteLine("\tName cannot contain spaces");
                    Console.WriteLine("\tPlease enter a valid name: ");
                    customerLastName = Console.ReadLine();
                }

                CustomerC customerToAdd = new CustomerC();
                customerToAdd.AddNewCustomer(customerFirstName, customerLastName);
                /*
                if (customerToValidate.ValidateID(customerToAdd.CustID))
                {
                    validID = true;
                }
                else
                {
                    Console.WriteLine("--Customer Creation Error");
                    validID = false;
                }
                */
                
            }

            // Create Customer Object
            CustomerC customer = new CustomerC(customerID);

            try
            {
                string menuSelection;

                do
                {
                    // Customer UI Initiation
                    OrderC order = new OrderC(customerID, employeeID, storeID);
                    Console.WriteLine("\t*******************");
                    Console.WriteLine("\t*   Order Menu    *");
                    Console.WriteLine("\t*******************");
                    Console.WriteLine("\t*A: Add Item to Order\n\t*E: Exit");
                    menuSelection = Console.ReadLine().ToUpper();
                    while (menuSelection != "A" && menuSelection != "E")
                    {
                        Console.WriteLine("\tInvalid Menu Selection.");
                        Console.WriteLine("\tPlease choose from the following:");
                        Console.WriteLine("\t*A: Add Item to Order\n\t*E: Exit");
                        menuSelection = Console.ReadLine().ToUpper();
                    }

                    if (menuSelection == "A")
                    {
                        Console.WriteLine("*******************");
                        Console.WriteLine("*      Menu       *");
                        Console.WriteLine("*******************");
                        OrderC.PrintMenu();
                        menuSelection = Console.ReadLine();
                        while (menuOptions < int.Parse(menuSelection) && int.Parse(menuSelection) < 0)
                        {
                            Console.WriteLine("\tInvalid Menu Selection");
                            Console.WriteLine("\tPlease select from the following:");
                            OrderC.PrintMenu();
                            menuSelection = Console.ReadLine();
                        }
                        var productSelection = OrderC.GetProductSelection(menuSelection);
                        if (productSelection.GetType().Equals(CoffeeTypes.Regular))
                        {
                            order.AddProductToOrder((CoffeeTypes) productSelection, 1);
                        }
                        else
                        {
                            order.AddProductToOrder((FoodTypes) productSelection, 1);
                        }
                    }
                    else if(menuSelection == "E")
                    {
                        Console.WriteLine("Thanks for stopping by!");
                    }
                    // Validation should prevent
                    else
                    {
                        Console.WriteLine("Applcation Closed due to validation error.");
                    }

                    order.PrintCurrentOrder();

                } while (menuSelection != "E");
            }
            catch (ApplicationException)
            {
                throw new ApplicationException("\tFatal Internal Error.\n\tExiting...");
            }
            
        }
    }
}
