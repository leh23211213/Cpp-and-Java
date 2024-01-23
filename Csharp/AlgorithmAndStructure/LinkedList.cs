

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
public class UserLinkedList<T> where T : IComparable
{
    public Node<T> head { get; set; } = new Node<T>();
    public UserLinkedList()
    { }
    public UserLinkedList(T element)
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
        while (currenNode.Next != null)
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
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         LinkedList<int> a = new LinkedList<int>(-1);
//         Node<int> b = new Node<int> { Data = 0 };
//         Node<int> c = new Node<int> { Data = 1 };
//         Node<int> d = new Node<int> { Data = 2 };
//         Node<int> e = new Node<int>(3);
//         Node<int> f = new Node<int>(4);
//         Node<int> g = new Node<int>(5);
//         a.head.Next = b;
//         b.Next = c;
//         c.Next = d;
//         d.Next = e;
//         e.Next = f;
//         f.Next = g;
//         a.Insert(55, 2);
//         Console.WriteLine();
//         a.Add(9);
//         a.Print();
//     }
// }

// using System.Text;

// public class Program
// {

//     public static void Main(string[] args)
//     {
//         Console.OutputEncoding = Encoding.Unicode;
//         var pages = Open("E:\\IT\\VSCode\\Github\\Fundamental\\Csharp\\AlgorithmAndStructure\\data.txt");
//         var current = pages.First;
//         while (current != null)
//         {

//             Console.WriteLine($" - page {current.Value.Number} -\r\n");
//             Console.WriteLine(current.Value.Content);
//             Console.WriteLine("/r/r< Previous [P] | [N] Next >");
//             switch (Console.ReadKey(true).Key)
//             {
//                 case ConsoleKey.N:
//                     if (current.Next != null)
//                     {
//                         current = current.Next;
//                     }
//                     break;
//                 case ConsoleKey.P:
//                     if (current.Previous != null)
//                     {
//                         current = current.Previous;
//                     }
//                     break;
//                 default: return;
//             }
//         }
//     }
//     class Page
//     {
//         public int Number { get; set; }
//         public string Content { get; set; }
//     }
//     static LinkedList<Page> Open(string file, int charPerPage = 1000)
//     {
//         Console.Title = Path.GetFileNameWithoutExtension(file);
//         LinkedList<Page> pages = new LinkedList<Page>();
//         var content = File.ReadAllText(file);
//         var p = 0;
//         for (p = 0; p < content.Length / charPerPage; p++)
//         {
//             var pageContent = content.Substring(charPerPage * p, charPerPage);
//             pages.AddLast(new Page { Number = p + 1, Content = pageContent });
//         }
//         pages.AddLast(new Page { Number = p + 1, Content = content.Substring(charPerPage * p) });
//         return pages;
//     }
// }