import re
class Solution:
    def isPalindrome(self, s: str) -> bool:
        check = re.sub('[^0-9a-zA-Z]+', '', s).lower()
        return check == check[::-1]