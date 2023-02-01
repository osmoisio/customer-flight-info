using System;
using System.Text;

namespace Assignment_II
{
    class CustomerFlightHandler
    {
        Customer[] customers;
        Flight[] flights;

        public CustomerFlightHandler(Customer[] customers, Flight[] flights)
        {
            this.customers = customers;
            this.flights = flights;
        }

        public String SearchCustomer(int id)
        {
            StringBuilder searchResult = new StringBuilder();

            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].SearchCustomer(id))
                {
                    searchResult.AppendLine(customers[i].ToString());

                    for (int j = 0; j < flights.Length; j++)
                    {
                        if (flights[j].SearchFlight(customers[i].GetFlightId()))
                        {
                            searchResult.AppendLine(flights[j].ToString());
                        }
                    }
                }
            }

            if (searchResult.Length == 0)
                return "Customer with id " + id + " not found!";

            return searchResult.ToString();
        }

        public String SearchFlight(int id)
        {
            StringBuilder searchResult = new StringBuilder();

            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].SearchFlight(id))
                {
                    searchResult.AppendLine(flights[i].ToString());
                }
            }

            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].GetFlightId() == id)
                {
                    searchResult.AppendLine(customers[i].ToString());
                }
            }

            if (searchResult.Length == 0)
                return "Flight with id " + id + " not found!";

            return searchResult.ToString();
        }

    }

}
