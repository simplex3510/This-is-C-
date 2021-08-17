// // 2. 두 행렬의 곱을 2차원 배열을 이용하여 계산하는 프로그램을 작성하시오.

// using System;

// namespace practice10_2
// {
//     class MainApp
//     {
//         static int[,] MatrixMultiplication(int[,] m1, int[,] m2)
//         {
//             int[,] matrix = { {m1[0, 0]*m2[0, 0] + m1[0, 1]*m2[1, 0], m1[0, 0]*m2[0, 1] + m1[0, 1]*m2[1, 1]},
//                               {m1[1, 0]*m2[0, 0] + m1[1, 1]*m2[1, 0], m1[1, 0]*m2[0, 1] + m1[1, 1]*m2[1, 1]}};
//             return matrix;
//         }

//         static void Main()
//         {
//             int[,] matrix1 = { {3, 2}, {1, 4} };
//             int[,] matrix2 = { {9, 2}, {1, 7} };
//             int[,] matrix = MatrixMultiplication(matrix1, matrix2);

//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1); j++)
//                 {
//                     Console.Write("{0} ", matrix[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }