public class Solution {
    public int DistinctPrimeFactors(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        void getFactors(int num){
            for(int i = 2; i * i<= num;i++){
                while(num % i == 0){
                    set.Add(i);
                    num /= i;
                }
            }
            if(num != 1) set.Add(num);
        }
        for(int j = 0; j < nums.Length;j++)
            getFactors(nums[j]);
        return set.Count();
    }
}