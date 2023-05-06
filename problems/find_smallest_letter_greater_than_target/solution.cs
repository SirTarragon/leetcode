public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int start = 0, end = letters.Length - 1, mid, index = 0;
        while(start <= end) {
            mid = (start + end) / 2; 
            if (letters[mid] > target) {
                index = mid;
                end = mid - 1;
            } else
                start = mid + 1;
        }
        
        return letters[index];
    }
}