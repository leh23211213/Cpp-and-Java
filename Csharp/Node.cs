public class Node<T> where T : IComparable
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node()
    {
        Data = default;
        Next = null;
    }
    public Node(T emplement)
    {
        Data = emplement;
        Next = null;
    }
}
public class LinkedList<T> where T : IComparable
{
    public Node<T> head { get; set; } = new Node<T>();

    public Node<T> Find(T Data)
    {
        var list = head;
        while (list != null && list.Data?.CompareTo(Data) != 0)
            list = head.Next;
        if (list != head)
            return list;
        return null;
    }
}