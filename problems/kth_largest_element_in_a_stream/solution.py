class KthLargest:

    def __init__(self, k: int, nums: List[int]):
        nums.sort()
        self.mynums = list(nums)

        self.klargest = 0
        self.myk = k 

    def add(self, val: int) -> int:
        begin, end = 0, len(self.mynums) - 1
        

        while begin <= end:
            mid = begin + (end-begin)//2
            if self.mynums[mid] < val: begin = mid + 1
            else: end = mid - 1

        self.mynums.insert(begin, val)
        self.klargest = self.mynums[len(self.mynums) - self.myk]

        return self.klargest
            


# Your KthLargest object will be instantiated and called as such:
# obj = KthLargest(k, nums)
# param_1 = obj.add(val)