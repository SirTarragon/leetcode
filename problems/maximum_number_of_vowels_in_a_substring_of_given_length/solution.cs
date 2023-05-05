public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

        int count = 0;
        for(int i = 0; i < k; i++) {
            if(vowels.Contains(s[i]))
                count++;
        }
        
        int answer = count;

        for(int i = k; i < s.Length; i++) {
            if(vowels.Contains(s[i]))
                count++;
            if(vowels.Contains(s[i - k]))
                count--;
            if(count > answer)
                answer = count;
        }

        return answer;
    }
}