class Solution:
    def DFS(self, graph: List[List[int]], path: List[int], node: int) -> List[List[int]]:
        path.append(node)
        if node == len(graph) -1: return [path]
        if node == None: return []
        
        rtn = []
        for n in graph[node]:
            p = self.DFS(graph, path[:], n)
            if len(p) > 0: 
                rtn = rtn + p            
        return rtn
            
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
        return self.DFS(graph, [], 0)
        