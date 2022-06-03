using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Halil", LastName = "Adiguzel", City = "Istanbul" };
            Customer customer2 = new Customer();
            

        }
    }
    class Customer
    {
        public Customer()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
