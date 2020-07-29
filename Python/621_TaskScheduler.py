class Solution:
    def leastInterval(self, tasks: List[str], n: int) -> int:
        # A dictionary with each task..
        # Get a task from the dictionary every time I 'can'
        # Otherwise wait.
        
        taskInformation = dict()
        for task in tasks:
            if task in taskInformation: 
                taskInformation[task][0] = taskInformation[task][0] + 1 
            else: taskInformation[task] = [1,0]
        
        remaining = len(taskInformation)
        clock = 0
        while remaining:
            modified = -1
            for task,info in taskInformation.items():
                if info[1] <= clock:
                    modified = task
                    break;
            if modified != -1:
                taskInformation[modified][0] -= 1
                taskInformation[modified][1] += (n+1)
                if taskInformation[modified][0] == 0: 
                    taskInformation.pop(modified)
                    remaining = len(taskInformation)
                
            clock += 1
        return clock
        