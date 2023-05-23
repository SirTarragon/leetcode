public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        if(timeSeries.Length == 0) return 0;
        int time = 0;
        for(int i = 0; i < timeSeries.Length - 1; i++)
            time += Math.Min(timeSeries[i+1]-timeSeries[i], duration);
        return time + duration;
    }
}