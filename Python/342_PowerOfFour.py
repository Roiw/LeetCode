class Solution:
    def isPowerOfFour(self, num: int) -> bool:
        if num <= 0: return False
        possiblePower = math.log(num,4)
        return True if possiblePower == int(possiblePower) else False
    