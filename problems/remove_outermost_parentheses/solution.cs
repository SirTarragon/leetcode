public class Solution {
    public string RemoveOuterParentheses(string s) {
        StringBuilder s_v = new StringBuilder();
        int count = 0;
        foreach(char c in s) {
            if(c == '(' && count++ > 0)
                s_v.Append(c);
            else if(c == ')' && count-- > 1) {
                s_v.Append(c);
            }
        }
        return s_v.ToString();
    }
}
