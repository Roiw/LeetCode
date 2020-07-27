class Solution:
    def addDigits(self, num: int) -> int:
        if num <= 9: return num
        while num > 9: 
            answer = 0
            while num > 0:
                answer += num % 10
                num = num // 10
            if answer > 9: num = answer
        return answer
        
        