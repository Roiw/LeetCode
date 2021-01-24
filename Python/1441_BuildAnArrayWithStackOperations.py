class Solution:
    def buildArray(self, target: List[int], n: int) -> List[str]:
        i = 0
        ans = []
        for num in range(1, n + 1):
            ans.append("Push")
            if target[i] != num:
                ans.append("Pop")
            else:
                i += 1
            if i == len(target):
                break
        return ans
