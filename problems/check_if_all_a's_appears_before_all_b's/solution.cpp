class Solution {
public:
    bool checkString(string s) {
        bool flag = false;
        for(int i = 0; i < s.length(); i++) {
            if(!flag && s[i] != 'a')
                flag = true;
            else if(flag && s[i] != 'b')
                return false;
        }
        return true;
    }
};