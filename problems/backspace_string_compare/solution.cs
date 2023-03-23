public class Solution {
    public bool BackspaceCompare(string s, string t) {
        s = BackspaceProcess(s);
        t = BackspaceProcess(t);
        Console.WriteLine(s);
        Console.WriteLine(t);

        return s.Equals(t);
    }

    public string BackspaceProcess(string s) {
        StringBuilder builder = new StringBuilder();
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == '#' && builder.Length != 0) {
                builder.Remove(builder.Length-1, 1);
            } else if (s[i] != '#'){
                builder.Append(s[i]);
            }
        }
        return builder.ToString();
    }
}