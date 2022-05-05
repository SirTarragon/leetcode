class MyQueue {
public:
    MyQueue() {
        size = 0;
    }
    
    void push(int x) {
        if(size == 0) {
            front_val = x;
        }
        local_queue.push(x);
        size++;
    }
    
    int pop() {
        stack<int> reverse;
        for(int i = 0; i < size - 1; i++){
            reverse.push(local_queue.top());
            local_queue.pop();
        }
        int val = local_queue.top();
        local_queue.pop();
        for(int i = 0; i < size - 1; i++) {
            if (i == 0) {
                front_val = reverse.top();
            }
            local_queue.push(reverse.top());
            reverse.pop();
        }
        size--;
        return val;
    }
    
    int peek() {
        return front_val;
    }
    
    bool empty() {
        return size == 0;
    }
    
    stack<int> local_queue;
    int size = 0;
    int front_val = 0;
};

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue* obj = new MyQueue();
 * obj->push(x);
 * int param_2 = obj->pop();
 * int param_3 = obj->peek();
 * bool param_4 = obj->empty();
 */