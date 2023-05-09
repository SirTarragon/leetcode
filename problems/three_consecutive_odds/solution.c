bool threeConsecutiveOdds(int* arr, int arrSize){
    if(arrSize < 3) return false;
    long product = arr[0] * arr[1] * arr[2];
    if(product % 2 == 1) return true;
    for(int i = 3; i < arrSize && product % 2 != 1; i++)
        product = (product * arr[i]) / arr[i-3];
    return product % 2 == 1;
}