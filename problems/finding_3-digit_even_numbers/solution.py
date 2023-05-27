class Solution:
    def findEvenNumbers(self, digits: List[int]) -> List[int]:
        freq = Counter(digits)
        ans = []
        
        def dfs(length: int, num: int) -> None:
            if length == 0:
                if num % 2 == 0:
                    ans.append(num)
                return
            
            for i in range(10):
                if freq[i] == 0 or not freq[i]:
                    continue
                
                if length == 3 and i == 0:
                    continue
                    
                freq[i] -= 1
                dfs(length - 1, 10 * num + i)
                freq[i] += 1
        dfs(3, 0)
        
        return ans