class Solution:
    def convert(self, s: str, numRows: int) -> str:
        if numRows == 1 or numRows >= len(s):
            return s
    
        sb = [''] * numRows
        cycleLen = 2 * numRows - 2
        for j in range(len(s)):
            remainder = j % cycleLen
            if remainder < numRows:
                i = remainder
            else:
                i = cycleLen - remainder
            sb[i] += s[j]
    
        return ''.join(sb)