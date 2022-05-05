class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> values;
        for(int i = 0; i < nums.size(); i++) {
            for(int j = 0; j < nums.size(); j++) {
                if(j != i && ((target - nums[i]) - nums[j]) == 0){
                    values.push_back(i);
                    values.push_back(j);
                    break;
                }
            }
            if(values.size() != 0) {
                break;
            }
        }
        return values;
    }
};