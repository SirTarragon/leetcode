public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] digitCount = new int[10];
        foreach(int d in digits)
            digitCount[d]++;
        List<int> output = new();
        for(int i = 100; i < 999; i += 2) {
            byte d1 = (byte)(i % 10), 
                d2 = (byte)((i / 10) % 10),
                d3 = (byte)((i / 100) % 10);
            digitCount[d1]--;
            digitCount[d2]--;
            digitCount[d3]--;

            bool flag = true;
            if(digitCount[d1] < 0 || 
               digitCount[d2] < 0 ||
               digitCount[d3] < 0) {
                   flag = false;
            }

            digitCount[d1]++;
            digitCount[d2]++;
            digitCount[d3]++;

            if(flag)
                output.Add(i);
        }
        return output.ToArray();
    }
}