class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        
        num1 = ""
        for i in digits:
            num1 += str(i)
        a = int(num1) + 1
        num1 = str(a)
        digits.clear()
        for i in num1:
            digits.append(i)
        return digits
            