class Solution:
    def buyChoco(self, p: List[int], m: int) -> int:
        return f if 0 <= (f := m - sum(sorted(p)[:2])) else m