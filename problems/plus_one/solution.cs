public class Solution {
    public int[] PlusOne(int[] digits) {
        int remainder = 1;
        for(int i = digits.Length - 1; i >= 0; i--) {
            int add = digits[i] + remainder;
            digits[i] = add % 10;
            remainder = add / 10;
            if(remainder <= 0) {
                break;
            }
        }

        if(remainder == 1) {
            digits = new int[digits.Length + 1];
            digits[0] = 1;
        }

        return digits;
    }
}