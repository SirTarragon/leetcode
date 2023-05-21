public class Solution {
    public string[] SortPeople(string[] names, int[] heights) => 
    names.Zip(heights, Tuple.Create).OrderByDescending(x => x.Item2).Select(y => y.Item1).ToArray();
}