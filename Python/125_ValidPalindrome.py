class Solution:
    def isPalindrome(self, s: str) -> bool:
        left, right = 0,len(s)-1
        while left < right:
            # Set left to a valid character..
            leftLetter = s[left].lower()
            validLowerCase =  leftLetter >= 'a' and leftLetter <= 'z'
            validNumber =  leftLetter >= '0' and leftLetter <= '9'
            if not validLowerCase and not validNumber:
                left += 1
                continue
                
            # Set right to a valid character..
            rightLetter = s[right].lower()
            validLowerCase =  rightLetter >= 'a' and rightLetter <= 'z'
            validNumber =  rightLetter >= '0' and rightLetter <= '9' 
            if not validLowerCase and not validNumber:
                right -= 1
                continue
            
            if leftLetter != rightLetter:
                return False
            
            right -= 1
            left += 1
            
        return True
        