public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> dict = magazine.GroupBy(c => c)
        .ToDictionary(g => g.Key, g => g.Count());
        for(int i = 0; i < ransomNote.Length; i++) {
            if(!dict.ContainsKey(ransomNote[i]))
                return false;
            
            if((--dict[ransomNote[i]]) < 0)
                return false;
        }
        return true;
    }
}