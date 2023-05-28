class Solution {
public:
    string removeTrailingZeros(string num) {
        return num.erase(num.find_last_not_of('0') + 1);    
    }
};