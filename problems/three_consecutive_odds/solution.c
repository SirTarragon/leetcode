bool threeConsecutiveOdds(int* arr, int arrSize){
    if(arrSize < 3) return false;
    int product = ((arr[0] % 2) + 2) * ((arr[1] % 2) + 2) * ((arr[2] % 2) + 2);
    if(product % 2 == 1) return true;
    for(int i = 3; i < arrSize && product % 2 != 1; i++)
        product = (product * ((arr[i] % 2) + 2)) / ((arr[i-3] % 2) + 2);
    return product %  2 == 1;
}