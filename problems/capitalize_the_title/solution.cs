public class Solution {
    public string CapitalizeTitle(string title) {
        string[] words = title.Split(" ");
        var rebuilder = new StringBuilder();
        for(int i = 0; i < words.Length; i++) {
            rebuilder.Append(words[i].ToLower());
            if(!(rebuilder.Length <= 2))
                rebuilder[0] = Char.ToUpper(rebuilder[0]);
            words[i] = rebuilder.ToString();
            rebuilder.Clear();
        }
        return String.Join(" ", words);
    }
}