/*
A binary matrix means that all elements are 0 or 1. For each individual row of the matrix, this row is sorted in non-decreasing order.

Given a row-sorted binary matrix binaryMatrix, return leftmost column index(0-indexed) with at least a 1 in it. If such index doesn't exist, return -1.

You can't access the Binary Matrix directly.  You may only access the matrix using a BinaryMatrix interface:

BinaryMatrix.get(x, y) returns the element of the matrix at index (x, y) (0-indexed).
BinaryMatrix.dimensions() returns a list of 2 elements [n, m], which means the matrix is n * m.
Submissions making more than 1000 calls to BinaryMatrix.get will be judged Wrong Answer.  Also, any solutions that attempt to circumvent the judge will result in disqualification.

For custom testing purposes you're given the binary matrix mat as input in the following four examples. You will not have access the binary matrix directly.
*/

/**
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int x, int y) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution {   
    public int MinIndex = -1;
    public int NumRows = -1;
    
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        IList<int> dims = binaryMatrix.Dimensions();
        NumRows = dims[0];
        
        Find(binaryMatrix, 0, dims[1]-1);
        return MinIndex;
    }
    public void Find(BinaryMatrix bm, int r, int c) {
        int v = bm.Get(r,c);
        if (v == 1)
            MinIndex = c;
        
        if (v == 0 && r < NumRows-1)
            Find(bm, r + 1, c);
                
        if (v == 1 && c > 0 )
            Find(bm, r, c - 1);
    }
}
