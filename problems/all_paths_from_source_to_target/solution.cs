public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var ans = new List<IList<int>>();
        var path = new List<int>();

        void dfs(int node) {
            if (node == graph.Length - 1) {
                ans.Add(new List<int>(path));
                return;
            }

            foreach(int n in graph[node]) {
                path.Add(n);
                dfs(n);
                path.RemoveAt(path.Count - 1);
            }
        }

        path.Add(0);
        dfs(0);

        return ans;
    }
}
