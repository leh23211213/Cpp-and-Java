using System;
namespace ConsoleApp
{
    internal class Program
    {
        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = b;
            b = a;
            a = temp;
        }
        private static void Main(string[] args)
        {            
            int a = 1, b = 2;
            Console.WriteLine($"type = {a.GetType()}");
            Console.WriteLine($"Before: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After : a = {a}, b = {b}");
            bool aa = true, bb = false;
            Console.WriteLine($"type = {aa.GetType()}");
            Console.WriteLine($"Before: a = {aa}, b = {bb}");
            Swap(ref aa, ref bb);
            Console.WriteLine($"After : a = {aa}, b = {bb}");
            Console.ReadKey();
        }
    }
}