public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder word = new StringBuilder("", word1.Length + word2.Length);
        for (int i = 0; i < word1.Length || i < word2.Length; i++) {
            if(i < word1.Length)
                word.Append(word1[i]);
            if(i < word2.Length)
                word.Append(word2[i]);
        }
        return word.ToString();
    }
}