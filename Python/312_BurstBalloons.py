"""

    DP Tabulation:
        - The matrix has length nums.len on both sides.
        - Position [1,2] is the max value from bursting an array that starts at index 1 e ends at index 2.
"""

class Solution:
    def maxCoins(self, nums: List[int]) -> int:
        size = len(nums)
        
        # Created tabulation
        mem = [[0 for i in range(size)] for j in range(size)]
        
        # For each length of the balloons array, starting at 1 going to N
        for length in range(1, size + 1):
            # Start on index 0 for each length
            for i in range( (size + 1) - length):
                j = i + length
                before = 1 if i == 0 else nums[i - 1]
                after = 1 if j >= size else nums[j]
                total = mem[i][j - 1]
                
                # Attempt to burst LAST every baloon for each range on the current Length.
                for burstedLast in range(i, j):
                    
                    # The value from the RIGHT of the bursted balloon.
                    right = 0 if burstedLast == j - 1 else mem[burstedLast + 1][j - 1]
                    
                    # The value from the LEFT of the bursted balloon.
                    left = 0 if burstedLast == i else mem[i][burstedLast - 1]
                    
                    # Calculate value from bursting the balloon.
                    current = before * after * nums[burstedLast]
                    
                    total = max(left + right + current, total)
                
                mem[i][j - 1] = total
        
        # The answer stays on the top right
        return mem[0][size -1]
                