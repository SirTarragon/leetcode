public class Solution {
    public int CountNegatives(int[][] grid) => Enumerable.Range(0, grid.Length)
                                            .Select(i => Enumerable.Range(0, grid[i].Length)
                                                .Where(j => grid[i][j] < 0).Count()).Sum();
}