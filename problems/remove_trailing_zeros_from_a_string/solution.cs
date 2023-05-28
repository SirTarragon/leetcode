public class Solution {
    public string RemoveTrailingZeros(string num) {
        int i = num.Length - 1;
        while(num[i] == '0' && i >= 0) { i--; }
        return num.Substring(0, i + 1);
    }
}