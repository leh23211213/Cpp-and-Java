namespace P01_DefaultConstructor
{
    using static System.Console;
    internal class Book
    {
        private string _authors;
        private string _title;
        private int _year;
        private string _publisher;
        public Book() // đây là một hàm tạo của class Book
        {
            _authors = "Unknown author";
            _title = "A new book";
            _publisher = "Unknown publisher";
            _year = 2019;
        }
        public Book(string author, string title, int year, string publisher) // đây là hàm tạo có tham số
        {
            _authors = author;
            _title = title;
            _year = year;
            _publisher = publisher;
        }
        public string Authors { get => _authors; set => _authors = value; }
        public string Title { get => _title; set => _title = value; }
        public int Year { get => _year; set => _year = value; }
        public string Print()
        {
            return $"{_authors}, \"{_title}\", -{_publisher}, {_year}";
        }

    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            var book1 = new Book();
            WriteLine(book1.Print());
            var book2 = new Book("Christian Nagel", "Professional C# 7 and the .NET core 2.0", 2018, "Wrox");
            WriteLine(book2.Print());
            var book3 = new Book
            {
                Authors = " Chiristinal Nagel",
            Title = "Professional C# 8 and the .NET core 2.0",
                Year = 2018
            };
        WriteLine(book3.Print());
    }
}
}