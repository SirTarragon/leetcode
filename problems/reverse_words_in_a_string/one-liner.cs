public class Solution {
    public string ReverseWords(string s) {
        return string.Join(' ', (s.Split().Where(s => !string.IsNullOrWhiteSpace(s))).Reverse()).Trim();
    }
}
