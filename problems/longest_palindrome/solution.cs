public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> pal_count = new Dictionary<char, int>();
        int count = 0;
        foreach(char c in s) {
            if(pal_count.ContainsKey(c))
                pal_count[c]++;
            else
                pal_count.Add(c, 1);

            if(pal_count[c] % 2 == 1)
                count++;
            else
                count--;
        }
        if(count > 1)
            return s.Length - count + 1;
        return s.Length;
    }
}