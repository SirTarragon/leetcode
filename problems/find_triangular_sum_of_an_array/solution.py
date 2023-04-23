class Solution:
    def triangularSum(self, nums: List[int]) -> int:
        for n in range(len(nums)):
            for i in range(len(nums) - n - 1):
                nums[i] = ((nums[i] + nums[i+1]) % 10)
        return nums[0]