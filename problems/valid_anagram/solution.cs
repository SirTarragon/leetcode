public class Solution {
    public bool IsAnagram(string s, string t) =>
        String.Equals(String.Concat(s.OrderBy(c=>c)),
                        String.Concat(t.OrderBy(c=>c)));
}