# 44
# Order dictionary -> [order, index]
# Go thorugh s if not contains on order -> save to string
# If contains save to bucket. Bucket is an array where each index is the index of the string
# Go through the bucket and recreate the string in order.
# O(n) + O(m)
class Solution:
    def customSortString(self, order: str, s: str) -> str:
        bucket = {}
        result = ""
        for i in s:
            if i not in order:
                result += i
            else:
                if i in bucket:
                    bucket[i] += 1
                else:
                    bucket[i] = 1
        
        for i in order:
            if i in bucket:
                result += i * bucket[i]
        return result