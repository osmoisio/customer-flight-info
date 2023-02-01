namespace Assignment_II
{
    class Customer
    {
        string name;
        int id;
        int flightId;

        public Customer(string name, int id, int flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }

        public bool SearchCustomer(int id)
        {
            if (this.id == id)
                return true;

            return false;
        }

        public override string ToString()
        {
            return name + ", " + id + ", " + flightId;
        }

        public int GetFlightId()
        {
            return flightId;
        }
    }
}
