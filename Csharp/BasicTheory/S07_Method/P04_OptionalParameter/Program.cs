using System;
namespace P04_OptionalParameter
{
    internal class ConsoleHelper
    {
        /// <summary>
        /// Xuất thông tin ra console với màu sắc (WriteLine có màu)
        /// </summary>
        /// <param name="message"></param>
        /// <param name="bgColor"></param>
        /// <param name="fgColor"></param>
        /// <param name="resetColor"></param>
        public void WriteLine(object message, ConsoleColor bgColor = ConsoleColor.Black, ConsoleColor fgColor = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = fgColor;
            Console.BackgroundColor = bgColor;
            Console.WriteLine(message);
            if (resetColor)
                Console.ResetColor();
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Optional parameters";
            var helper = new ConsoleHelper();
            helper.WriteLine("Hello world from C#");
            helper.WriteLine("Hello world from C#", ConsoleColor.Cyan);
            helper.WriteLine("Hello world from C#", ConsoleColor.Cyan, ConsoleColor.Magenta);
            Console.ReadKey();
        }
    }
}