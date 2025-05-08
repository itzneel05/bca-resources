// Question:
// Write a java program to implement matrix addition operation

class MatrixOperation {
    public int[][] addMatrices(int[][] matrix1, int[][] matrix2) {
        // Check if the matrices have the same dimensions
        if (matrix1.length != matrix2.length || matrix1[0].length != matrix2[0].length) {
            System.out.println("Matrices must have the same dimensions for addition.");
            return null; // Return null if dimensions do not match
        }

        int rows = matrix1.length;
        int cols = matrix1[0].length;
        int[][] result = new int[rows][cols];

        // Perform matrix addition
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i][j] = matrix1[i][j] + matrix2[i][j];
            }
        }

        // Return the result
        return result;
    }
    public static void main(String[] args) {
        MatrixOperation m = new MatrixOperation();
        // Example matrices for addition
        int[][] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[][] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };
        // Perform matrix addition
        int[][] result = m.addMatrices(matrix1, matrix2);

        // Print the result
        System.out.println("Result of matrix addition:");
        for (int i = 0; i < result.length; i++) {
            for (int j = 0; j < result[i].length; j++) {
                System.out.print(result[i][j] + " ");
            }
            System.out.println();
        }
    }
}
