using System;
namespace ConsoleApp
{
    class List<T>
    {
        private T[] _data;
        public int Count => _data.Length;
        public List(int size) => _data = new T[size];
        public void Set(int index, T value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }
        public T Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(T);
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listInt = new List<int>(10);
            for (var i = 0; i < listInt.Count; i++)
                Console.Write($"{listInt.Get(i)}t");
            var listChar = new List<char>(10);
            for (var i = 0; i < listChar.Count; i++)
                Console.Write($"{listChar.Get(i)}t");
            Console.ReadKey();
        }
    }
}