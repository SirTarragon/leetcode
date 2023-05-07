class Solution {
public:
    double myPow(double x, int n) {
        double r = 1;
        long N = n;

        if(N < 0) {
            N *= -1;
            x = 1 / x;
        }
        
        if(N > 0 || N < 0)
            while(N != 0) {
                if((N & 1) == 1)
                    r *= x;

                x *= x;
                N >>= 1;
            }

        return r;
    }
};