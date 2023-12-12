using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace P04_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SortedList";
            var people = CreateAddressBook();
            Print(people);
            Console.ReadKey();
        }
        static void Print(SortedList<string, Person> people)
        {
            Console.WriteLine($"People in the list: {people.Count}");
            foreach (var key in people.Keys)
            {
                Console.WriteLine($"-{people[key].Name}");
            }
            Console.WriteLine("\r\nContact details");
            foreach (var p in people)
            {
                Console.WriteLine($"-{p.Value.Name}, born {p.Value.DateOfBirth.ToShortDateString()}, contact: {p.Value.Email}, {p.Value.Phone}");
            }
        }
        static SortedList<string, Person> CreateAddressBook()
        {
            var addressBook = new SortedList<string, Person>
            {
                {"trump", new Person { Name = "Donald Trump", DateOfBirth = new DateTime(1990, 1, 1), Email = "trump@gmail.com", Phone = "01234.567.890"} },
                {"putin", new Person { Name = "Vladimir Putin", DateOfBirth = new DateTime(1990, 1, 2), Email = "putin@gmail.com", Phone = "01234.567.890"} },
                {"macron", new Person { Name = "Emmanuel Macron", DateOfBirth = new DateTime(1990, 1, 3), Email = "macron@gmail.com", Phone = "01234.567.890"} },
                {"merkel", new Person { Name = "Angela Merkel", DateOfBirth = new DateTime(1990, 1, 4), Email = "merkel@gmail.com", Phone = "01234.567.890"} },
            };
            addressBook.Add("may", new Person { Name = "Theresa May", DateOfBirth = new DateTime(1990, 1, 5), Email = "may@gmail.com", Phone = "01234.567.890" });            
            return addressBook;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}