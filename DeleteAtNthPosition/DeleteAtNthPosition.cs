using System;

public class Node
{
    public int Data; // Data stored in the node
    public Node Next; // Reference to the next node in the list
}


public class LinkedList
{
    private Node head; // Reference to the first node in the list

    // Method to insert a new node with given data at the beginning of the list
    public void Insert(int x)
    {
        Node temp = new Node(); // Create a new node
        temp.Data = x; // Set its data
        temp.Next = head; // Make it point to the current head
        head = temp; // Update head to the new node
    }

    // Method to print all elements of the list
    public void Print()
    {
        Node temp = head; // Start from the head of the list
        Console.Write("List is: ");

        // Traverse the list and print each node's data
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next; // Move to the next node
        }
        Console.WriteLine();
    }

    // Method to delete a node at a specified position in the list
    public void Delete(int n)
    {
        Node temp1 = head; // Start from the head of the list

        // If the first node needs to be deleted
        if (n == 1)
        {
            head = temp1.Next; // Update head to the next node
            temp1.Next = null; // Remove the reference to the next node
            return;
        }

        // Traverse to the node just before the one to be deleted
        for (int i = 0; i < n - 2; i++)
        {
            temp1 = temp1.Next;
        }

        // Temporarily store the node to be deleted and adjust pointers
        Node temp2 = temp1.Next;
        temp1.Next = temp2.Next;
        temp2.Next = null;
    }

    // Main method for testing the LinkedList class
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.head = null; // Start with an empty list

        // Insert some elements into the list
        linkedList.Insert(1);
        linkedList.Insert(2);
        linkedList.Insert(3);
        linkedList.Insert(4); // List: 1,2,3,4
        linkedList.Print(); // Print the list

        int n;
        Console.Write("Position: ");
        n = int.Parse(Console.ReadLine()); // Read the position of the node to delete
        linkedList.Delete(n); // Delete the node at the specified position
        linkedList.Print(); // Print the updated list

        Console.ReadKey();
    }
}
