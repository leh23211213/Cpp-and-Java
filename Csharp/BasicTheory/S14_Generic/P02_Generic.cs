using System;
namespace ConsoleApp
{
    class ListInt
    {
        private int[] _data;
        public int Count => _data.Length;
        public ListInt(int size) => _data = new int[size];
        public void Set(int index, int value)
        {
            if (index >= 0 && index < _data.Length)
                _data[index] = value;
        }
        public int Get(int index)
        {
            if (index >= 0 && index < _data.Length)
                return _data[index];
            return default(int);
        }
    }
    class ListChar
    {
        private char[] _data;
        public int Count => _data.Length;
        public ListChar(int size) => _data = new char[size];
        public void Set(int index, char value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }
        public char Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(char);
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listInt = new ListInt(10);
            for (var i = 0; i < listInt.Count; i++)
                Console.Write($"{listInt.Get(i)}t");
            var listChar = new ListChar(10);
            for (var i = 0; i < listChar.Count; i++)
                Console.Write($"{listChar.Get(i)}t");
            Console.ReadKey();
        }
    }
}