public class Solution 
{
    public int Compress(char[] chars)
    {
        int i = 0, j = 0;

        while (i < chars.Length)
        {
            char current = chars[i];
            int counter = 0;

            while (i < chars.Length && chars[i] == current)
            {
                i++;
                counter++;
            }

            chars[j++] = current;

            if (counter > 1)
            {
                foreach (var counterChar in counter.ToString())
                {
                    chars[j++] = counterChar;
                }
            }
        }

        return j;
    }
}