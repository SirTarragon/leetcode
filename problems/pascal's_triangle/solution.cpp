class Solution {
public:
    vector<vector<int>> generate(int numRows) {
        vector<vector<int>> pascal;
        for(int i = 0; i < numRows; i++) {
            vector<int> row {1};
            for(int k = 1; k <= i; k++) {
                row.push_back((int)((long)row[k - 1] * (i + 1 - k) / k));
            }
            pascal.push_back(row);
        }
        return pascal;
    }
};