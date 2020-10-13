var wordMap;

/**
 * @param {string[]} words
 */
var WordDistance = function(words) {
    wordMap = new Map();
    words.forEach( (w, index) => {
        if ( wordMap.has(w)){
            wordMap.get(w).push(index);
        }
        else {
            wordMap.set(w, [index]);
        }   
    });
};

/** 
 * @param {string} word1 
 * @param {string} word2
 * @return {number}
 */
WordDistance.prototype.shortest = function(word1, word2) {
    let pWord1 = wordMap.get(word1);
    let pWord2 = wordMap.get(word2);
    
    let i = 0, j = 0;
    let minDistance = Number.MAX_VALUE;
    while (i < pWord1.length && j < pWord2.length) {
        
        minDistance = Math.min(Math.abs(pWord1[i] - pWord2[j]), minDistance);
        if (pWord1[i] < pWord2[j]) i++;
        else j++;
    }
    
    return minDistance;
};

/** 
 * Your WordDistance object will be instantiated and called as such:
 * var obj = new WordDistance(words)
 * var param_1 = obj.shortest(word1,word2)
 */
 