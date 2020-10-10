/**
 * @param {string} s
 * @return {number}
 */


function evaluate(s) {
  var result = 0;
  let n = '0'

  for (let i = 0; i < s.length; i++) {
    if ( s[i] === ' ') { continue; }

    else if( s[i] === '-') {
      if (n === '-') { n = ''; } 
      else if (n === '+') { n = '-' }
      else {
        let aux = parseInt(n, 10);
        result += isNaN(aux) ? 0 : aux;
        n = '-';
      }
    } 
    
    else if (s[i] === '+') {
      if (n === '-') { n = '-' }
      else if (n === '+') { continue; }
      else {
        let aux = parseInt(n, 10);
        result += isNaN(aux) ? 0 : aux;
        n = '';
      }
    }
    else { n += s[i]; }
  }

  let aux = parseInt(n, 10);
  result += isNaN(aux) ? 0 : aux;
  return result;
}


var calculate = function(s) {
  let result = 0;
  let stack = [''];
  for (let i  = 0; i < s.length; i++){
    if ( s[i] === '('){
      stack.push('');
    } else if ( s[i] === ')' ) {
      let n =  evaluate(stack.pop());
      stack[stack.length - 1] += n.toString();
    } else {
      stack[stack.length - 1] += s[i];
    }
  }
  return evaluate(stack.pop());
};
