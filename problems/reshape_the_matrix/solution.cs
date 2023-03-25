public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        if(r * c != mat.Length * mat[0].Length) return mat;
        int[][] newMatrix = new int[r][];
        for(int k = 0, i = 0, j = 0; k < r; k++) {
            newMatrix[k] = new int[c];
            for(int v = 0; v < c; v++, j++) {
                if(j >= mat[0].Length) {
                    i++;
                    j = 0;
                }
                if(i >= mat.Length) break;
                newMatrix[k][v] = mat[i][j];
            }
        }

        return newMatrix;
    }


}