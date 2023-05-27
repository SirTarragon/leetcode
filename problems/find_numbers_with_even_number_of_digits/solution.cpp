class Solution {
public:
    int findNumbers(vector<int>& nums) {
        int evenCount = 0;
        for(int num : nums) {
            int count = 0;
            int temp = num;
            while(temp > 0) {
                count++;
                temp /= 10;
            }

            if(count % 2 == 0)
                evenCount++;
        }       
        return evenCount;       
    }
};