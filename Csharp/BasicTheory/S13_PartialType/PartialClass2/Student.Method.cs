namespace PartialClass
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({DateOfBirth.ToShortDateString()})";
        }
    }
}