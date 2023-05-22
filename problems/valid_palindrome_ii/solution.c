bool validPalindrome(char * s){
    int start = 0;
    int end = strlen(s) - 1;
    bool center = true;
    bool left = true;
    bool right = true;
    do
    {
        center &= s[start] == s[end];
        if(!center) {
            left &= s[start + 1] == s[end];
            right &= s[start] == s[end - 1];
            if(!(left || right)) return false;
        }
    }
    while(++start < --end);

    return true;
}