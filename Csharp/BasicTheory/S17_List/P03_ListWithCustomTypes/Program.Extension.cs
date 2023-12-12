using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Sorted by age:");
            Print(Sort(people, "age"));
            Console.WriteLine("Sorted by name:");
            Print(Sort(people, "name"));
            Console.WriteLine("Leaders younger than 20");
            Print(GetYoungLeaders(people, 20));
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
        static List<Person> Sort(List<Person> people, string criteria)
        {
            if (criteria.ToLower().Equals("age"))
                return people.OrderBy(p => p.Age).ToList();
            if (criteria.ToLower().Equals("name"))
                return people.OrderBy(p => p.Name).ToList();
            return people;
        }
        static List<Person> GetYoungLeaders(List<Person> people, int age)
        {
            return people.Where(p => p.Age <= age).ToList();
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