using System;

namespace Assignment_II
{
    class Flight
    {
        int id;
        string origin;
        string destination;
        DateTime date;

        public Flight(int id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public bool SearchFlight(int id)
        {
            if (this.id == id)
                return true;

            return false;
        }

        public override string ToString()
        {
            return id + ", from " + origin + " to " + destination + ", " + date.ToString("dd/MM/yyyy");
        }
    }
}
