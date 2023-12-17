
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> a = new LinkedList<int>(-1);
        Node<int> b = new Node<int> { Data = 0 };
        Node<int> c = new Node<int> { Data = 1 };
        Node<int> d = new Node<int> { Data = 2 };
        Node<int> e = new Node<int>(3);
        Node<int> f = new Node<int>(4);
        Node<int> g = new Node<int>(5);
        a.head.Next = b;
        b.Next = c;
        c.Next = d;
        d.Next = e;
        e.Next = f;
        f.Next = g;
        a.Insert(55, 2);
        Console.WriteLine();
        a.Add(9);
        a.Print();
    }
}