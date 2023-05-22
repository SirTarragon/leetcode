public class Solution {
    public bool ValidPalindrome(string s, bool flag = false) {       
        int n = s.Length;
        for(int i = 0; i < n / 2; i++)
            if(s[i] != s[n - 1 - i])
                if(flag) return false;
                else return ValidPalindrome(s.Remove(i,1), true) ||
                       ValidPalindrome(s.Remove(n-1-i,1), true);
        return true;
    }
}
 