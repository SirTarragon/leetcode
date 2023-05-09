class Solution {
public:
    bool threeConsecutiveOdds(vector<int>& arr) {
        int count = 0;
        for(int i = 0; i < arr.size() && count != 3; i++)
            count = (arr[i] % 2 == 1) ? ++count : 0;
        return count == 3;       
    }
};