public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int b = 0, a = 0, l = 0, o = 0, n = 0; // balon greyjoy
        foreach(char c in text)
            switch(c) {
                case 'b':
                    b++;
                    break;
                case 'a':
                    a++;
                    break;
                case 'l':
                    l++;
                    break;
                case 'o':
                    o++;
                    break;
                case 'n':
                    n++;
                    break;
            }

        o /= 2;
        l /= 2;

        int min_double = (o <= l) ? o : l;
        int min_single = b;
        if(a < min_single)
            min_single = a;
        if(n < min_single)
            min_single = n;

        return (min_double < min_single) ? min_double : min_single;
        
    }
}