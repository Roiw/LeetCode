/**
 * @param {string} s
 * @return {number}
 */
var maxLengthBetweenEqualCharacters = function(s) {
    let dict = new Map();
    
    for (let index = 0; index < s.length; index++){
        let letter = s[index];
        if (dict.has(letter)) {
            
            let arr = dict.get(letter);
            if (arr.length === 2) {
                arr[1] = index;
                
            }else {
                arr.push(index);
            }
            
            dict.set(letter, arr);
            
        } else {
            dict.set(letter, [index]);
        }
    }
    
    let ans = -1;
    dict.forEach( (elem, key) => {
        if(elem.length > 1){
            ans = Math.max(elem[1] - elem[0] - 1, ans);
        }
    })
    return ans;
};
