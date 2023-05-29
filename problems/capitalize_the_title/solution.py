class Solution:
    def capitalizeTitle(self, title: str) -> str:
        arr = title.lower().split()
        for i in range(len(arr)):
            if len(arr[i]) > 2:
                arr[i] = arr[i][0].upper() + arr[i][1::]
        return ' '.join(arr)