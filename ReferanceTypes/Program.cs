using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi1: "+ sayi1);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Halil";
            person2 = person1;
            person1.FirstName = "Ibrahim";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            Employee employee = new Employee();



            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
