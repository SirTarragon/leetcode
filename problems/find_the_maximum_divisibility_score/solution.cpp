class Solution {
public:
    int maxDivScore(vector<int>& nums, vector<int>& divisors) {
        unordered_map<int,int> mp;
        int maxi = INT_MIN;
        for(int i = 0; i < nums.size(); i++){
            mp[nums[i]]++;
            maxi = max(maxi, nums[i]);
        }
        int ans = 0, res = divisors[0];
        for(int i = 0; i < divisors.size(); i++){
            long long int t = divisors[i];
            int count = 0;
            while(t <= maxi){
                if(mp.find(t) != mp.end()) count += mp[t];
                t += divisors[i];
            }
            if(ans < count){
                ans = count;
                res = divisors[i];
            }
            else if(ans==count){
                res = min(res, divisors[i]);
            }
            
        }
        
        return res;
        
    }
};