public class Solution {
    public IList<string> FizzBuzz(int n) {
        var fizzbuzz = new List<string>();
        for(int i = 1; i <= n; i++) {
            if(i % 3 == 0 && i % 5 == 0)
                fizzbuzz.Add("FizzBuzz");
            else if(i % 3 == 0)
                fizzbuzz.Add("Fizz");
            else if(i % 5 == 0)
                fizzbuzz.Add("Buzz");
            else
                fizzbuzz.Add($"{i}");
        }
        return fizzbuzz;
    }
}