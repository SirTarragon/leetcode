class MyStack {
public:
    MyStack() {
        size = 0;
    }
    
    void push(int x) {
        local_stack.push(x);
        top_val = x;
        size++;
    }
    
    int pop() {
        queue<int> reverse;

        for(int i = 0; i < size - 1; i++) {
            reverse.push(local_stack.front());
            local_stack.pop();
        }
        int val = local_stack.front();
        local_stack.pop();
        local_stack = reverse;
        top_val = local_stack.back();
        size--;
        return val;
    }
    
    int top() {
        return local_stack.back();
    }
    
    bool empty() {
        return size == 0;
    }
    
private:
    queue<int> local_stack;
    int size;
    int top_val;
};

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack* obj = new MyStack();
 * obj->push(x);
 * int param_2 = obj->pop();
 * int param_3 = obj->top();
 * bool param_4 = obj->empty();
 */