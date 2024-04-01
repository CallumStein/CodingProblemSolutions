public class MyStack {

    // Declare processing queues as Class properties to simulate Stack
    // Uses inbuilt queue datatype of C#
    private Queue<int> queueMain;
    private Queue<int> queueTemp;

    public MyStack() {
        // Initialize the queues within the Class constructor
        queueMain = new Queue<int>();
        queueTemp = new Queue<int>();
    }
    
    public void Push(int x) {
        // The C# Queue types has the method .Enqueue(object) to add an object to the end of the queue
        queueMain.Enqueue(x);
    }
    
    public int Pop() {
        // While there are more than one elements in the main queue
        while(queueMain.Count > 1)
        {
            // Move all elements from the main queue to a temporary queue except for the last element
            queueTemp.Enqueue(queueMain.Dequeue());
        }

        // Remove the last element of the main queue (Top of the Stack)
        int topOfStack = queueMain.Dequeue();

        // Move the temporary queue back to the main queue (using C# Tuple swap)
        (queueMain, queueTemp) = (queueTemp, queueMain);

        // Return the top of the stack
        return topOfStack;
    }
    
    public int Top() {
        // While there are more than one elements in the main queue
        while(queueMain.Count > 1)
        {
            // Move all elements from the main queue to a temporary queue except for the last element
            queueTemp.Enqueue(queueMain.Dequeue());
        }

        // C# Queue datatype has .Peek() method that returns the first element of the queue without removing it
        int topOfStack = queueMain.Peek();

        // Move the final element to the temp queue to maintain stack integrity than swap the temp and main queues
        queueTemp.Enqueue(queueMain.Dequeue());
        (queueMain, queueTemp) = (queueTemp, queueMain);

        // Return the top of the stack
        return topOfStack;
    }
    
    public bool Empty() {
        // Check if the count of the main queue is equal to zero using ternary operator
        return (queueMain.Count == 0) ? true : false ;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */