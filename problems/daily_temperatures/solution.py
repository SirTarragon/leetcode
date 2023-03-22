class Solution:
    def dailyTemperatures(self, Temp: List[int]) -> List[int]:
        stack,result = [],[0]*len(Temp)
        
        for i,temp in enumerate(Temp):
            while stack and Temp[stack[-1]] < temp:
                index = stack.pop()
                result[index] = i - index     
            stack.append(i)      
        
        return result