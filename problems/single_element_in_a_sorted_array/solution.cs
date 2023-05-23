public class Solution {
    public int SingleNonDuplicate(int[] a) {
        int start=0,end=a.Length-1;

        while(start<end){
            int mid=start+(end-start)/2;

            if(mid%2==0 &&a[mid]==a[mid+1] || mid%2==1 && a[mid-1]==a[mid])start=mid+1;
            else end=mid;
        } 
        return a[start];
    }
}