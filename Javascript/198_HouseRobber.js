
// Memoized solution, passes very poorly on leetcode. :-( 
// To optimize we must generate less cases.

/*
    Memoized solution. 

    On this solution we generate way more combination than we actually need.
    For example the combination [2,x,x,x,3]. It's never good to have 3 index without being picked.
*/

function combinations(nums, pos, lastPicked, map) {
    if (nums.length == pos)
      return 0;
    
    if (map.has(pos)) return map.get(pos);
    let sum = 0;
    for (let i = pos; i < nums.length; i++ ) {
      if (lastPicked === i + 1 || lastPicked === i - 1) continue;
      sum = Math.max(sum, nums[i] + combinations(nums, i + 1, i, map));
    }
    map.set(pos, sum);
    return sum;
  }
  
  
  /**
   * @param {number[]} nums
   * @return {number}
   */
  var rob = function(nums) {
      let map = new Map();
      return combinations(nums, 0, -5, map);
  };