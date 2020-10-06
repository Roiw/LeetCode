/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */


var levelOrderBottom = function(root) {
    if (root === null) return [];
    let queue = [];
    let ans = [];
    let currentLevel =[];
    let currentHeight = 0;
    queue.push([root, 0]);
    
    while (queue.length > 0) {
        let e = queue.shift();
        let node = e[0];
        let height = e[1];
        
        // Add to the answer.
        if (height === currentHeight)
            currentLevel.push(node.val);
        else {
            ans.push(currentLevel);
            currentLevel = [node.val];
            currentHeight++;
        }
        
        // Add children to queue..
        if (node.left !== null) queue.push([node.left, height + 1]);
        if (node.right !== null) queue.push([node.right,height + 1]);
    }
    ans.push(currentLevel);
    return ans.reverse();
};
