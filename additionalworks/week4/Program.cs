using System; // Required for Console.WriteLine

class Program // Main method to run the program
{
    static void Main(string[] args) // Entry point of the program
    {
        DoublyLinkedList list = new DoublyLinkedList(); // Create a new instance of the DoublyLinkedList

        // Original list
        list.InsertAtHead(4); // Insert nodes at head to create the list
        list.InsertAtHead(15); // Insert more nodes
        list.InsertAtHead(31);
        list.InsertAtHead(12);
        list.InsertAtHead(8);

        Console.WriteLine("Before inserting 42 at head:"); // Display the original list
        list.Display(); // Display the contents of the list

        // Insert new node at head
        list.InsertAtHead(42); // Insert a new node with data 42 at the head of the list

        Console.WriteLine("After inserting 42 at head:"); // Display the updated list
        list.Display();
    } // Closes Main
}     // Closes Program