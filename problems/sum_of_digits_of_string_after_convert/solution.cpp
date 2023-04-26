class Solution {
public:
    int addDigits(int num) {
        int sum = 0;
        while(num > 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    int getLucky(string s, int k) {
        int sum = 0;
        for (char c : s) {
            int num = c % 32;
            sum += (num < 10) ? num : addDigits(num);
        }
        for(int i = 0; i < k - 1; i++)
            sum = addDigits(sum);
        return sum;
    }
};