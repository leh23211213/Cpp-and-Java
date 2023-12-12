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
    public LinkedList(){
    }
    public LinkedList(T implement){
        head.Data = implement;
    }
    public Node<T> head { get; set; } = new Node<T>();
    public void Print(){
        var list = head;
        while (list != null)
        {
            Console.WriteLine(list.Data);
            list = list.Next;
        }
    }

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