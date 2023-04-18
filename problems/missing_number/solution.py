class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        return reduce(l := lambda x, y: x ^ y, nums) ^ reduce(l, range(1, len(nums)+1))