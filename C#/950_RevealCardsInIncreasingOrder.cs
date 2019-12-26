public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        
        Queue<int> sortedDeck = new Queue<int>();  
        Queue<int> indexes = new Queue<int>();
        Array.Sort(deck);
        
        for (int i = 0; i < deck.Length; i++) {
            sortedDeck.Enqueue(deck[i]);
            indexes.Enqueue(i);
        }
        
        int[] ans = new int[deck.Length];
        bool draw = true;
        
        while (sortedDeck.Count > 0) {
            int index = indexes.Dequeue();
            if (draw)
                ans[index] = sortedDeck.Dequeue();
            else 
                indexes.Enqueue(index);
            
            draw = !draw;
        }
        
        
        return ans;
    }
}