class Solution {
public:
    int minIncrements(int n, vector<int>& cost) {
        int res = 0, pathSum = 0;
        dfs(0, pathSum, res, n, cost);
        return res;
    }
    int dfs(int node, int pathSum, int& res, int lastNode, vector<int>& cost) {
        if(node*2+2 < lastNode) {
            int leftSum = dfs(node*2+1, pathSum+cost[node], res, lastNode, cost);
            int rightSum = dfs(node*2+2, pathSum+cost[node], res, lastNode, cost);
            res += abs(leftSum - rightSum);
            return cost[node] + max(leftSum, rightSum);
        }
        return cost[node];
    }
};