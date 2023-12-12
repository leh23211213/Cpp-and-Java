using System;
namespace P01_ConsoleOutput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(10); // in ra một số nguyên
            Console.WriteLine(10.0); // in ra một số thực
            Console.WriteLine(true); // in ra một giá trị logic
            Console.WriteLine("Hello world"); // in ra một chuỗi
            int a = 100;
            Console.WriteLine(a); // in ra một biến kiểu số nguyên
            bool b = false;
            Console.WriteLine(b); // in ra một biến kiểu logic
            string c = "Hi there!";
            Console.WriteLine(c); // in ra một biến kiểu xâu ký tự
            Console.Title = "Colorful Console";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Your name: ");
            Console.ResetColor();
            var name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(name);
            Console.ReadLine();
        }
    }
}