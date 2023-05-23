public class RecentCounter {
    private Queue<int> queue;

    public RecentCounter() 
    {
        queue = new Queue<int>();
    }
    
    public int Ping(int t) 
    {
        while(queue.Count != 0 && queue.Peek() < t - 3000 )
        {
            queue.Dequeue();
        }
        queue.Enqueue(t);

        return queue.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */