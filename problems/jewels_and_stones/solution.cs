public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        return stones.Count(i => jewels.Contains(i));
    }
}