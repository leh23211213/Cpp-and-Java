using System;
using System.Collections.Generic;
using static System.Console;
namespace P02_BinarySearch
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Title = "BINARY SEARCH";
        //     var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //     Print(data);
        //     var value = 6;
        //     //var found = data.Search(value);
        //     var found = data.SearchRecursive(value);
        //     WriteLine($"Searching for {value} : {(found > -1 ? $"found at {found.ToString()}" : "not found")}");
        //     ReadKey();
        // }
        public static void Print<T>(IEnumerable<T> array)
        {
            ForegroundColor = ConsoleColor.Green;
            foreach (var i in array)
            {
                Write($"{i} ");
            }
            ResetColor();
            WriteLine();
        }
    }
    public static class BinarySearch
    {
        // sử dụng vòng lặp
        public static int Search<T>(this IList<T> data, T value) where T : IComparable
        {
            int upper = data.Count - 1, lower = 0, mid;
            while (lower <= upper)
            {
                int med = (upper + lower) / 2;
                if (data[med].CompareTo(value) == 0) return med;
                else if (value.CompareTo(data[med]) < 0)
                    upper = med - 1;
                else
                    lower = med + 1;
            }
            return -1; // không tìm thấy
        }
        // sử dụng đệ quy
        public static int SearchRecursive<T>(this IList<T> data, T value) where T : IComparable
        {
            int Recursive(int lower, int upper)
            {
                if (lower > upper)
                    return -1; // không tìm thấy
                else
                {
                    int med = (upper + lower) / 2;
                    if (value.CompareTo(data[med]) < 0)
                        return Recursive(lower, med - 1);
                    else if (value.CompareTo(data[med]) == 0)
                        return med;
                    else
                        return Recursive(med + 1, upper);
                }
            }
            return Recursive(0, data.Count - 1);
        }
    }
}