/*

    Bottom up approach.
    
    When calculating the value for index i, we need to keep track of two variables:
    
    A: refers to the maximum value of all elements up to index i - 2.
    B: refers to the value at i - 1.
    
    For i we calculate:  Math.max(A + rob(i + 2), B) 
    
    Remember to update A afterwards: A = Math.max(A, B)

*/

/**
 * @param {number[]} nums
 * @return {number}
 */
var rob = function(nums) {
  if (nums.length == 0) return 0;
  if (nums.length == 1) return nums[0];
  if (nums.length == 2) return Math.max(nums[0], nums[1]);
  
  
  for (let i = 2; i < nums.length; i++) {
      let A = nums[i - 2]; let B = nums[i - 1];
      nums[i] = Math.max(A + nums[i], B);
      nums[i - 1] = Math.max(nums[i - 1], nums[i - 2]);
  }
  
  return nums[nums.length - 1];  
};


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

