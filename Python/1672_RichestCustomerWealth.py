class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        maxMoneys = -1
        for customerAccounts in accounts:
            moneys = 0
            for account in customerAccounts:
                moneys += account
            maxMoneys = max(maxMoneys, moneys)
        return maxMoneys
        