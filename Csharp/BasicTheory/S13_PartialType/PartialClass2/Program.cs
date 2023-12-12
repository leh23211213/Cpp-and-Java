namespace PartialClass
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Id = 1,
                FirstName = "Donald",
                LastName = "Trump",
                DateOfBirth = new System.DateTime(1990, 12, 31),
                Major = "Computer Science",
                Specialization = "Information Systems"
            };
            WriteLine(student);
            ReadKey();
        }
    }
}