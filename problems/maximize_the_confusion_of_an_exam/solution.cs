public class Solution {
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        int maxSize = k;
        int[] count = new int[2];
        for(int i = 0; i < k; i++)
            count[(answerKey[i] == 'T') ? 0 : 1]++;

        for(int left = 0, right = k; right < answerKey.Length; right++) {
            count[(answerKey[right] == 'T') ? 0 : 1]++;

            while(Math.Min(count[0], count[1]) > k)
                count[(answerKey[left++] == 'T') ? 0 : 1]--;

            maxSize = Math.Max(maxSize, right - left + 1);
        }

        return maxSize;
    }
}