class Solution {
    fun firstUniqChar(s: String): Int {
        
        var hs = mutableSetOf<Char>()
        var hm = mutableMapOf<Char, Int>()
        var i = 0;
        for (c in s) { 
            if( hm.put(c, i) != null) {hs.add(c)}
            i++;
        }
        for (c in s){
            if (!hs.contains(c)){
                return hm.getOrElse(c){-1};
            }
        }
        return -1
    }
}
