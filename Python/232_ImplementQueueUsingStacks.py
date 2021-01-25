class MyQueue:

    popable = []
    fresh = []
    
    def __init__(self):
        """
        Initialize your data structure here.
        """
        fresh = []
        popable = []

    def push(self, x: int) -> None:
        """
        Push element x to the back of queue.
        """
        while len(self.popable) > 0:
            self.fresh.append(self.popable.pop())
            
        self.fresh.append(x)
        
        self.popable = []
        while len(self.fresh) > 0:
            self.popable.append(self.fresh.pop())
        

    def pop(self) -> int:
        """
        Removes the element from in front of queue and returns that element.
        """
        return self.popable.pop()
        

    def peek(self) -> int:
        """
        Get the front element.
        """
        return self.popable[-1]
        

    def empty(self) -> bool:
        """
        Returns whether the queue is empty.
        """
        return True if len(self.popable) == 0 else False
        


# Your MyQueue object will be instantiated and called as such:
# obj = MyQueue()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.peek()
# param_4 = obj.empty()