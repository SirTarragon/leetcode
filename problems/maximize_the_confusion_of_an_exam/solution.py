class Solution:
    def maxConsecutiveAnswers(self, answerKey: str, k: int) -> int:
        begin, end, window = 0, 0, 0
        n = len(answerKey)
        count = k
        char = {'T': 0, 'F': 0}

        while begin < n:
            char[answerKey[begin]] += 1
            
            while min(char['T'], char['F']) > k:
                char[answerKey[end]] -= 1
                end += 1 
            
            window = max(window, begin - end + 1)
            begin += 1

        return window