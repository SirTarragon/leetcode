public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach(char c in s)
            if(c != '*')
                stack.Push(c);
            else
                stack.Pop();

        char[] arr = new char[stack.Count];
        for(int i = arr.Length - 1; i >= 0; i--)
            arr[i] = stack.Pop();

        return new string(arr);
    }
}