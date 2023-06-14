public class Solution {
    public int EqualPairs(int[][] grid) {
        var rowFrequencies = new Dictionary<int, int>();
        for (var row = 0; row < grid.Length; row++) {
            var hash = grid[row][0].GetHashCode();
            for (var col = 0; col < grid.Length; col++)
                hash = HashCode.Combine(hash, grid[row][col].GetHashCode());
            rowFrequencies.TryGetValue(hash, out int frequency);
            rowFrequencies[hash] = frequency + 1;
        }

        int equalPairs = 0;
        int[] colArray = new int[grid.Length];

        for (var col = 0; col < grid.Length; col++) {
            var hash = grid[0][col].GetHashCode();
            for (var row = 0; row < grid.Length; row++)
                hash = HashCode.Combine(hash, grid[row][col].GetHashCode());
            rowFrequencies.TryGetValue(hash, out int frequency);
            equalPairs += frequency;
        }

        return equalPairs;
    }
}