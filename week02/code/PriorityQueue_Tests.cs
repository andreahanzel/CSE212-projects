using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add and remove multiple items from the queue
    // Expected Result: Items are dequeued by priority (highest first), and FIFO for same priority
    // Defect(s) Found: Loop in Dequeue doesn't check the last item in the queue, items are not removed from the queue
    
    // FIXED: Fixed test case to check the last item in the queue and remove items correctly. Added test case for empty queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 3);
        
        Assert.AreEqual("Third", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("First", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found:  No defects in this functionality
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // FIXED: Added testing that an exemption is thrown when trying to dequeue from an empty queue
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    // ADDED another test method
    [TestMethod]
    // Scenario: Add items with the same priority and verify FIFO order
    // Expected Result: First item with the highest priority is dequeued first
    // Defect(s) Found: When multiple items have the same high priority, the first one added should be removed first
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 1);
        
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

}