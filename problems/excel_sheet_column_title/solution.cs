public class Solution {
    public string ConvertToTitle(int columnNumber) {
        return (columnNumber <= 0) ? "" : ConvertToTitle((columnNumber - 1)/26) + (char)((columnNumber - 1) % 26 + 'A');
    }
}