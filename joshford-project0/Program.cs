using System;

namespace joshford_project0
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool validID = false;           // ID Validation boolean
            bool validResponse = false;     // User input validation boolean
            string firstOrReturn;           // User input for new or returning customer
            string customerFirstName;       // Stores first name of new customer
            string customerLastName;        // Stores last name of new customer     
            int customerID = 0;             // Stores the ID of customer
            int employeeID = 0;             // Stores the ID of employee, for order information
            int storeID = 0;                // Stores the ID of the store the order was placed

            // User Interface Begins
            Console.WriteLine("\tWelcome to Rise 'n Grind: Online!");
            Console.WriteLine("Are you a first time customer?");

            do
            {
                Console.WriteLine("Please enter 'Y' or 'N'");
                firstOrReturn = Console.ReadLine().ToUpper();

                if (firstOrReturn != "Y" || firstOrReturn != "N")
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
            if (firstOrReturn == "Y")
            {
                Console.WriteLine("Please enter customer ID: ");
                customerID = int.Parse(Console.ReadLine());

                CustomerValidate customerToValidate = new CustomerValidate();

                // Temporary validation
                if(customerToValidate.ValidateID(customerID))
                {
                    validID = true;
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

            }
            
        }
    }
}
