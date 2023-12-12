
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> a = new LinkedList<int>(1);
        a.head.Data = 11;
        Node<int> b = new Node<int>(1);
        Node<int> c = new Node<int>(2);
        Node<int> d = new Node<int>(3);
        a.head.Next = b;
        b.Next = c;
        c.Next = d;
        a.Print();
    }
}