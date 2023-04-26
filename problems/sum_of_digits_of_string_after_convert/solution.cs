public class Solution {
    public int GetLucky(string s, int k) {
        StringBuilder l = new StringBuilder();
        foreach(char c in s) {
            l.Append(c - 'a' + 1);
        }
        for(int i = 0; i < k; i++) {
            int sum = 0;
            foreach(char c in l.ToString())
                sum += c - '0';
            l.Clear();
            l.Append(sum);   
        }
        return Convert.ToInt32(l.ToString());
    }
}