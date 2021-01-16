class Solution:
    def reverseParentheses(self, s: str) -> str:
        stack = deque()
        word = ''
        for c in s:
            if c == '(':
                stack.append(word)
                word = ''
            elif c == ')':
                word = stack.pop() + word[::-1]
            else:
                word += c
        return word  
        