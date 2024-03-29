using System;

public class Node
{
    public int Data; // Stores the integer value
    public Node Next; // Points to the next node in the list
}

public class LinkedList
{
    private Node head; // Starting point of the linked list


    public void Print()
    {
        Node temp = head;
        Console.Write("List is: ");

        while (temp != null)
        {
            Console.Write(temp.Data + " "); // Prints the data of each node
            temp = temp.Next; // Moves to the next node via the reference to the next node
                              // until it reaches the end of the list (when temp becomes NULL)
        }
        Console.WriteLine();
    }

    // Inserts a new node with given data at the specified position in the linked list
    public void Insert(int data, int n)
    {
        Node temp1 = new Node(); // Creates a new node temp1
        temp1.Data = data; // Sets it's data to the provided data
        temp1.Next = null;

        // If the position is 1
        if (n == 1)
        {
            temp1.Next = head; // Inserts the new node at the beginning of the list
                               // by making it point to the current head
            head = temp1; // Updates the head to point to the new node
            return;
        }

        // Traverses the list until the node just before the specified position
        Node temp2 = head;
        for (int i = 0; i < n - 2; i++)
        {
            temp2 = temp2.Next;
        }
        temp1.Next = temp2.Next; // Inserts the new node between the node found 
        temp2.Next = temp1; // and it's next node

    }

    public static void Main(string[] args)
    {
        LinkedList l = new LinkedList();
        l.head = null;
        l.Insert(2, 1); // List: 2
        l.Insert(3, 2); // List: 2, 3
        l.Insert(4, 1); // List: 4, 2, 3
        l.Insert(5, 2); // List: 4, 5, 2, 3
        l.Print();

        Console.ReadKey();
    }
}
