public class Solution {
    public int MaxDivScore(int[] nums, int[] divisors) {
        int maxCount = 0, localCount, result = divisors[0];
        foreach(int divisor in divisors) {
            localCount = 0;
            foreach(int num in nums)
                if(num % divisor == 0)
                    localCount++;
            if(localCount > maxCount || 
            (localCount == maxCount && divisor < result)) {
                maxCount = localCount;
                result = divisor;
            }
        }
        return result;
    }
}