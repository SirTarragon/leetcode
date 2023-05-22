class Solution {
private:
    bool isPalindrome(const std::string& s) {
        int n = s.length();
        for (int i = 0; i < n / 2; i++) {
            if (s[i] != s[n - 1 - i])
                return false;
        }
        return true;
    }

public:
    bool validPalindrome(const std::string& s) {
        int n = s.length();
        for (int i = 0; i < n / 2; i++) {
            if (s[i] != s[n - 1 - i])
                return isPalindrome(s.substr(0, i) + s.substr(i + 1)) ||
                       isPalindrome(s.substr(0, n - 1 - i) + s.substr(n - i));
        }
        return true;
    }
};
