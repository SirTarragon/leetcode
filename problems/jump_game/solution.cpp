class Solution {
public:
    bool canJump(vector<int>& nums) {
        for(int i = 0, j = 0; i < nums.size() - 1; i++, j--) {
            if(nums[i] > j)
                j = nums[i];
            if(nums[i] == 0 && j == 0)
                return false;
        }
        
        return true;
    }
};