public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascal = new List<IList<int>>();
        int c = 1;
        for(int i = 0; i < numRows; i++) {
            IList<int> curr = new List<int>();
            for(int j = 0; j <= i; j++) {
                if(j == 0 || i == 0) {
                    c = 1;
                } else {
                    c=c * (i - j + 1)/j;
                }
                curr.Add(c);
            }
            pascal.Add(curr);
        }
        return pascal;
    }
}