/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let map = new Map();
    let ans = [-1,-1]
    
    nums.forEach((num, index) => {
        let desired = target - num;
        if (map.has(desired))
            ans = [map.get(desired), index];
        map.set(num, index);       
    });
    
    return ans
};