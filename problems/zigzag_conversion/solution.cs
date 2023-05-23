public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        StringBuilder[] sb = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
            sb[i] = new StringBuilder();

        int cycleLen = 2 * numRows - 2;
        for (int i = 0, j; i < s.Length; i++)
        {
            j = i % cycleLen;
            sb[(j < numRows) ? j : cycleLen - j].Append(s[i]);
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numRows; i++)
            result.Append(sb[i].ToString());

        return result.ToString();
    }
}