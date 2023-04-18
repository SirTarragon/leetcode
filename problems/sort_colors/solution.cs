public class Solution {
    public void SortColors(int[] nums) {
        int red = 0, white = 0, blue = 0;
        foreach(int n in nums) {
            switch(n) {
                case 0:
                    red++;
                    break;
                case 1:
                    white++;
                    break;
                case 2:
                    blue++;
                    break;
            }
        }
        for(int i = 0; red != 0 || white != 0 || blue != 0; i++) {
            if(red != 0) {
                nums[i] = 0;
                red--;
            } else if(white != 0) {
                nums[i] = 1;
                white--;
            } else if(blue != 0) {
                nums[i] = 2;
                blue--;
            }
        }
    }
}