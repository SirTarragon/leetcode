public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int>() {1};
        for(int i = 0; i < rowIndex; i++) {
            row.Add((int)((long)row[i] * (rowIndex - i)/(i+1)));
        }
        return row;
    }
}