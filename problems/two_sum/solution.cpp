class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int,int> m;

        for (int i = 0; i < nums.size(); i++){
            int t = target - nums[i];
            auto r = m.equal_range(t);
            for (auto it = r.first; it != r.second; it++){
                if (it->second != i && it->first == t){
                    return {i, it->second};
                }
            }
            m[nums[i]] = i;
        }
        
        return {0,0};
    }
};