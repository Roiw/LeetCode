public class Solution 
{
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        // O(N)
        // Check 1: We have to have the right size of cards.
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        Array.Sort(hand);
        Queue<int> queue = new Queue<int>(hand);
        List<List<int>> groups = new();
        while(queue.Count > 0)
        {
            int num = queue.Dequeue();
            bool added = false;
            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i][^1] == num - 1 && groups[i].Count < groupSize)
                {
                    groups[i].Add(num);
                    added = true;
                    break;
                }
            }
            if (added) continue;
            groups.Add(new List<int>() {num});
        }

        for (int i = 0; i < groups.Count; i++)
		{
			if (groups[i].Count < groupSize) 
				return false;
		}

        return true;
    }
}