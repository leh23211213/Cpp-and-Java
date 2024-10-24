using System;
using System.Collections.Generic;
namespace AlgorithmAndStructure
{
    public class Stack
    {
        /// <summary>
        /// use List create Stack
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ListStack<T>
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
        public class LinkedListStack<T>
        {
            private readonly LinkedList<T> _list;
            public LinkedListStack() => _list = new LinkedList<T>();
            public int Count => _list.Count;
            public bool isEmpty => _list.Count == 0;
            public void Push(T item) => _list.AddFirst(item);
            public T Pop()
            {
                T temp = _list.First.Value;
                _list.RemoveFirst();
                return temp;
            }
            public void Clear() => _list.Clear();
            public T Peek() => _list.First.Value;

        }

        public bool IsValid(string s = "([]{})")
        {
            char[] tokens = s.ToCharArray();
            Stack<char> operators = new Stack<char>();
            int i = 0;
            while (i < tokens.Length)
            {
                if (tokens[i] == '{' || tokens[i] == '(' || tokens[i] == '[')
                {
                    operators.Push(tokens[i]);
                }
                else if (tokens[i] == '}' || tokens[i] == ')' || tokens[i] == ']')
                {
                    if (operators.Peek() == '{' || operators.Peek() == '(' || operators.Peek() == '[')
                    {
                        operators.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                i++;
            }
            return true;
        }
    }
}