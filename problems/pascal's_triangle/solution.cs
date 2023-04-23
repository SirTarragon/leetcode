public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascal = new List<IList<int>>();
        for(int i = 0; i < numRows; i++) {
            IList<int> row = new List<int>() {1};
            for(int k = 1; k < i; k++){
                row.Add(pascal[i - 1][k - 1] + pascal[i - 1][k]);
            }
            if(i > 0) row.Add(1);
            pascal.Add(row);
        }
        return pascal;
    }
}