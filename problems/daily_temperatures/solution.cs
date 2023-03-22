public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        List<int> warmerTemps = new List<int>();
        for(int i = 0; i < temperatures.Length - 1; i++) {
            int count = 0;
            bool flag = false;
            for(int j = i; j < temperatures.Length; j++) {
                if(temperatures[j] > temperatures[i]) {
                    flag = true;
                    break;
                } else {
                    count++;
                }
            }

            if(!flag) count = 0;

            warmerTemps.Add(count);
        }
        warmerTemps.Add(0);
        return warmerTemps.ToArray();
    }
}