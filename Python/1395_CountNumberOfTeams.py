class Solution:
    def numTeams(self, rating: List[int]) -> int:
        teams = 0
        n = len(rating)
        for i in range(n):
            for j in range(i + 1, n):
                for k in range(j + 1, n):
                    s1, s2, s3 = rating[i], rating[j], rating[k]
                    if s1 > s2 > s3 or s3 > s2 > s1:
                        teams += 1
        return teams
        