class Solution:
    def DFS(self, graph: List[List[int]], found: List[List[int]], path: List[int], node: int) -> List[List[int]]:
        path.append(node)
        if node == len(graph) -1: found.append(path)
        else: 
            for n in graph[node]: found = self.DFS(graph, found, path[:], n)
        return found
            
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
        return self.DFS(graph, [], [], 0)
        