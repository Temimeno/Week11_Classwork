/*

class Node {
    private char value;
    private Node next = null;

    public Node(char value) {
        this.value = value;
    }

    public void SetNext(Node next) {
        this.next = next;
    }

    public Node Next() {
        return this.next;
    }

    public char GetValue() {
        return this.value;
    }
}

class LinkedList {
    private Node head = null;

    public void Add(Node node)
    {
        if(this.head == null)
        {
            this.head = node;
        }
        else
        {
            Node ptr = this.head;
            while(ptr.Next() != null)
            {
                ptr = ptr.Next();
            }
            ptr.SetNext(node);
        }
    }

    public Node Get(int index)
    {
        Node ptr = this.head;
        while(index > 0)
        {
            ptr = ptr.Next();
            index--;
        }
        return ptr;
    }
}

class Program {

    static void Main(string[] args) {
        LinkedList l = new LinkedList();
        l.Add(new Node('A'));
        l.Add(new Node('B'));
        l.Add(new Node('C'));
        l.Add(new Node('D'));
        Node n = l.Get(2);
        Console.WriteLine(n.GetValue());
    }

}

*/