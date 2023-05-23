public class KthLargest {
    private List<int> Nums = new List<int>();
    private int K;

    public KthLargest(int k, int[] nums) {
        K = k;
        Nums = nums.OrderByDescending(i => i).ToList();
    }
    
    public int Add(int val) {
        if(Nums.Count == 0) {
            Nums.Add(val);
            return Nums.ElementAtOrDefault(K-1);
        }
        else if(Nums.Count == 1) {
            Nums.Insert((val > Nums[0]) ? 0 : 1, val);
            return Nums.ElementAtOrDefault(K-1);
        }
        else if(Nums.Count == 2) {
            Nums.Insert((val > Nums[0]) ? 0 : (val > Nums.ElementAtOrDefault(1)) ? 1 : 2, val);
            return Nums.ElementAtOrDefault(K-1);
        }

        int start = 0, end = Nums.Count, mid;

        while (start < end) {
            mid = start + (end - start) / 2;
            if (val >= Nums[mid]) {
                end = mid;
            } else {
                start = mid + 1;
            }
        }
        Nums.Insert(start, val);
            
        return Nums.ElementAtOrDefault(K-1);
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */