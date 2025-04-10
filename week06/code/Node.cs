public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {

        // TODO Start Problem 1

        if (value == Data) // No duplicates allowed
        {
            
            return; 
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value); // Create new node if left is null
            else
                Left.Insert(value); // Recursive call to insert in left subtree
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value); // Create new node if right is null
            else
                Right.Insert(value); // Recursive call to insert in right subtree
        }
    }


    public bool Contains(int value) 
    {
        // TODO Start Problem 2

        if (value == Data) // Found the value
        {
            return true; 
        }
        else if (value < Data) // Search in the left subtree
        {
            return Left != null && Left.Contains(value); // Search in the left subtree
        }
        else
        {
            return Right != null && Right.Contains(value); // Search in the right subtree
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        int leftHeight = Left?.GetHeight() ?? 0; // if Left is null, height is 0
        int rightHeight = Right?.GetHeight() ?? 0; // if Right is null, height is 0
        return 1 + Math.Max(leftHeight, rightHeight); // Height of the current node
    }
}