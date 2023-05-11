public class Solution {
public int NumRescueBoats(int[] people, int limit) {
        int[] buckets = new int[limit+1];
        foreach(int p in people) buckets[p]++;
        int start = 0;
        int end = buckets.Length - 1;
        int solution = 0;
        while(start <= end) {
			//make sure the start always point to a valid number
            while(start <= end && buckets[start] <= 0) start++;
			//make sure end always point to valid number
            while(start <= end && buckets[end] <= 0) end--;
			//no one else left on the ship, hence break.
            if(buckets[start] <= 0 && buckets[end] <= 0) break;
            solution++;
            if(start + end <= limit) buckets[start]--; // both start and end can carry on the boat
            buckets[end]--;
        }
        return solution;
    }
}