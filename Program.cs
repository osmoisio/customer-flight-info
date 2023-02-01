using System;

namespace Assignment_II
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2023, 1, 24);
            DateTime date2 = new DateTime(2023, 2, 12);
            DateTime date3 = new DateTime(2023, 3, 7);

            //Initializing customers and flights
            Customer customer1 = new Customer("Customer1", 1, 100);
            Flight flight1 = new Flight(100, "Vaasa", "Helsinki", date1);

            Customer customer2 = new Customer("Customer2", 2, 200);
            Flight flight2 = new Flight(200, "Helsinki", "Oulu", date2);

            Customer customer3 = new Customer("Customer3", 3, 300);
            Customer customer4 = new Customer("Customer4", 4, 300);
            Flight flight3 = new Flight(300, "Stockholm", "Helsinki", date3);

            //Adding customer and flight objects to arrays
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            Flight[] flights = new Flight[] { flight1, flight2, flight3 };

            //We use CustomerFlightHandler class where we have the search methods
            CustomerFlightHandler customerFlightHandler = new CustomerFlightHandler(customers, flights);

            //User can decide if they want to search customer or flight information, or quit the program
            string input = "";
            int userChoice = 0;
            bool correctInput = false;
            Console.WriteLine("Search for customer with id (1) or flight with id (2) or quit program (0):");
            do
            {
                try
                {
                    input = Console.ReadLine();
                    userChoice = int.Parse(input);
                    while (userChoice != 1 && userChoice != 2 && userChoice != 0)
                    {
                        Console.WriteLine("Please input 1, 2 or 0:");
                        input = Console.ReadLine();
                        userChoice = int.Parse(input);
                    }
                    correctInput = true;
                }
                catch (Exception)
                {
                    Console.WriteLine(input + " is not valid input!");
                    correctInput = false;
                }
            } while (!correctInput);

            //Program will keep running until user inputs 0
            while (userChoice != 0)
            {
                switch (userChoice)
                {
                    //Switch cases for searching for customer and flight information
                    case 1:
                        try
                        {
                            Console.WriteLine("Search customer information with id:");
                            input = Console.ReadLine();
                            int customerId = int.Parse(input);
                            Console.WriteLine(customerFlightHandler.SearchCustomer(customerId));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(input + " is not valid input!");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Search flight information with id:");
                            input = Console.ReadLine();
                            int flightId = int.Parse(input);
                            Console.WriteLine(customerFlightHandler.SearchFlight(flightId));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(input + " is not valid input!");
                        }
                        break;
                }

                //Ask for input again
                Console.WriteLine("Search for customer with id (1) or flight with id (2) or quit program (0):");
                do
                {
                    try
                    {
                        input = Console.ReadLine();
                        userChoice = int.Parse(input);
                        while (userChoice != 1 && userChoice != 2 && userChoice != 0)
                        {
                            Console.WriteLine("Please input 1, 2 or 0:");
                            input = Console.ReadLine();
                            userChoice = int.Parse(input);
                        }
                        correctInput = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(input + " is not valid input!");
                        correctInput = false;
                    }
                } while (!correctInput);
            }
        }
    }
}
