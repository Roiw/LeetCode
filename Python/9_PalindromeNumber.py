class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0: return False
        reverse, aux = 0, x
        while aux > 0:
            increment = aux % 10
            reverse = reverse * 10 + increment
            aux = aux // 10
        if reverse == x: 
            return True
        return False
        