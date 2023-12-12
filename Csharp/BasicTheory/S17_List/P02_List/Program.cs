using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace P02_List
{
    class Program
    {
        static void CreateInitialize()
        {
            // khởi tạo danh sách trống, các phần tử phải có kiểu int
            var list1 = new List<int>();
            Print(list1, "List of Ints");
            // khai báo và khởi tạo danh sách có thể chứa ngay 3 phần tử, các phần tử phải có kiểu string
            var list2 = new List<string>(3);
            Print(list2, "List of Strings");
            // khai báo và khởi tạo danh sách ký tự, đồng thời cung cấp luôn dữ liệu ban đầu
            var list3 = new List<char>(new[] { 'a', 'b', 'c', 'd' });
            Print(list3, "List of Chars");
            // khai báo và khởi tạo sử dụng cú pháp object initialization
            var list4 = new List<int> { 1, 2, 3, 4, 5 };
            Print(list4, "List of Ints");
        }
        static void Print<T>(List<T> list, string label)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{label}: ");
            Console.ResetColor();
            if (list.Count == 0)
                Console.Write("EMPTY!");
            // duyệt danh sách và in các phần tử ra console
            foreach (object item in list)
            {
                Console.Write($"{item}    ");
            }
            // hoặc
            //for (var i = 0; i < list.Count; i++)
            //{
            //    Console.Write($"{list[i]}\t");
            //}
            Console.WriteLine();
        }
        static void Access()
        {
            Console.WriteLine("# Truy xuất phần tử");
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var a = list[0];
            var b = list[1];
            // để ý rằng chúng ta không cần ép kiểu cho a và b do List<T> có đặc tính strong-typed
            var c = a + b;
            Console.WriteLine($"Type of a: {a.GetType().Name}\r\nType of a: {b.GetType().Name}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CreateInitialize(); Console.WriteLine();
            Access(); Console.WriteLine();
            Console.ReadKey();
        }
    }
}