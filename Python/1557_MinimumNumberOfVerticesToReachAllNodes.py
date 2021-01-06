class Solution:
    def findSmallestSetOfVertices(self, n: int, edges: List[List[int]]) -> List[int]:  
        nodes = set(range(n))
        for e in edges:
            if e[1] in nodes:
                nodes.remove(e[1])
        
        return nodes
        