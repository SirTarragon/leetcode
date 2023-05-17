bool check(int* nums, int numsSize){
    char count = 0;
    for(int i = 1; i < numsSize; i++)
        if(nums[i] < nums[i - 1])
            if(++count > 1)
                return false;
    if(count == 1 && nums[numsSize - 1] > nums[0])
        return false;
    return true;
}