public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        int[] freqWord = new int[26];

        for(int i = 0; i < word1.Length; i++) {
            freqWord[word1[i] % 26]++;
            freqWord[word2[i] % 26]--;
        }

        for(int i = 0; i < 26; i++)
            if(Math.Abs(freqWord[i]) > 3)
                return false;

        return true;
    }
}