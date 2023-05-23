public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int[] pair = new int[spells.Length];
        for(int i = 0; i < spells.Length; i++) {
            int start = 0, end = potions.Length - 1, mid;
            pair[i] = 0;
            while(start <= end) {
                mid = start + (end - start) / 2;
                if((long) spells[i] * potions[mid] >= success) {
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }
            pair[i] = potions.Length - start;
        }
        return pair;
    }
}