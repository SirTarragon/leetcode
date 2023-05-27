public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] digitCount = {0,0,0,0,0,0,0,0,0,0};
        foreach(int digit in digits)
            digitCount[digit]++;
        List<int> output = new();
        for(int num = 100; num < 999; num += 2) {
            int[] currentCount = {0,0,0,0,0,0,0,0,0,0};
            int temp = num;
            
            //max loop is 3
            while(temp > 0) {
                currentCount[temp % 10]++;
                temp /= 10;
            }

            bool flag = true;
            for(int i = 0; i < 10; i++) {
                if(currentCount[i] > digitCount[i]) {
                    flag = false;
                    break;
                }
            }

            if(flag)
                output.Add(num);
        }
        return output.ToArray();
    }
}