public class Solution {
    public bool IsPowerOfTwo(int n) => (n <= 0) ? false : (n & (n - 1)) == 0;
}