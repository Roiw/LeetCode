class Solution:
    def isPalindrome(self, s: str) -> bool:
        
        
        if s == "" or len(s) == 1:
            return True
        
        s = s.lower()
        newString = ""
        for char in s:
            if char.isalpha() or char.isdigit():
                newString = newString + char
        
        if len(newString) == 0:
            return True
        
        print(newString)
        
        half = int(len(newString)/2) + 1
        
        if (len(newString)%2 == 0):
            int(len(newString)/2)
        
        for c in range(0, half, 1):
            aux = len(newString) -1 - c
            print("Comparing.." + newString[c] + " and " + newString[aux])
            if newString[c] != newString[aux]:
                return False
                                 
        return True