using System;
using System.Runtime.CompilerServices;

public class Node
{
    public int Data;
    public Node Next;
}

public class LinkedList
{

    public void Print(Node p)
    {
        if (p == null) return; // Exit if the node is null
        Console.Write(p.Data + " "); // Print the value in the node
        Print(p.Next); // Recursive call to print the next node
    }

    public Node Insert(Node head, int data)
    {
        Node temp = new Node(); // Create a new node
        temp.Data = data; // Set its data
        temp.Next = null; // Set its next reference to null

        // If the linked list is empty, set the new node as the head
        if (head == null)
            head = temp;
        else
        {
            Node temp1 = head;
            // Traverse the list to find the last node
            while (temp1.Next != null)
                temp1 = temp1.Next;
            // Attach the new node to the end of the list
            temp1.Next = temp;
        }
        return head; // Return the head of the updated list
    }

    public void ReversePrint(Node p)
    {
        if (p == null)
            return; // Exit if the node is null
        ReversePrint(p.Next); // Recursive call to print the next node first
        Console.Write(" " + p.Data); // Print the value in the node
    }


    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        Node head = null;

        head = list.Insert(head, 1);
        head = list.Insert(head, 2);
        head = list.Insert(head, 3);
        head = list.Insert(head, 4);

        list.Print(head);
        Console.WriteLine();
        list.ReversePrint(head);

        Console.ReadKey();
    }
}
