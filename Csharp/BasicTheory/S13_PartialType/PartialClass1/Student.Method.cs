namespace PartialMethod
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({DateOfBirth.ToShortDateString()})";
        }
        private void CheckName(string value)
        {
            var temp = value.Trim();
            if (string.IsNullOrEmpty(temp) || temp.Contains(" "))
                throw new System.Exception("Tên sai quy cách");
        }
        partial void OnSettingFirstName(string value)
        {
            CheckName(value);
        }
        partial void OnSettingLastName(string value)
        {
            CheckName(value);
        }
    }
}