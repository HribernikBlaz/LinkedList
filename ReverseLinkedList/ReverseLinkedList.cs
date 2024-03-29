using System;
using System.Runtime.CompilerServices;

public class Node
{
    public int Data;
    public Node Next;
}

public class LinkedList
{
    public void Reverse(ref Node head)
    {
        Node current = null; // Initialize current node
        Node prev = null; // Initialize previous node
        Node next = null; // Initialize next node

        current = head; // Start from the head of the list
        while (current != null)
        {
            next = current.Next; // Store the next node
            current.Next = prev; // Reverse the current node's pointer
            prev = current; // Move prev to the current node
            current = next; // Move current to the next node
        }
        head = prev; // Update the head to point to the last node (which is now the first)
    }

    public void Print(Node head)
    {
        Node temp = head; // Start from the head of the list
        Console.Write("List is:");
        while (temp != null)
        {
            Console.Write(" " + temp.Data); // Print the data of the current node
            temp = temp.Next; // Move to the next node
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Create a linked list
        Node head = new Node() { Data = 8 };
        head.Next = new Node() { Data = 6 };
        head.Next.Next = new Node() { Data = 4 };
        head.Next.Next.Next = new Node() { Data = 2 };

        // Print the original list
        list.Print(head);

        // Reverse the list
        list.Reverse(ref head);

        // Print the reversed list
        list.Print(head);

        Console.ReadKey();
    }
}
