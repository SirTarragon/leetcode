class MinStack {
public:
    MinStack() {
        size = 0;
        min = INT_MAX;
    }
    
    void push(int val) {
        if(size == 0 || val < min) {
            min = val;
        }
        local_stack.push_back(val);
        size++;
    }
    
    void pop() {
        int t = local_stack.back();
        local_stack.pop_back();
        if (t == min) {
            min = *min_element(local_stack.begin(), local_stack.end());
        }
        size--;
    }
    
    int top() {
        return local_stack[size-1];
    }
    
    int getMin() {
        return min;
    }
    
private:
    vector<int> local_stack;
    int size;
    int min;
};

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack* obj = new MinStack();
 * obj->push(val);
 * obj->pop();
 * int param_3 = obj->top();
 * int param_4 = obj->getMin();
 */