public class Solution {
    public string[] FindWords(string[] words) {
        var dic = new Dictionary<char, int>();
        var answer = new List<string>();
        foreach(char c in "qwertyuiop")
            dic.Add(c,1);
        foreach(char c in "asdfghjkl")
            dic.Add(c,2);
        foreach(char c in "zxcvbnm")
            dic.Add(c,3);
        foreach(var word in words) {
            int n = dic[char.ToLower(word[0])];
            bool match = true;
            foreach(char c in word) {
                if(dic[char.ToLower(c)] != n) {
                    match = false;
                    break;
                }
            }
            if(match)
                answer.Add(word);
        }
        return answer.ToArray();
    }
}