/*

You have a queue of integers, you need to retrieve the first unique integer in the queue.

Implement the FirstUnique class:

FirstUnique(int[] nums) Initializes the object with the numbers in the queue.
int showFirstUnique() returns the value of the first unique integer of the queue, and returns -1 if there is no such integer.
void add(int value) insert value to the queue.
 

Example 1:

Input: 
["FirstUnique","showFirstUnique","add","showFirstUnique","add","showFirstUnique","add","showFirstUnique"]
[[[2,3,5]],[],[5],[],[2],[],[3],[]]
Output: 
[null,2,null,2,null,3,null,-1]

Explanation: 
FirstUnique firstUnique = new FirstUnique([2,3,5]);
firstUnique.showFirstUnique(); // return 2
firstUnique.add(5);            // the queue is now [2,3,5,5]
firstUnique.showFirstUnique(); // return 2
firstUnique.add(2);            // the queue is now [2,3,5,5,2]
firstUnique.showFirstUnique(); // return 3
firstUnique.add(3);            // the queue is now [2,3,5,5,2,3]
firstUnique.showFirstUnique(); // return -1

*/

public class FirstUnique {

    private LinkedList<int> _uniques = new LinkedList<int>();
    private Dictionary<int,LinkedListNode<int>> _check = new Dictionary<int, LinkedListNode<int>>();
    
    public FirstUnique(int[] nums) {
        foreach (int i in nums)
            Add(i);
    }
    
    public int ShowFirstUnique() {
        return _uniques.First != null ? _uniques.First.Value : -1;
    }
    
    public void Add(int value) {
        if (!_check.ContainsKey(value)){
            LinkedListNode<int> n = _uniques.AddLast(value);
            _check.Add(value, n);
        } else if (_check[value] != null) {
            _uniques.Remove(_check[value]);
            _check[value] = null;
        }
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.ShowFirstUnique();
 * obj.Add(value);
 */
 