namespace P01_AutoProperty
{
    using static System.Console;
    /// <summary>
    /// sách điện tử
    /// </summary>
    class Book
    {
        public int Id { get; protected set; } = 1;
        /// <summary>
        /// tên tác giả/ nhóm tác giả
        /// </summary>
        public string Authors { get; set; } = "Unknown author";
        /// <summary>
        /// tiêu đề
        /// </summary>
        public string Title { get; set; } = "A new book";
        /// <summary>
        /// nhà xuất bản
        /// </summary>
        public string Publisher { get; set; } = "Unknown publisher";
        /// <summary>
        /// năm xuất bản
        /// </summary>
        public int Year { get; set; } = 2018;
        /// <summary>
        /// thông tin mô tả
        /// </summary>
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            // lệnh này lỗi, vì setter của Id là protected
            // chỉ có thể gán giá trị cho Id từ trong class
            // không thể gán giá trị từ ngoài class
            //book.Id = 2;
            book.Authors = "Christian Nagel";
            book.Title = "Professional C# 7 and .NET Core";
            book.Publisher = "Wrox";
            book.Year = 2018;
            book.Description = "The best book ever about the new C# 7 and the .NET Core";
            WriteLine($"{book.Authors}, {book.Title}, - {book.Publisher}, {book.Year}");
            ReadKey();
        }
    }
}