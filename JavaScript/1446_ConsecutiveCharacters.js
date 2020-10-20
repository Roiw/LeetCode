/**
 * @param {string} s
 * @return {number}
 */
var maxPower = function(s) {
    let count = 1, power = 1;
    let lastChar = '';
    for (let char of s) {
        if (lastChar === char) {
            count++;
            power = Math.max(power, count);
        }            
        else {
            count = 1;
            lastChar = char;
        }            
    }
    return s === undefined || s === ''? 0 : power;
};
