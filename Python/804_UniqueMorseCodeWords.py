class Solution:
    def uniqueMorseRepresentations(self, words: List[str]) -> int:
        letters = [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        
        sequences = set()
        
        for w in words:
            sequence = ""
            for c in w:
                sequence += letters[ord(c) - 97]
            sequences.add(sequence)
        
        return len(sequences)
                