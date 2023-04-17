class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int expSum = 0;
        int runSum = 0;
        for(int i = 0; i < nums.size(); i++) {
            expSum += i+1;
            runSum += nums[i];
        }
        return expSum - runSum;
    }
};