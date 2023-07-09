public class Solution {
    public int DistributeCookies(int[] cookies, int k) {
        int sum = cookies.Sum();
        float average;
        int[] distribution = new int[k];
        average = sum / k;

        int dfs(int i, int count) {
            if(cookies.Length - i < count) {
                return Int32.MaxValue;
            }

            if(i == cookies.Length) {
                int unfairness = Int32.MinValue;
                for(int j = 0; j < k; j++) {
                    unfairness = Math.Max(unfairness, 
                                distribution[j]);
                }
                return unfairness;
            }

            int answer = Int32.MaxValue;
            
            for(int j = 0; j < k; j++) {
                count -= (distribution[j] == 0) ? 1 : 0;
                distribution[j] += cookies[i];
                answer = Math.Min(answer, dfs(i + 1, count));
                distribution[j] -= cookies[i];
                count += (distribution[j] == 0) ? 1 : 0;
            }

            return answer;
        }

        return dfs(0, k);
    }
}