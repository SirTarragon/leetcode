public class Solution {
    public bool Check(int[] nums) {
        int[] sorted = nums.OrderBy(a => a).ToArray(), 
              check = new int[nums.Length];

        for(int x = 0; x < nums.Length; x++) {
            for(int i = 0; i < nums.Length; i++)
                check[i] = nums[(i+x) % check.Length];

            if(Enumerable.SequenceEqual(check, sorted))
                return true;
        }

        return false;
    }
}