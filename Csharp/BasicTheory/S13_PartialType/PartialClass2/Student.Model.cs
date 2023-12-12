using System;
namespace PartialClass
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Major { get; set; }
        public string Specialization { get; set; }
    }
}