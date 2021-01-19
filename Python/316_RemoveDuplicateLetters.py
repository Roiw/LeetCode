'''

Add every letter to the stack and to a set of added letters.

Basically we want to add letters to the stack closely as possible to lexi order. If we can place a smaller letter on the top of the stack and we know there is another letter (same as the top) coming in the string, we can safely remove the letter that was on the top and place the smaller.

Letters that are already on the stack we skip (optimal order on the stack).

'''

class Solution:
    def removeDuplicateLetters(self, s: str) -> str:
        
        # Keep the last index of each character
        lastIndex = dict()
        
        for i in range(len(s)):
            lastIndex[s[i]] = i
        
        # keep track of letters we have.
        letters = set()  
        # the final word
        stack = []
        
        for i, c in enumerate(s):
            if c in letters:
                continue
            else:
                while stack and c < stack[-1] and lastIndex[stack[-1]] > i:
                    letter = stack.pop()
                    letters.remove(letter)
                stack.append(c)
                letters.add(c)
            
        return "".join(stack)
        