public class Solution {
    static void Swap<T>(ref T a, ref T b) {
        T c = a; a = b; b = c;
    }

    private void RecPermute(int[] nums, int index, ref IList<IList<int>> ans) {
        if(index >= nums.Length) {
            ans.Add(nums.ToList());
            return;
        }

        for(int i = index; i < nums.Length; i++) {
            Swap(ref nums[index], ref nums[i]);
            RecPermute(nums, index + 1, ref ans);
            Swap(ref nums[index], ref nums[i]);
        }
    }

    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        RecPermute(nums, 0, ref ans);
        return ans;
    }
}