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
 * @return {number}
 */

let _max = Number.MIN_SAFE_INTEGER ;

function DFS(root) {
    if (root === null)
        return Number.MIN_SAFE_INTEGER;
    
    let left = DFS(root.left);
    let right = DFS(root.right);
    
    let child = left >= 0 && right >= 0? left + right : Math.max(left, right);
    
    let total = child > 0? child + root.val : root.val;
    _max = Math.max(_max, total);
    
    let toReturn = Math.max(left, right);
    
    return toReturn > 0? toReturn + root.val : root.val;
}

var maxPathSum = function(root) {
    _max = Number.MIN_SAFE_INTEGER;
    DFS(root);
    return _max;
};
