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
    private int length = 0;

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
        length++;
    }

    public void Remove(int index)
    {
        if(index == 0)
        {
            Node ptr = this.head;
            this.head = this.head.Next();
            ptr.SetNext(null);
        }
        else
        {
            Node previousPtr = this.head;
            while(index > 1)
            {
                previousPtr = previousPtr.Next();
                index--;
            }
            Node ptr = previousPtr.Next();
            previousPtr.SetNext(ptr.Next());
            ptr.SetNext(null);
        }
        length--;
    }

    public void Insert(int index, Node node)
    {
        if(index == 0)
        {
            node.SetNext(this.head);
            this.head = node;
        }
        else
        {
            Node previousPtr = this.head;
            while(index > 1)
            {
                previousPtr = previousPtr.Next();
                index--;
            }
            node.SetNext(previousPtr.Next());
            previousPtr.SetNext(node);
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

    public int GetLength()
    {
        return this.length;
    }
}

class Program {

    static void Main(string[] args) {
        LinkedList l = new LinkedList();
        l.Add(new Node('A'));
        l.Add(new Node('B'));
        l.Add(new Node('D'));
        l.Insert(1, new Node('C'));
        Console.WriteLine(l.Get(1).GetValue());
    }

}