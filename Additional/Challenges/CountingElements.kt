/*
* Given an integer array arr, count element x such that x + 1 is also in arr.
*
* If there're duplicates in arr, count them seperately.
*
*
*
* Example 1:
*
* Input: arr = [1,2,3]
* Output: 2
* Explanation: 1 and 2 are counted cause 2 and 3 are in arr.
* Example 2:
*
* Input: arr = [1,1,3,3,5,5,7,7]
* Output: 0
* Explanation: No numbers are counted, cause there's no 2, 4, 6, or 8 in arr.
* Example 3:*
*
* Input: arr = [1,3,2,3,5,0]
* Output: 3
* Explanation: 0, 1 and 2 are counted cause 1, 2 and 3 are in arr.
* Example 4:
*
* Input: arr = [1,1,2,2]
* Output: 2
* Explanation: Two 1s are counted cause 2 is in arr.
*
*
* Constraints:
*
* 1 <= arr.length <= 1000
* 0 <= arr[i] <= 1000
*/

/* NOTICE: This is an initial rough solution that need optimization! */
class Solution {
    fun countElements(arr: IntArray): Int {
        var total :Int = 0 
        val hMap = mutableMapOf<Int,Int>()
        for (i in arr){
            hMap[i] = hMap.getOrDefault(i, 0) + 1
        }     
        var hSet = arr.toMutableSet()
        var found = mutableListOf<Int>()
        var curr:Int = 0;     
        while (hSet.size > 0) {    
            for (element in hSet) { curr = element; break }
            hSet.remove(curr)
            found.addAll(recursiveFind(hSet,curr))
            
            // Calculate found size..
            var size = 0            
            for (f in found){
                size = size + hMap.getOrDefault(f,0)
            }
            if (size > total) total = size
        }       
        return total
    }
    
    fun recursiveFind(hSet: MutableSet<Int>, curr: Int): MutableList<Int> {
        var found = mutableListOf<Int>()
        if (hSet.contains(curr + 1)) { // Check forward
            found.add(curr)
            hSet.remove(curr + 1)
            found.addAll(recursiveFind(hSet, curr + 1))
        }
        if (hSet.contains(curr - 1)) {
            found.add(curr - 1)
            hSet.remove(curr - 1)
            found.addAll(recursiveFind(hSet, curr - 1))
        }
        return found
    }
}
