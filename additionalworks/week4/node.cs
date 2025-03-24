// This file defines a simple Node class for a doubly linked list.
// It contains properties for the data, previous node, and next node.
public class Node
{
    public int Data; // The data stored in the node
    public Node? Prev; // The previous node in the list (nullable)
    public Node? Next; // The next node in the list (nullable)

    // Constructor to initialize the node with data and set Prev and Next to null
    public Node(int data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}
// This file defines a simple implementation of a doubly linked list in C#.
// It includes a Node class to represent each element in the list and a DoublyLinkedList class to manage the list operations.