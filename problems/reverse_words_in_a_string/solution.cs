public class Solution {
    public string ReverseWords(string s) {
        string[] array = s.Split(' ');
        StringBuilder reverse = new StringBuilder();

        for(int i = array.Length - 1; i >= 0; i--) {
            if(!string.IsNullOrEmpty(array[i])) {
                reverse.Append(" " + array[i]);
            }
        }

        return reverse.ToString().Trim();
    }
}