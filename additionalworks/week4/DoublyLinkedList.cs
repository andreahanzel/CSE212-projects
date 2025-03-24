// This code defines a simple implementation of a doubly linked list in C#.
// It includes a Node class to represent each element in the list and a DoublyLinkedList class to manage the list operations.
public class DoublyLinkedList
{
    private Node? head; // The head of the list
    private Node? tail; // The tail of the list

    public DoublyLinkedList() // Constructor to initialize the doubly linked list
    {
        head = null; // Initialize head to null
        tail = null; // Initialize tail to null
    }

// Method to insert a new node at the head of the list
    // This method creates a new node with the given data and inserts it at the beginning of the list.
    // If the list is empty, the new node becomes both the head and tail.
    public void InsertAtHead(int data)
    {
        Node newNode = new Node(data); // Create a new node with the given data

        if (head == null)
        {
            head = tail = newNode; // If the list is empty, set both head and tail to the new node
        }
        else
        {
            newNode.Next = head; // Set the new node's next to the current head
            head.Prev = newNode; // Set the current head's previous to the new node
            head = newNode; // Update head to the new node
        }
    }

/// Method to display the contents of the list
    // This method traverses the list from head to tail and prints the data of each node.
        public void Display()
    {
        Node? current = head; // Allow nullable since head can be null
        while (current != null)
        {
            Console.Write($"[{current.Data}]");
            if (current.Next != null) Console.Write(" <-> ");
            current = current.Next;
        }
        Console.WriteLine();
    }

}
