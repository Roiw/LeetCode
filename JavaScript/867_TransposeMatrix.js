/**
 * @param {number[][]} A
 * @return {number[][]}
 */
var transpose = function(A) {
      let newArray = [];
  for(let i=0; i<A.length; i++ ){
    for (let j = 0; j < A[i].length; j++) {
      if (newArray.length === 0 || newArray.length === j )
        newArray.push([]);
      newArray[j].push(A[i][j]);
    }
  }
  return newArray;  
};
