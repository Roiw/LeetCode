public class Solution {

    private Dictionary<int,int> _freq = new();
    private SortedSet<int> _costs = new();
    private void Add(int cost)
    {
        if (_freq.ContainsKey(cost))
        {
            _freq[cost]++;
        }
        else
        {
            _costs.Add(cost);
            _freq[cost] = 1;
        }
    }
    private int GetMax()
    {
        if (_costs.Count == 0)
        {
            return 0;
        }

        int max = _costs.Max;

        _freq[max]--;
        if (_freq[max] == 0)
        {
            _freq.Remove(max);
            _costs.Remove(max);
        }
        return max;
    }

    public int FurthestBuilding(int[] heights, int bricks, int ladders) 
    {
        int distance = 0;
        for (int i = 0; i < heights.Length - 1; i++)
        {
            int cost = heights[i + 1] - heights[i];
            bool paid = false;
            if (cost <= 0 )
            {
                distance ++;
                continue;
            }
            
            if (bricks >= cost )
            {
                bricks -= cost;
                Add(cost);
                paid = true;
            }
            else
            {
                while (ladders > 0)
                {
                    ladders--;
                    int maxPaid = GetMax();

                    if (maxPaid > cost)
                    {
                        Add(cost);
                        bricks += maxPaid;
                        bricks -= cost;
                        paid = true;
                        break;
                    }
                    else
                    {
                        Add(maxPaid);
                        paid = true;
                        break;
                    }
                }
            }

            if (paid)
            {
                distance ++;
            }
            else
            {
                break;
            }
        }
        return distance;
    }
}