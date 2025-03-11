/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>

// FIXED: Added meaningful test cases to verify correct behavior of queue operations.
// FIXED: Added meaningful test cases to verify correct behavior of queue operations.
public class CustomerService {
    public static void Run() {
        Console.WriteLine("Test 1: Default Queue Size");
        var cs1 = new CustomerService(-1);
        Console.WriteLine(cs1.ToString()); // Should default to size 10
        Console.WriteLine("=================");

        Console.WriteLine("Test 2: Add Customers");
        var cs2 = new CustomerService(2);
        cs2.AddNewCustomer("Alice", "1001", "Password Reset");
        cs2.AddNewCustomer("Bob", "1002", "Billing Issue");
        cs2.AddNewCustomer("Charlie", "1003", "Login Problem"); // Should display "Maximum Number of Customers in Queue."
        Console.WriteLine(cs2.ToString());
        Console.WriteLine("=================");

        Console.WriteLine("Test 3: Serve Customers");
        cs2.ServeCustomer(); // Should serve Alice
        cs2.ServeCustomer(); // Should serve Bob
        cs2.ServeCustomer(); // Should display "No customers in queue."
        Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        // FIXED: Changed private to public to allow access to properties
        public string Name { get; }
        public string AccountId { get; }
        public string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer(string name = "TestUser", string accountId = "0000", string problem = "General Inquiry") {
    if (_queue.Count >= _maxSize) {
        Console.WriteLine("Maximum Number of Customers in Queue.");
        return;
    }

    // Create and add the customer without prompting
    var customer = new Customer(name, accountId, problem);
    _queue.Add(customer);
    
    Console.WriteLine($"Added Customer: {customer}");
}


    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
    // FIXED ERROR: 
    // Prevents an error when the queue is empty by checking _queue.Count == 0 
    // Ensures a customer is retrieved before removal.
    // Displays a clear message when serving a customer.
    if (_queue.Count == 0) {
        Console.WriteLine("No customers in queue.");
        return;
    }

    // Retrieve the first customer in the queue
    var customer = _queue[0];

    // Remove the customer from the queue
    _queue.RemoveAt(0);

    // Display the customer's details
    Console.WriteLine($"Serving Customer: {customer}");
}


    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}