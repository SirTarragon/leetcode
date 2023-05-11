class Solution {
public:
    int compress(vector<char>& chars) {
        string s = "";
        char c, prev = '\0';
        for(int i = 0, count = 0; i <= chars.size(); i++, count++) {
            c = (i < chars.size()) ? chars[i] : '\0';
            if(prev == '\0')
                prev = c;
            if(prev != c) {
                s += prev;
                s += (count > 1) ? to_string(count) : "";
                prev = c;
                count = 0;
            }
        }
        chars.assign(s.begin(), s.end());
        return chars.size();        
    }
};