/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue* obj = new MyQueue();
 * obj->push(x);
 * int param_2 = obj->pop();
 * int param_3 = obj->peek();
 * bool param_4 = obj->empty();
 */


public class MyQueue {
    Stack<int> q, l; // queue and loader

    public MyQueue() {
        q = new Stack<int>();
        l = new Stack<int>();
    }
    
    public void Push(int x) {
        StackReverse(ref l, ref q);
        l.Push(x);
        StackReverse(ref q, ref l);
    }
    
    public int Pop() => q.Pop();
    public int Peek() => q.Peek();
    public bool Empty() => q.Count == 0;

    private void StackReverse(ref Stack<int> r, ref Stack<int> t) {
        while(t.Count != 0) r.Push(t.Pop());
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */