class Solution {
public:
    int pivotInteger(int n) {
        double x =  sqrt(n * (n+1) / 2);
        return (floor(x) == ceil(x)) ? (int) x : -1;
    }
};