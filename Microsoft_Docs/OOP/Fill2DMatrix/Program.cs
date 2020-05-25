using System;

namespace Fill2DMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            FillMatrix(matrix);
        }

        public static void FillMatrix(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = -1;
                }
            }
        }
    }
}
