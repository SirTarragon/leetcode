public class MyQueue {
    Stack<int> queue;
    Stack<int> loader;
    int front;

    public MyQueue() {
        queue = new Stack<int>();
        loader = new Stack<int>();
    }
    
    public void Push(int x) {
        if(queue.Count == 0)
            front = x;

        while(queue.Count != 0)
            loader.Push(queue.Pop());
        loader.Push(x);

        while(loader.Count != 0)
            queue.Push(loader.Pop());
    }
    
    public int Pop() {
        int p = queue.Pop();
        if(queue.Count != 0)
            front = queue.Peek();
        return p;
    }
    
    public int Peek() => front;
    public bool Empty() => queue.Count == 0;
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */