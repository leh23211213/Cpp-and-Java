using System;
using System.Collections.Generic;
namespace P03_ListWithCustomTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "List with custom type";
            var people = Initialize();
            people.Add(new Person { Name = "Theresa May", Age = 22, Country = Country.UK });
            Console.WriteLine("World leaders:");
            Print(people);
            Console.ReadKey();
        }
        static List<Person> Initialize()
        {
            var people = new List<Person> {
                new Person { Name = "Donald Trump", Age = 18, Country = Country.US },
                new Person { Name = "Vladimir Putin", Age = 19, Country = Country.RU },
                new Person { Name = "Angela Merkel", Age = 20, Country = Country.DE },
                new Person { Name = "Emmanuel Macron", Age = 21, Country = Country.FR },
            };
            return people;
        }
        static void Print(List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine($"- {p.Name}, {p.Age} years old, from {p.Country}");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Country Country { get; set; }
    }
    enum Country
    {
        RU, VI, UK, US, DE, FR
    }
}