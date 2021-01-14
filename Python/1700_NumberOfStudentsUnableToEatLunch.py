class Solution:
    def countStudents(self, students: List[int], sandwiches: List[int]) -> int:
        queue = deque(students)
        sand = deque(sandwiches)
        count = 0
        while count < len(queue) and len(queue) > 0 and len(sand) > 0:
            pref = queue.popleft()
            if pref == sand[0]:
                count = 0
                sand.popleft()
            else:
                count += 1
                queue.append(pref)
        
        return len(queue)
        