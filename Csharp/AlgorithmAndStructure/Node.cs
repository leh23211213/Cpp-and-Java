using System.Runtime.CompilerServices;
using System.Xml;

public class Node<T> where T : IComparable
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node()
    {
        Data = default;
        Next = null;
    }
    public Node(T element)
    {
        Data = element;
        Next = null;
    }
}
public class LinkedList<T> where T : IComparable
{
    public Node<T> head { get; set; } = new Node<T>();
    public LinkedList()
    { }
    public LinkedList(T element)
    {
        head.Data = element;
        head.Next = null;
    }
    public void Print()
    {
        var list = head;
        while (list != null)
        {
            Console.Write(list.Data + " -> ");
            list = list.Next;
        }
    }
    public Node<T> Find(T data)
    {
        if (head == null || head.Data.CompareTo(data) == 0)
        {
            return null;
        }

        var currenNode = head;
        while (currenNode != null && currenNode.Data?.CompareTo(data) != 0)
        {
            currenNode = currenNode.Next;
        }
        if (currenNode != head)
            return currenNode;
        return null;
    }
    public Node<T> FindPrevious(T data)
    {
        if (head == null || head.Data.CompareTo(data) == 0)
        {
            return null;
        }

        var currenNode = head;
        while (currenNode != null && currenNode.Next?.Data.CompareTo(data) != 0)
        {
            currenNode = currenNode.Next;
        }
        if (currenNode != head)
            return currenNode;
        return null;
    }
    public Node<T> Insert(T data, T afterValue)
    {
        var currenNode = Find(afterValue);
        var newNode = new Node<T>(data);
        if (currenNode != null)
        {
            newNode.Next = currenNode.Next;
            currenNode.Next = newNode;
            return currenNode;
        }
        return null;
    }
    public Node<T> Add(T Data)
    {
        var currenNode = head;
        if (currenNode == null)
        {
            return new Node<T>(Data);
        }
        while(currenNode.Next != null)
        {
            currenNode = currenNode.Next;
        }
        var newNode = new Node<T>(Data);
        currenNode.Next = newNode;
        return currenNode;
    }

    public void Traverse(Action<T> action)
    {
        var currenNode = head;
        while (currenNode.Next != null)
        {
            action?.Invoke(currenNode.Next.Data);
            currenNode = currenNode.Next;
        }
    }
}
