using System;

namespace joshford_project0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validID = false;
            string visitorInfo;
            int custID = 0;
            int emplID = 0;
            int storeID = 0;

            Console.WriteLine("Hello! Welcome to Rise 'n Grind: Online!");
            Console.WriteLine("Are you a customer or employee?");
            Console.WriteLine("Please enter customer or employee: ");
            visitorInfo = Console.ReadLine().ToLower();

            if(visitorInfo == "c" || visitorInfo == "customer")
            {
                Console.WriteLine("Please enter customer ID: ");
                custID = int.Parse(Console.ReadLine());


                // validID = validation.CustomerValidate(custID);
            }
            else
            {

            }

        }
    }
}
