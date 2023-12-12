namespace P00_PropertyWithBackedField
{
    using static System.Console;
    /// <summary>
    /// sách điện tử
    /// </summary>
    internal class Book
    {
        private int _id = 1;
        private string _authors = "Unknown author";
        private string _title = "A new book";
        private string _publisher = "Unknown publisher";
        private int _year = 2018;
        private string _description;
        public int Id
        {
            get { return _id; }
            protected set {
                _id = value;
            }
        }
        /// <summary>
        /// tên tác giả/ nhóm tác giả
        /// </summary>
        public string Authors
        {
            get { return _authors; }
            set {
                _authors = value;
            }
        }
        /// <summary>
        /// tiêu đề
        /// </summary>
        public string Title
        {
            get { return _title; }
            set {
                _title = value;
            }
        }
        /// <summary>
        /// nhà xuất bản
        /// </summary>
        public string Publisher
        {
            get { return _publisher; }
            set {
                _publisher = value;
            }
        }
        /// <summary>
        /// năm xuất bản
        /// </summary>
        public int Year
        {
            get { return _year; }
            set {
                _year = value;
            }
        }
        /// <summary>
        /// thông tin mô tả
        /// </summary>
        public string Description
        {
            get { return _description; }
            set {
                _description = value;
            }
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
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