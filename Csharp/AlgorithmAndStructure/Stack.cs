using System.Xml;

namespace AlgorithmAndStructure
{
    class Program
    {
        /// <summary>
        /// use List create Stack
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class ListStack<T>
        {
            private int _topIndex;
            private readonly List<T> _list;
            public ListStack()
            {
                if (_list == null)
                {
                    _list = new List<T>();
                    _topIndex = -1;
                }
            }
            public int Count => _list.Count;
            public bool isEmpty => _list.Count == 0;
            public void Push(T item)
            {
                _list.Add(item);
                _topIndex++;
            }
            public T Pop()
            {
                T temp = _list[_topIndex];
                _list.RemoveAt(_topIndex);
                _topIndex--;
                return temp;
            }
            public void Clear()
            {
                _list.Clear();
                _topIndex = -1;
            }
            public T Peek()
            {
                return _list[_topIndex];
            }
        }
        /// <summary>
        /// use Linked List create Stack
        /// </summary>
        /// <typeparam name="T"></typeparam>

        class LinkedListStack<T>
        {
            private readonly LinkedList<T> _list;
        }
        static void Main(string[] args)
        {
            Console.Title = "Custom stack with list";
            var stack = new ListStack<string>();
            stack.Push("H");
            stack.Push("L");
            stack.Push("O");
            stack.Push("N");
            while (!stack.isEmpty)
            {
                var word = stack.Pop();
                Console.Write($"{word}");
            }
            Console.WriteLine($"\nStack count:{stack.Count}");
        }
    }
}