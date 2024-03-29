using System;

public class Node
{
    public int Data;
    public Node Next;
}

public class LinkedList
{
    private Node head;

    public void Insert(int x)
    {
        Node temp = new Node();
        temp.Data = x; // Assign the provided value to the node's data
        temp.Next = head;
        head = temp;
    }

    public void Print()
    {
        Node temp = head;
        Console.Write("List is: ");

        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        Console.WriteLine("How many numbers?");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            linkedList.Insert(x); // Insert the entered number into the linked list
            linkedList.Print(); // Print the updated linked list
        }

        Console.ReadKey();
    }
}
