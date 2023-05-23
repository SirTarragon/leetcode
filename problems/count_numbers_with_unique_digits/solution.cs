public class Solution {
    public int CountNumbersWithUniqueDigits(int n) 
    {
        int sum = 1, product = 9;
        if (n >= 1) sum = 10;
        for (int i = 1; i < n; i ++) 
        {
            product *= 10 - i;
            sum += product;
        }
        return sum;
    }
}