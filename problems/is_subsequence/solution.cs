public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length > t.Length) return false;
        if(string.IsNullOrEmpty(s)) return true;

        int checkValue = 0;
        for(int i = 0; checkValue < s.Length && i < t.Length; i++) {
            if(s[checkValue] == t[i]) {
                checkValue++;
            }
        }

        return checkValue == s.Length;
    }
}