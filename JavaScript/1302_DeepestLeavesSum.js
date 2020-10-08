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

var deepestLeavesSum = function(root) {
    sum = 0;
    depth = 0;
    queue = [];
    
    queue.push({ node: root, height: 0 });
    
    while (queue.length > 0) {
        let { node, height } = queue.shift();
        if ( node === null ) continue;
        
        if (height > depth) {
            deepest = []
            sum = 0;
            depth = height;
        }            
        
        sum += node.val;
        queue.push({ node: node.left, height: height + 1});
        queue.push({ node: node.right, height: height + 1});
    }
    
    return sum;
};
