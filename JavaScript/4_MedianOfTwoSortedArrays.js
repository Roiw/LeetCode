/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */

/*

    O(M + N)  

*/


var findMedianSortedArrays = function(nums1, nums2) {
    let arr = []
    let n1 = 0, n2 = 0;

    while (n1 < nums1.length || n2 < nums2.length) {
        
        if (n1 < nums1.length && n2 < nums2.length){
            if (nums1[n1] < nums2[n2]) {
                arr.push(nums1[n1]);
                n1++;
            }
            else {
                arr.push(nums2[n2]);
                n2++;
            }
                
        } 
        else if (n1 < nums1.length) {
            arr.push(nums1[n1]);
            n1 ++;
        }
        else if (n2 < nums2.length) {
            arr.push(nums2[n2]);
            n2 ++;
        }
    }
    
    let total = nums1.length + nums2.length;
    let avg = total % 2 === 0? [arr[total/2], arr[total/2 - 1]] : [arr[total/2 - 0.5]];
    
    return avg.length > 1? (avg[0] + avg[1])/2 : avg[0];
};
