using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items to the queue with different priorities and then dequeue one item.
    // Expected Result: The item with the highest priority is returned.
    // Defect(s) Found: The Dequeue method does not correctly find the item with the highest priority.
    // It should return the item with the highest priority, but it currently does not check the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add two items to the queue and dequeue both items.
    // Expected Result: The highest-priority item is returned first, and the
    // remaining item is returned second.
    // Defect(s) Found: The Dequeue method did not remove the item after returning it.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("High", first);
        Assert.AreEqual("Low", second);
    }

    // Add more test cases as needed below.
}