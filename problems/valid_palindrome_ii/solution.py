class Solution:
    def validPalindrome(self, s: str) -> bool:
        return s == s[::-1] or ((b := s[:(j := (len(s) - (i := (next(x for x in range(len(s)) if s[x] != s[-x-1])))) - 1)] + s[j+1:]) == b[::-1]) or  ((a := s[:i]+s[i+1:]) == a[::-1])