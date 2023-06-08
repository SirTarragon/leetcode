class Solution {
public:
    int countNegatives(vector<vector<int>>& grid) {
        int count = 0, n = grid[0].size(), m = grid.size();
        int negativeIndex = n - 1;

        for(int i = 0; i < m; i++) {
            while (negativeIndex >= 0 && grid[i][negativeIndex] < 0)
                negativeIndex -= 1;
            
            count += (n - (negativeIndex + 1));
        }

        return count;        
    }
};