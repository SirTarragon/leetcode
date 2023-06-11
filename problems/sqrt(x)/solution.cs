public class Solution {
    public int MySqrt(int x) {
        if(x == 1) return x;

        for(double i = 0; i <= x; i++)
            if(i * i > x)
                return Convert.ToInt32(i - 1);

        return 0;
    }
}