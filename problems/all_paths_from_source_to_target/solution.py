
class Solution:
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
            ans = []
            path = []

            def dfs(node):
                if node == len(graph) - 1: 
                    ans.append(list(path))
                    return
                
                for x in graph[node]:
                    path.append(x)
                    dfs(x)
                    path.pop()
            
            path.append(0)
            dfs(0)

            return ans