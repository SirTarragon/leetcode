public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, char> letters = new Dictionary<char, char>();

        StringBuilder check = new StringBuilder(s);

        for(int i = 0; i < check.Length; i++) {
            bool key_flag = letters.ContainsKey(s[i]),
                 val_flag = letters.ContainsValue(t[i]);

            if(val_flag && !key_flag) {
                return false; // loop check condition
            } else if(key_flag) {
                check[i] = letters[s[i]];
            } else {
                letters.Add(s[i], t[i]);
                check[i] = t[i];
            }
        }

        return t.Equals(check.ToString()); // final verifying check
    }
}