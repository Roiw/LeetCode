# O(N Log N)
class Solution:
    def maxProfitAssignment(self, difficulty: List[int], profit: List[int], worker: List[int]) -> int:
        
        # Keep track of the biggest profit for each difficulty
        jobs = dict()
        for i in range(len(difficulty)):
            if difficulty[i] in jobs:
                jobs[difficulty[i]] = max(jobs[difficulty[i]], profit[i])
            else:
                jobs[difficulty[i]] = profit[i]
                
        # Sort worker and difficulty.
        difficulty.sort()
        worker.sort()
        
        # Two pointer: n (worker) and d (difficulty)
        maxProfit, cProfit, d = 0, 0, 0
        
        # Since you go from the weakest worker to the best and from the easiest task to the most difficult.
        # You can accumulate the max profit found for each worker and use it as a starting point for the next.
        for n in worker:
            while d < len(difficulty) and difficulty[d] <= n:
                cProfit = max(jobs[difficulty[d]], cProfit)
                d += 1
            maxProfit += cProfit
            
        return maxProfit
  