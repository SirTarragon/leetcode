class Solution:
    def kItemsWithMaximumSum(self, numOnes: int, numZeros: int, numNegOnes: int, k: int) -> int:
        nums = numOnes + numZeros

        if k > nums:
            k -= nums
            nums = numOnes - k
        else:
            nums = min(numOnes, k)

        return nums